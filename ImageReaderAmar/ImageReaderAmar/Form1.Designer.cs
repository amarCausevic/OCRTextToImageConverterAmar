namespace ImageReaderAmar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.localPathToImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.txtBoxTextFromIamge = new System.Windows.Forms.TextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.langComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ocrPaginationComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipPagination = new System.Windows.Forms.ToolTip(this.components);
            this.localPathToImageDPI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseBtnResoltion = new System.Windows.Forms.Button();
            this.convertToBMPBtn = new System.Windows.Forms.Button();
            this.resolutionX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resolutionY = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.clearResButton = new System.Windows.Forms.Button();
            this.clearConvertButton = new System.Windows.Forms.Button();
            this.copyTextButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // localPathToImage
            // 
            this.localPathToImage.Location = new System.Drawing.Point(12, 251);
            this.localPathToImage.Name = "localPathToImage";
            this.localPathToImage.Size = new System.Drawing.Size(362, 20);
            this.localPathToImage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(380, 251);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 20);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // txtBoxTextFromIamge
            // 
            this.txtBoxTextFromIamge.Location = new System.Drawing.Point(12, 342);
            this.txtBoxTextFromIamge.Multiline = true;
            this.txtBoxTextFromIamge.Name = "txtBoxTextFromIamge";
            this.txtBoxTextFromIamge.ReadOnly = true;
            this.txtBoxTextFromIamge.Size = new System.Drawing.Size(769, 335);
            this.txtBoxTextFromIamge.TabIndex = 3;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(549, 250);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(224, 59);
            this.readBtn.TabIndex = 4;
            this.readBtn.Text = "READ";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // langComboBox
            // 
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.Location = new System.Drawing.Point(12, 315);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(121, 21);
            this.langComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Language Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "OCR Pagination Mode";
            // 
            // ocrPaginationComboBox
            // 
            this.ocrPaginationComboBox.FormattingEnabled = true;
            this.ocrPaginationComboBox.Location = new System.Drawing.Point(153, 315);
            this.ocrPaginationComboBox.Name = "ocrPaginationComboBox";
            this.ocrPaginationComboBox.Size = new System.Drawing.Size(147, 21);
            this.ocrPaginationComboBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImageReaderAmar.Properties.Resources.written_conversation_speech_bubble_with_letter_i_inside_of_information_for_interface;
            this.pictureBox1.InitialImage = global::ImageReaderAmar.Properties.Resources.written_conversation_speech_bubble_with_letter_i_inside_of_information_for_interface;
            this.pictureBox1.Location = new System.Drawing.Point(268, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // localPathToImageDPI
            // 
            this.localPathToImageDPI.Location = new System.Drawing.Point(12, 93);
            this.localPathToImageDPI.Name = "localPathToImageDPI";
            this.localPathToImageDPI.Size = new System.Drawing.Size(362, 20);
            this.localPathToImageDPI.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image with low DPI";
            // 
            // browseBtnResoltion
            // 
            this.browseBtnResoltion.Location = new System.Drawing.Point(380, 92);
            this.browseBtnResoltion.Name = "browseBtnResoltion";
            this.browseBtnResoltion.Size = new System.Drawing.Size(75, 20);
            this.browseBtnResoltion.TabIndex = 12;
            this.browseBtnResoltion.Text = "Browse";
            this.browseBtnResoltion.UseVisualStyleBackColor = true;
            this.browseBtnResoltion.Click += new System.EventHandler(this.browseBtnResoltion_Click);
            // 
            // convertToBMPBtn
            // 
            this.convertToBMPBtn.Location = new System.Drawing.Point(549, 92);
            this.convertToBMPBtn.Name = "convertToBMPBtn";
            this.convertToBMPBtn.Size = new System.Drawing.Size(224, 59);
            this.convertToBMPBtn.TabIndex = 13;
            this.convertToBMPBtn.Text = "CONVERT";
            this.convertToBMPBtn.UseVisualStyleBackColor = true;
            this.convertToBMPBtn.Click += new System.EventHandler(this.convertToBMPBtn_Click);
            // 
            // resolutionX
            // 
            this.resolutionX.Location = new System.Drawing.Point(12, 150);
            this.resolutionX.Name = "resolutionX";
            this.resolutionX.Size = new System.Drawing.Size(67, 20);
            this.resolutionX.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Resolution X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Resolution Y";
            // 
            // resolutionY
            // 
            this.resolutionY.Location = new System.Drawing.Point(105, 150);
            this.resolutionY.Name = "resolutionY";
            this.resolutionY.Size = new System.Drawing.Size(67, 20);
            this.resolutionY.TabIndex = 18;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(288, 150);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(67, 20);
            this.heightInput.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(195, 150);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(67, 20);
            this.widthInput.TabIndex = 19;
            // 
            // clearResButton
            // 
            this.clearResButton.Location = new System.Drawing.Point(380, 150);
            this.clearResButton.Name = "clearResButton";
            this.clearResButton.Size = new System.Drawing.Size(75, 20);
            this.clearResButton.TabIndex = 23;
            this.clearResButton.Text = "Clear";
            this.clearResButton.UseVisualStyleBackColor = true;
            this.clearResButton.Click += new System.EventHandler(this.clearResButton_Click);
            // 
            // clearConvertButton
            // 
            this.clearConvertButton.Location = new System.Drawing.Point(333, 315);
            this.clearConvertButton.Name = "clearConvertButton";
            this.clearConvertButton.Size = new System.Drawing.Size(75, 20);
            this.clearConvertButton.TabIndex = 24;
            this.clearConvertButton.Text = "Clear";
            this.clearConvertButton.UseVisualStyleBackColor = true;
            this.clearConvertButton.Click += new System.EventHandler(this.clearConvertButton_Click);
            // 
            // copyTextButton
            // 
            this.copyTextButton.Location = new System.Drawing.Point(423, 315);
            this.copyTextButton.Name = "copyTextButton";
            this.copyTextButton.Size = new System.Drawing.Size(75, 20);
            this.copyTextButton.TabIndex = 25;
            this.copyTextButton.Text = "Copy";
            this.copyTextButton.UseVisualStyleBackColor = true;
            this.copyTextButton.Click += new System.EventHandler(this.copyTextButton_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 35);
            this.label9.TabIndex = 26;
            this.label9.Text = "Image Scaler";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 35);
            this.label10.TabIndex = 27;
            this.label10.Text = "Image To Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 689);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.copyTextButton);
            this.Controls.Add(this.clearConvertButton);
            this.Controls.Add(this.clearResButton);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.resolutionY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resolutionX);
            this.Controls.Add(this.convertToBMPBtn);
            this.Controls.Add(this.browseBtnResoltion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.localPathToImageDPI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ocrPaginationComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.langComboBox);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.txtBoxTextFromIamge);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localPathToImage);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OCR -Image to Text Converter (Amar)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox localPathToImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox txtBoxTextFromIamge;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.ComboBox langComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ocrPaginationComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTipPagination;
        private System.Windows.Forms.TextBox localPathToImageDPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseBtnResoltion;
        private System.Windows.Forms.Button convertToBMPBtn;
        private System.Windows.Forms.TextBox resolutionX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resolutionY;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Button clearResButton;
        private System.Windows.Forms.Button clearConvertButton;
        private System.Windows.Forms.Button copyTextButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

