namespace DeviceAdaptorDetector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGet = new System.Windows.Forms.Button();
            this.listBoxDetail = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(154, 27);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(221, 21);
            this.comboBoxDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chpice Adapter Device";
            // 
            // ButtonGet
            // 
            this.ButtonGet.Location = new System.Drawing.Point(333, 58);
            this.ButtonGet.Name = "ButtonGet";
            this.ButtonGet.Size = new System.Drawing.Size(42, 23);
            this.ButtonGet.TabIndex = 2;
            this.ButtonGet.Text = "Get";
            this.ButtonGet.UseVisualStyleBackColor = true;
            this.ButtonGet.Click += new System.EventHandler(this.ButtonGet_Click);
            // 
            // listBoxDetail
            // 
            this.listBoxDetail.FormattingEnabled = true;
            this.listBoxDetail.Location = new System.Drawing.Point(12, 92);
            this.listBoxDetail.Name = "listBoxDetail";
            this.listBoxDetail.Size = new System.Drawing.Size(363, 147);
            this.listBoxDetail.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.listBoxDetail);
            this.Controls.Add(this.ButtonGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Aplikasi Deteksi Network Adapter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonGet;
        private System.Windows.Forms.ListBox listBoxDetail;
    }
}

