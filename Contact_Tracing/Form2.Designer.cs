namespace Contact_Tracing
{
    partial class FormQRCode
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
            this.labelCam = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.picturBoxCamera = new System.Windows.Forms.PictureBox();
            this.textBoxIdentification = new System.Windows.Forms.TextBox();
            this.labelIdentification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCam
            // 
            this.labelCam.AutoSize = true;
            this.labelCam.Location = new System.Drawing.Point(48, 38);
            this.labelCam.Name = "labelCam";
            this.labelCam.Size = new System.Drawing.Size(48, 15);
            this.labelCam.TabIndex = 0;
            this.labelCam.Text = "Camera";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(352, 34);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(102, 34);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(231, 23);
            this.comboBoxDevice.TabIndex = 2;
            // 
            // picturBoxCamera
            // 
            this.picturBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturBoxCamera.Location = new System.Drawing.Point(36, 71);
            this.picturBoxCamera.Name = "picturBoxCamera";
            this.picturBoxCamera.Size = new System.Drawing.Size(401, 357);
            this.picturBoxCamera.TabIndex = 3;
            this.picturBoxCamera.TabStop = false;
            // 
            // textBoxIdentification
            // 
            this.textBoxIdentification.Location = new System.Drawing.Point(464, 71);
            this.textBoxIdentification.Multiline = true;
            this.textBoxIdentification.Name = "textBoxIdentification";
            this.textBoxIdentification.Size = new System.Drawing.Size(294, 357);
            this.textBoxIdentification.TabIndex = 4;
            // 
            // labelIdentification
            // 
            this.labelIdentification.AutoSize = true;
            this.labelIdentification.Location = new System.Drawing.Point(464, 42);
            this.labelIdentification.Name = "labelIdentification";
            this.labelIdentification.Size = new System.Drawing.Size(77, 15);
            this.labelIdentification.TabIndex = 5;
            this.labelIdentification.Text = "Identification";
            // 
            // FormQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 479);
            this.Controls.Add(this.labelIdentification);
            this.Controls.Add(this.textBoxIdentification);
            this.Controls.Add(this.picturBoxCamera);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelCam);
            this.Name = "FormQRCode";
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQRCode_FormClosing);
            this.Load += new System.EventHandler(this.FormQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCam;
        private Button buttonStart;
        private ComboBox comboBoxDevice;
        private PictureBox picturBoxCamera;
        private TextBox textBoxIdentification;
        private Label labelIdentification;
    }
}