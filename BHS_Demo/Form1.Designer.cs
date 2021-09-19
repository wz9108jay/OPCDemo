
namespace BHS_Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nodeId = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtReadResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWriteValue = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNodeTypeInfo = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(115, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "OPC UA Server";
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnConnectServer.Location = new System.Drawing.Point(1131, 44);
            this.btnConnectServer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(155, 69);
            this.btnConnectServer.TabIndex = 49;
            this.btnConnectServer.Text = "Connect";
            this.btnConnectServer.UseVisualStyleBackColor = true;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("宋体", 16F);
            this.txtServer.Location = new System.Drawing.Point(259, 54);
            this.txtServer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(837, 44);
            this.txtServer.TabIndex = 48;
            this.txtServer.Text = "opc.tcp://192.168.31.54:49320";
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.treeView1.Location = new System.Drawing.Point(30, 136);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(514, 620);
            this.treeView1.TabIndex = 51;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新节点ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 34);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 刷新节点ToolStripMenuItem
            // 
            this.刷新节点ToolStripMenuItem.Name = "刷新节点ToolStripMenuItem";
            this.刷新节点ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.刷新节点ToolStripMenuItem.Text = "刷新节点";
            this.刷新节点ToolStripMenuItem.Click += new System.EventHandler(this.刷新节点ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BHS_Demo.Properties.Resources.ajax_loader;
            this.pictureBox1.Location = new System.Drawing.Point(1056, 423);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(607, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Node Tag：";
            // 
            // textBox_nodeId
            // 
            this.textBox_nodeId.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox_nodeId.Location = new System.Drawing.Point(718, 135);
            this.textBox_nodeId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_nodeId.Name = "textBox_nodeId";
            this.textBox_nodeId.Size = new System.Drawing.Size(532, 37);
            this.textBox_nodeId.TabIndex = 55;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnRead.Location = new System.Drawing.Point(427, 30);
            this.btnRead.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 54);
            this.btnRead.TabIndex = 57;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtReadResult
            // 
            this.txtReadResult.Font = new System.Drawing.Font("宋体", 13F);
            this.txtReadResult.Location = new System.Drawing.Point(156, 36);
            this.txtReadResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReadResult.Multiline = true;
            this.txtReadResult.Name = "txtReadResult";
            this.txtReadResult.Size = new System.Drawing.Size(251, 44);
            this.txtReadResult.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(34, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Read Result：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_msg);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtWriteValue);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReadResult);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.Location = new System.Drawing.Point(573, 200);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1020, 234);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node Read/Write Test";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSave.Location = new System.Drawing.Point(550, 30);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 54);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save To SQL";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.Font = new System.Drawing.Font("宋体", 13F);
            this.txtWriteValue.Location = new System.Drawing.Point(156, 146);
            this.txtWriteValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtWriteValue.Multiline = true;
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(251, 44);
            this.txtWriteValue.TabIndex = 61;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnWrite.Location = new System.Drawing.Point(427, 146);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(96, 54);
            this.btnWrite.TabIndex = 60;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(34, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "Write Value：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.Location = new System.Drawing.Point(1269, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Node Type：";
            // 
            // lblNodeTypeInfo
            // 
            this.lblNodeTypeInfo.AutoSize = true;
            this.lblNodeTypeInfo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblNodeTypeInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblNodeTypeInfo.Location = new System.Drawing.Point(1375, 142);
            this.lblNodeTypeInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNodeTypeInfo.Name = "lblNodeTypeInfo";
            this.lblNodeTypeInfo.Size = new System.Drawing.Size(28, 24);
            this.lblNodeTypeInfo.TabIndex = 63;
            this.lblNodeTypeInfo.Text = "？";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_msg.Location = new System.Drawing.Point(570, 159);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 24);
            this.lbl_msg.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 834);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_nodeId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNodeTypeInfo);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnectServer);
            this.Controls.Add(this.txtServer);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BHS Opc UA Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新节点ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nodeId;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtReadResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWriteValue;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNodeTypeInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_msg;
    }
}

