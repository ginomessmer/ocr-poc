namespace OcrPoc
{
    partial class OcrForm
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
            this.imgInput = new System.Windows.Forms.PictureBox();
            this.cmdSelectImage = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTessdataDir = new System.Windows.Forms.TextBox();
            this.cmdBrowseTessdataDir = new System.Windows.Forms.Button();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgInput
            // 
            this.imgInput.Location = new System.Drawing.Point(6, 19);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(237, 237);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgInput.TabIndex = 0;
            this.imgInput.TabStop = false;
            // 
            // cmdSelectImage
            // 
            this.cmdSelectImage.Location = new System.Drawing.Point(6, 262);
            this.cmdSelectImage.Name = "cmdSelectImage";
            this.cmdSelectImage.Size = new System.Drawing.Size(467, 23);
            this.cmdSelectImage.TabIndex = 1;
            this.cmdSelectImage.Text = "Select and scan image";
            this.cmdSelectImage.UseVisualStyleBackColor = true;
            this.cmdSelectImage.Click += new System.EventHandler(this.cmdSelectImage_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(249, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(224, 237);
            this.txtOutput.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSelectImage);
            this.groupBox1.Controls.Add(this.imgInput);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLanguage);
            this.groupBox2.Controls.Add(this.txtTessdataDir);
            this.groupBox2.Controls.Add(this.cmdBrowseTessdataDir);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config";
            // 
            // txtTessdataDir
            // 
            this.txtTessdataDir.Location = new System.Drawing.Point(6, 19);
            this.txtTessdataDir.Name = "txtTessdataDir";
            this.txtTessdataDir.ReadOnly = true;
            this.txtTessdataDir.Size = new System.Drawing.Size(467, 20);
            this.txtTessdataDir.TabIndex = 2;
            // 
            // cmdBrowseTessdataDir
            // 
            this.cmdBrowseTessdataDir.Location = new System.Drawing.Point(310, 45);
            this.cmdBrowseTessdataDir.Name = "cmdBrowseTessdataDir";
            this.cmdBrowseTessdataDir.Size = new System.Drawing.Size(163, 23);
            this.cmdBrowseTessdataDir.TabIndex = 1;
            this.cmdBrowseTessdataDir.Text = "Browse *.traineddata file";
            this.cmdBrowseTessdataDir.UseVisualStyleBackColor = true;
            this.cmdBrowseTessdataDir.Click += new System.EventHandler(this.cmdBrowseTessdataDir_Click);
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(89, 47);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(215, 20);
            this.txtLanguage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OCR language";
            // 
            // OcrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OcrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR BBY";
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgInput;
        private System.Windows.Forms.Button cmdSelectImage;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdBrowseTessdataDir;
        private System.Windows.Forms.TextBox txtTessdataDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLanguage;
    }
}