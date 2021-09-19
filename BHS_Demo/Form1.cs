using bhs.opc.client;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BHS_Demo.App_Data;

namespace BHS_Demo
{
    public partial class Form1 : Form
    {
        OPCUAClient opc = new OPCUAClient();
        string currentMonitorNodeId = string.Empty;
        public Form1()
        {
            InitializeComponent();
            opc.OnConnectedEvent += Opc_ConnectComplete;
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private async void btnConnectServer_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
            await opc.ConnectServer(this.txtServer.Text.Trim());
            this.pictureBox1.Visible = false;
            
        }

        private void Opc_ConnectComplete(object sender, EventArgs e)
        {
            GenerateNode(ObjectIds.ObjectsFolder, this.treeView1.Nodes);
            lbl_msg.Text = "Connect Success";
        }

        async void GenerateNode(NodeId nodeId, TreeNodeCollection nodeCollection)
        {
            nodeCollection.Clear();
             
            nodeCollection.Add("加载节点中...");

            var nodes= await Task.Run(() => {
                List<TreeNode> list = new List<TreeNode>();
                var referDescCollections = opc.BrowserNode(nodeId);
                if (referDescCollections!= null)
                {
                    for (int i = 0; i < referDescCollections.Count; i++)
                    {
                        var refer = referDescCollections[i];
                        TreeNode child = new TreeNode(Utils.Format("{0}", refer));
                        child.Tag = refer;
                        if (opc.BrowserNode((NodeId)refer.NodeId).Count > 0)
                        {
                            child.Nodes.Add(new TreeNode());
                        }
                        list.Add(child);
                    }
                }
                return list.ToArray();
            });

            nodeCollection.Clear();
            nodeCollection.AddRange(nodes);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count != 1)
                {
                    return;
                }

                var reference = e.Node.Tag as ReferenceDescription;
                if (reference == null || reference.NodeId.IsAbsolute)
                {
                    e.Cancel = true;
                    return;
                }
                GenerateNode((NodeId)reference.NodeId, e.Node.Nodes);
            }
            catch
            {
                MessageBox.Show("节点加载失败");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;

            try
            {
                ReferenceDescription reference = e.Node.Tag as ReferenceDescription;
                ShowMember((NodeId)reference.NodeId);
                if (textBox_nodeId.Text != "")
                    ReadNodeValue();
            }
            catch { }
          
        }

        private async void ShowMember(NodeId sourceId)
        {
            textBox_nodeId.Text = sourceId.ToString();
            int index = 0;
          
            try
            {
               var dataValuesTemp= opc.ReadNode(sourceId);
                if (dataValuesTemp.WrappedValue != Variant.Null)
                {
                    string type = dataValuesTemp.WrappedValue.TypeInfo.BuiltInType.ToString();
                    this.lblNodeTypeInfo.Text = type;
                }
                if (opc.IsWriteableNode(sourceId))
                {
                    this.btnWrite.Enabled = true;
                }
                else
                {
                    this.btnWrite.Enabled = false;
                }
                
             
            }
            catch
            {              
            }
        }

      

        
        private void 刷新节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode == null) return;

            TreeNode treeNode = this.treeView1.SelectedNode;
            var reference = treeNode.Tag as ReferenceDescription;
            if (reference == null || reference.NodeId.IsAbsolute)
            {
                return;
            }
            GenerateNode((NodeId)reference.NodeId,treeNode.Nodes);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (this.treeView1.SelectedNode == null)
            {
                e.Cancel = true;
                return;
            }
            try
            {
                TreeNode treeNode = this.treeView1.SelectedNode;
                Rectangle rectangle = treeNode.Bounds;
                this.contextMenuStrip1.Show(this.treeView1, new Point(rectangle.X + rectangle.Width + 10, rectangle.Y + rectangle.Height / 2));
            }
            catch { }
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadNodeValue();
        }

        void ReadNodeValue()
        {
            try
            {
                DataValue dataValue = opc.ReadNode(new NodeId(textBox_nodeId.Text));
                if (dataValue != null&&dataValue.WrappedValue!=Variant.Null)
                {
                    txtReadResult.Text = dataValue.WrappedValue.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            if (textBox_nodeId.Text.Trim() == "") return;
            try
            {
                string nodeId = this.textBox_nodeId.Text;
                string value = this.txtWriteValue.Text;
                DataValue dataValue = opc.ReadNode(new NodeId(textBox_nodeId.Text));
                if (dataValue.WrappedValue == Variant.Null)
                {
                    MessageBox.Show("数据类型获取为空");
                    return;
                }
                var type = dataValue.WrappedValue.TypeInfo.BuiltInType;
                bool result = false;
                switch (type)
                {
                    case BuiltInType.Boolean:
                        result= await opc.WriteNodeAsync(nodeId, bool.Parse(value));
                        break;
                    case BuiltInType.Int16:
                        result = await opc.WriteNodeAsync(nodeId, short.Parse(value));
                        break;
                    case BuiltInType.UInt16:
                        result = await opc.WriteNodeAsync(nodeId, ushort.Parse(value));
                        break;
                    case BuiltInType.Int32:
                        result = await opc.WriteNodeAsync(nodeId, int.Parse(value));
                        break;
                    case BuiltInType.UInt32:
                        result = await opc.WriteNodeAsync(nodeId, uint.Parse(value));
                        break;
                    case BuiltInType.String:
                        result = await opc.WriteNodeAsync(nodeId, value);
                        break;
                    case BuiltInType.Float:
                        result = await opc.WriteNodeAsync(nodeId, float.Parse(value));
                        break;
                    case BuiltInType.DateTime:

                        result = await opc.WriteNodeAsync(nodeId, DateTime.Parse(value).ToLocalTime());
                        break;
                }
                
                if (result)
                {
                    ReadNodeValue();
                }
                else
                {
                    MessageBox.Show("写入失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
 


        private void btnSave_Click(object sender, EventArgs e)
        {
            DBHelper<tb_Simulator> dbhelper = new DBHelper<tb_Simulator>();
            var entityes = dbhelper.FindList(x => x.NodeId == textBox_nodeId.Text);
            if (entityes.Any())
            {
                tb_Simulator simulator = entityes.FirstOrDefault();
                simulator.NodeValue= txtReadResult.Text;
                dbhelper.Update(simulator);
 
                lbl_msg.Text = "Update success!";
            }
            else
            {
                tb_Simulator simulator = new tb_Simulator();
                simulator.NodeId = textBox_nodeId.Text;
                simulator.NodeType = lblNodeTypeInfo.Text;
                simulator.NodeValue = txtReadResult.Text;
                dbhelper.Add(simulator);
                lbl_msg.Text = "Insert success!";
            }
        }


    }
}
