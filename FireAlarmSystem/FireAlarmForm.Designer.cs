namespace FireAlarmSystem
{
    partial class FireAlarmForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_DeviceKey = new System.Windows.Forms.Label();
            this.lb_DeviceName = new System.Windows.Forms.Label();
            this.lb_ProductId = new System.Windows.Forms.Label();
            this.tb_DeviceKey = new System.Windows.Forms.TextBox();
            this.tb_DeviceName = new System.Windows.Forms.TextBox();
            this.tb_ProductId = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_Smoke = new System.Windows.Forms.TextBox();
            this.lb_Smoke = new System.Windows.Forms.Label();
            this.bt_UploadProperty = new System.Windows.Forms.Button();
            this.lb_Status = new System.Windows.Forms.Label();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_AiSecret = new System.Windows.Forms.Label();
            this.lb_AiKey = new System.Windows.Forms.Label();
            this.tb_AiSecret = new System.Windows.Forms.TextBox();
            this.tb_AiKey = new System.Windows.Forms.TextBox();
            this.bt_FireDetect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_DeviceKey);
            this.groupBox1.Controls.Add(this.lb_DeviceName);
            this.groupBox1.Controls.Add(this.lb_ProductId);
            this.groupBox1.Controls.Add(this.tb_DeviceKey);
            this.groupBox1.Controls.Add(this.tb_DeviceName);
            this.groupBox1.Controls.Add(this.tb_ProductId);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(684, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OneNET-Studio参数";
            // 
            // lb_DeviceKey
            // 
            this.lb_DeviceKey.AutoSize = true;
            this.lb_DeviceKey.Location = new System.Drawing.Point(46, 152);
            this.lb_DeviceKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DeviceKey.Name = "lb_DeviceKey";
            this.lb_DeviceKey.Size = new System.Drawing.Size(85, 21);
            this.lb_DeviceKey.TabIndex = 2;
            this.lb_DeviceKey.Text = "设备KEY";
            // 
            // lb_DeviceName
            // 
            this.lb_DeviceName.AutoSize = true;
            this.lb_DeviceName.Location = new System.Drawing.Point(37, 100);
            this.lb_DeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DeviceName.Name = "lb_DeviceName";
            this.lb_DeviceName.Size = new System.Drawing.Size(94, 21);
            this.lb_DeviceName.TabIndex = 2;
            this.lb_DeviceName.Text = "设备名称";
            // 
            // lb_ProductId
            // 
            this.lb_ProductId.AutoSize = true;
            this.lb_ProductId.Location = new System.Drawing.Point(57, 46);
            this.lb_ProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ProductId.Name = "lb_ProductId";
            this.lb_ProductId.Size = new System.Drawing.Size(74, 21);
            this.lb_ProductId.TabIndex = 1;
            this.lb_ProductId.Text = "产品ID";
            // 
            // tb_DeviceKey
            // 
            this.tb_DeviceKey.Location = new System.Drawing.Point(147, 147);
            this.tb_DeviceKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_DeviceKey.Multiline = true;
            this.tb_DeviceKey.Name = "tb_DeviceKey";
            this.tb_DeviceKey.Size = new System.Drawing.Size(508, 30);
            this.tb_DeviceKey.TabIndex = 0;
            // 
            // tb_DeviceName
            // 
            this.tb_DeviceName.Location = new System.Drawing.Point(147, 94);
            this.tb_DeviceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_DeviceName.Multiline = true;
            this.tb_DeviceName.Name = "tb_DeviceName";
            this.tb_DeviceName.Size = new System.Drawing.Size(508, 30);
            this.tb_DeviceName.TabIndex = 0;
            // 
            // tb_ProductId
            // 
            this.tb_ProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ProductId.Location = new System.Drawing.Point(147, 40);
            this.tb_ProductId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ProductId.Multiline = true;
            this.tb_ProductId.Name = "tb_ProductId";
            this.tb_ProductId.Size = new System.Drawing.Size(508, 32);
            this.tb_ProductId.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_Smoke);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Smoke);
            this.splitContainer1.Panel1.Controls.Add(this.bt_UploadProperty);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Status);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Connect);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.bt_FireDetect);
            this.splitContainer1.Size = new System.Drawing.Size(713, 709);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 1;
            // 
            // tb_Smoke
            // 
            this.tb_Smoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Smoke.Location = new System.Drawing.Point(136, 327);
            this.tb_Smoke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Smoke.MaxLength = 4;
            this.tb_Smoke.Multiline = true;
            this.tb_Smoke.Name = "tb_Smoke";
            this.tb_Smoke.Size = new System.Drawing.Size(391, 32);
            this.tb_Smoke.TabIndex = 5;
            // 
            // lb_Smoke
            // 
            this.lb_Smoke.AutoSize = true;
            this.lb_Smoke.Location = new System.Drawing.Point(28, 332);
            this.lb_Smoke.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Smoke.Name = "lb_Smoke";
            this.lb_Smoke.Size = new System.Drawing.Size(94, 21);
            this.lb_Smoke.TabIndex = 4;
            this.lb_Smoke.Text = "烟雾浓度";
            // 
            // bt_UploadProperty
            // 
            this.bt_UploadProperty.Location = new System.Drawing.Point(535, 322);
            this.bt_UploadProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_UploadProperty.Name = "bt_UploadProperty";
            this.bt_UploadProperty.Size = new System.Drawing.Size(136, 44);
            this.bt_UploadProperty.TabIndex = 3;
            this.bt_UploadProperty.Text = "上传属性";
            this.bt_UploadProperty.UseVisualStyleBackColor = true;
            this.bt_UploadProperty.Click += new System.EventHandler(this.bt_UploadProperty_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(425, 270);
            this.lb_Status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(73, 21);
            this.lb_Status.TabIndex = 2;
            this.lb_Status.Text = "未连接";
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(534, 261);
            this.bt_Connect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(138, 40);
            this.bt_Connect.TabIndex = 1;
            this.bt_Connect.Text = "打开连接";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_AiSecret);
            this.groupBox2.Controls.Add(this.lb_AiKey);
            this.groupBox2.Controls.Add(this.tb_AiSecret);
            this.groupBox2.Controls.Add(this.tb_AiKey);
            this.groupBox2.Location = new System.Drawing.Point(13, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(684, 156);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AI平台参数";
            // 
            // lb_AiSecret
            // 
            this.lb_AiSecret.AutoSize = true;
            this.lb_AiSecret.Location = new System.Drawing.Point(13, 100);
            this.lb_AiSecret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AiSecret.Name = "lb_AiSecret";
            this.lb_AiSecret.Size = new System.Drawing.Size(120, 21);
            this.lb_AiSecret.TabIndex = 2;
            this.lb_AiSecret.Text = "Secret Key";
            // 
            // lb_AiKey
            // 
            this.lb_AiKey.AutoSize = true;
            this.lb_AiKey.Location = new System.Drawing.Point(57, 46);
            this.lb_AiKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AiKey.Name = "lb_AiKey";
            this.lb_AiKey.Size = new System.Drawing.Size(76, 21);
            this.lb_AiKey.TabIndex = 1;
            this.lb_AiKey.Text = "AI Key";
            // 
            // tb_AiSecret
            // 
            this.tb_AiSecret.Location = new System.Drawing.Point(147, 94);
            this.tb_AiSecret.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_AiSecret.Multiline = true;
            this.tb_AiSecret.Name = "tb_AiSecret";
            this.tb_AiSecret.Size = new System.Drawing.Size(508, 30);
            this.tb_AiSecret.TabIndex = 0;
            // 
            // tb_AiKey
            // 
            this.tb_AiKey.Location = new System.Drawing.Point(147, 40);
            this.tb_AiKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_AiKey.Multiline = true;
            this.tb_AiKey.Name = "tb_AiKey";
            this.tb_AiKey.Size = new System.Drawing.Size(508, 30);
            this.tb_AiKey.TabIndex = 0;
            // 
            // bt_FireDetect
            // 
            this.bt_FireDetect.Location = new System.Drawing.Point(227, 215);
            this.bt_FireDetect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_FireDetect.Name = "bt_FireDetect";
            this.bt_FireDetect.Size = new System.Drawing.Size(216, 79);
            this.bt_FireDetect.TabIndex = 0;
            this.bt_FireDetect.Text = "上传文件至AI平台进行火情检测";
            this.bt_FireDetect.UseVisualStyleBackColor = true;
            this.bt_FireDetect.Click += new System.EventHandler(this.bt_FireDetect_Click);
            // 
            // FireAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 709);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FireAlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "森林火灾险情检测";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lb_DeviceKey;
        private System.Windows.Forms.Label lb_DeviceName;
        private System.Windows.Forms.Label lb_ProductId;
        private System.Windows.Forms.TextBox tb_DeviceKey;
        private System.Windows.Forms.TextBox tb_DeviceName;
        private System.Windows.Forms.TextBox tb_ProductId;
        private System.Windows.Forms.Button bt_FireDetect;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.TextBox tb_Smoke;
        private System.Windows.Forms.Label lb_Smoke;
        private System.Windows.Forms.Button bt_UploadProperty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_AiSecret;
        private System.Windows.Forms.Label lb_AiKey;
        private System.Windows.Forms.TextBox tb_AiSecret;
        private System.Windows.Forms.TextBox tb_AiKey;
    }
}

