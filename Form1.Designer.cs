namespace ProductionProject
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
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.textToEmbed = new System.Windows.Forms.TextBox();
            this.embedButton = new System.Windows.Forms.Button();
            this.embedLabel = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Caesar_btn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxStego = new System.Windows.Forms.PictureBox();
            this.decodedLabel = new System.Windows.Forms.Label();
            this.decodedText = new System.Windows.Forms.TextBox();
            this.stegoLengthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.openTextBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveStegoBtn = new System.Windows.Forms.Button();
            this.openStegoBtn = new System.Windows.Forms.Button();
            this.inputStegoLabel = new System.Windows.Forms.Label();
            this.stegobox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.routeBox = new System.Windows.Forms.TextBox();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.infoStorage = new System.Windows.Forms.Label();
            this.infoPixelDepth = new System.Windows.Forms.Label();
            this.infoRes = new System.Windows.Forms.Label();
            this.infoHeight = new System.Windows.Forms.Label();
            this.infoWidth = new System.Windows.Forms.Label();
            this.infoSize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Lsb1Button = new System.Windows.Forms.RadioButton();
            this.Lsb2Button = new System.Windows.Forms.RadioButton();
            this.Lsb3Button = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lsb4Button = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxInput.Location = new System.Drawing.Point(6, 20);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(536, 390);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInput.TabIndex = 5;
            this.pictureBoxInput.TabStop = false;
            // 
            // textToEmbed
            // 
            this.textToEmbed.BackColor = System.Drawing.Color.White;
            this.textToEmbed.Location = new System.Drawing.Point(12, 213);
            this.textToEmbed.Multiline = true;
            this.textToEmbed.Name = "textToEmbed";
            this.textToEmbed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToEmbed.Size = new System.Drawing.Size(444, 215);
            this.textToEmbed.TabIndex = 6;
            this.textToEmbed.TextChanged += new System.EventHandler(this.textToEmbed_TextChanged);
            // 
            // embedButton
            // 
            this.embedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.embedButton.Location = new System.Drawing.Point(288, 598);
            this.embedButton.Name = "embedButton";
            this.embedButton.Size = new System.Drawing.Size(81, 23);
            this.embedButton.TabIndex = 7;
            this.embedButton.Text = "Embed";
            this.embedButton.UseVisualStyleBackColor = true;
            this.embedButton.Click += new System.EventHandler(this.embedButton_Click);
            // 
            // embedLabel
            // 
            this.embedLabel.AutoSize = true;
            this.embedLabel.Location = new System.Drawing.Point(13, 197);
            this.embedLabel.Name = "embedLabel";
            this.embedLabel.Size = new System.Drawing.Size(78, 13);
            this.embedLabel.TabIndex = 8;
            this.embedLabel.Text = "Text to embed:";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(375, 598);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(81, 23);
            this.decodeButton.TabIndex = 9;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Caesar_btn
            // 
            this.Caesar_btn.AutoSize = true;
            this.Caesar_btn.Location = new System.Drawing.Point(6, 32);
            this.Caesar_btn.Name = "Caesar_btn";
            this.Caesar_btn.Size = new System.Drawing.Size(58, 17);
            this.Caesar_btn.TabIndex = 18;
            this.Caesar_btn.TabStop = true;
            this.Caesar_btn.Text = "Caesar";
            this.Caesar_btn.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Symetric";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Asymetric";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Encrypt key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Decrypt key";
            // 
            // pictureBoxStego
            // 
            this.pictureBoxStego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxStego.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxStego.Name = "pictureBoxStego";
            this.pictureBoxStego.Size = new System.Drawing.Size(536, 396);
            this.pictureBoxStego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStego.TabIndex = 25;
            this.pictureBoxStego.TabStop = false;
            // 
            // decodedLabel
            // 
            this.decodedLabel.AutoSize = true;
            this.decodedLabel.Location = new System.Drawing.Point(14, 624);
            this.decodedLabel.Name = "decodedLabel";
            this.decodedLabel.Size = new System.Drawing.Size(74, 13);
            this.decodedLabel.TabIndex = 32;
            this.decodedLabel.Text = "Decoded text:";
            // 
            // decodedText
            // 
            this.decodedText.BackColor = System.Drawing.Color.White;
            this.decodedText.Location = new System.Drawing.Point(11, 640);
            this.decodedText.Multiline = true;
            this.decodedText.Name = "decodedText";
            this.decodedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decodedText.Size = new System.Drawing.Size(445, 215);
            this.decodedText.TabIndex = 33;
            this.decodedText.TextChanged += new System.EventHandler(this.decodedText_TextChanged);
            // 
            // stegoLengthLabel
            // 
            this.stegoLengthLabel.AutoSize = true;
            this.stegoLengthLabel.Location = new System.Drawing.Point(136, 624);
            this.stegoLengthLabel.Name = "stegoLengthLabel";
            this.stegoLengthLabel.Size = new System.Drawing.Size(46, 13);
            this.stegoLengthLabel.TabIndex = 34;
            this.stegoLengthLabel.Text = "Length: ";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(279, 197);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(46, 13);
            this.lengthLabel.TabIndex = 35;
            this.lengthLabel.Text = "Length: ";
            // 
            // openTextBtn
            // 
            this.openTextBtn.Location = new System.Drawing.Point(102, 187);
            this.openTextBtn.Name = "openTextBtn";
            this.openTextBtn.Size = new System.Drawing.Size(81, 23);
            this.openTextBtn.TabIndex = 36;
            this.openTextBtn.Text = "Open txt...";
            this.openTextBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveStegoBtn);
            this.groupBox1.Controls.Add(this.openStegoBtn);
            this.groupBox1.Controls.Add(this.inputStegoLabel);
            this.groupBox1.Controls.Add(this.stegobox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.routeBox);
            this.groupBox1.Controls.Add(this.inputFileLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 165);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File:";
            // 
            // saveStegoBtn
            // 
            this.saveStegoBtn.Location = new System.Drawing.Point(182, 126);
            this.saveStegoBtn.Name = "saveStegoBtn";
            this.saveStegoBtn.Size = new System.Drawing.Size(81, 23);
            this.saveStegoBtn.TabIndex = 39;
            this.saveStegoBtn.Text = "Save...";
            this.saveStegoBtn.UseVisualStyleBackColor = true;
            this.saveStegoBtn.Click += new System.EventHandler(this.saveStegoBtn_Click_1);
            // 
            // openStegoBtn
            // 
            this.openStegoBtn.Location = new System.Drawing.Point(95, 126);
            this.openStegoBtn.Name = "openStegoBtn";
            this.openStegoBtn.Size = new System.Drawing.Size(81, 23);
            this.openStegoBtn.TabIndex = 38;
            this.openStegoBtn.Text = "Open...";
            this.openStegoBtn.UseVisualStyleBackColor = true;
            this.openStegoBtn.Click += new System.EventHandler(this.openStegoBtn_Click_1);
            // 
            // inputStegoLabel
            // 
            this.inputStegoLabel.AutoSize = true;
            this.inputStegoLabel.Location = new System.Drawing.Point(6, 84);
            this.inputStegoLabel.Name = "inputStegoLabel";
            this.inputStegoLabel.Size = new System.Drawing.Size(65, 13);
            this.inputStegoLabel.TabIndex = 37;
            this.inputStegoLabel.Text = "Stego route:";
            // 
            // stegobox
            // 
            this.stegobox.Location = new System.Drawing.Point(5, 100);
            this.stegobox.Name = "stegobox";
            this.stegobox.Size = new System.Drawing.Size(261, 20);
            this.stegobox.TabIndex = 36;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(182, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 23);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(95, 61);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(81, 23);
            this.openButton.TabIndex = 34;
            this.openButton.Text = "Open...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
            // 
            // routeBox
            // 
            this.routeBox.Location = new System.Drawing.Point(5, 35);
            this.routeBox.Name = "routeBox";
            this.routeBox.Size = new System.Drawing.Size(261, 20);
            this.routeBox.TabIndex = 33;
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(6, 19);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(66, 13);
            this.inputFileLabel.TabIndex = 32;
            this.inputFileLabel.Text = "Image route:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.infoStorage);
            this.groupBox2.Controls.Add(this.infoPixelDepth);
            this.groupBox2.Controls.Add(this.infoRes);
            this.groupBox2.Controls.Add(this.infoHeight);
            this.groupBox2.Controls.Add(this.infoWidth);
            this.groupBox2.Controls.Add(this.infoSize);
            this.groupBox2.Location = new System.Drawing.Point(296, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 165);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image file stats";
            // 
            // infoStorage
            // 
            this.infoStorage.AutoSize = true;
            this.infoStorage.Location = new System.Drawing.Point(6, 130);
            this.infoStorage.Name = "infoStorage";
            this.infoStorage.Size = new System.Drawing.Size(89, 13);
            this.infoStorage.TabIndex = 6;
            this.infoStorage.Text = "Potential storage:";
            // 
            // infoPixelDepth
            // 
            this.infoPixelDepth.AutoSize = true;
            this.infoPixelDepth.Location = new System.Drawing.Point(6, 108);
            this.infoPixelDepth.Name = "infoPixelDepth";
            this.infoPixelDepth.Size = new System.Drawing.Size(62, 13);
            this.infoPixelDepth.TabIndex = 5;
            this.infoPixelDepth.Text = "Pixel depth:";
            // 
            // infoRes
            // 
            this.infoRes.AutoSize = true;
            this.infoRes.Location = new System.Drawing.Point(6, 86);
            this.infoRes.Name = "infoRes";
            this.infoRes.Size = new System.Drawing.Size(60, 13);
            this.infoRes.TabIndex = 4;
            this.infoRes.Text = "Resolution:";
            // 
            // infoHeight
            // 
            this.infoHeight.AutoSize = true;
            this.infoHeight.Location = new System.Drawing.Point(6, 64);
            this.infoHeight.Name = "infoHeight";
            this.infoHeight.Size = new System.Drawing.Size(41, 13);
            this.infoHeight.TabIndex = 3;
            this.infoHeight.Text = "Height:";
            // 
            // infoWidth
            // 
            this.infoWidth.AutoSize = true;
            this.infoWidth.Location = new System.Drawing.Point(6, 42);
            this.infoWidth.Name = "infoWidth";
            this.infoWidth.Size = new System.Drawing.Size(38, 13);
            this.infoWidth.TabIndex = 2;
            this.infoWidth.Text = "Width:";
            // 
            // infoSize
            // 
            this.infoSize.AutoSize = true;
            this.infoSize.Location = new System.Drawing.Point(6, 20);
            this.infoSize.Name = "infoSize";
            this.infoSize.Size = new System.Drawing.Size(30, 13);
            this.infoSize.TabIndex = 1;
            this.infoSize.Text = "Size:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxInput);
            this.groupBox3.Location = new System.Drawing.Point(462, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 416);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Original image:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxStego);
            this.groupBox4.Location = new System.Drawing.Point(462, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 421);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stego image:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Caesar_btn);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(12, 434);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 187);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Encryption:";
            // 
            // Lsb1Button
            // 
            this.Lsb1Button.AutoSize = true;
            this.Lsb1Button.Location = new System.Drawing.Point(247, 493);
            this.Lsb1Button.Name = "Lsb1Button";
            this.Lsb1Button.Size = new System.Drawing.Size(54, 17);
            this.Lsb1Button.TabIndex = 25;
            this.Lsb1Button.TabStop = true;
            this.Lsb1Button.Text = "1 LSB";
            this.Lsb1Button.UseVisualStyleBackColor = true;
            // 
            // Lsb2Button
            // 
            this.Lsb2Button.AutoSize = true;
            this.Lsb2Button.Location = new System.Drawing.Point(247, 516);
            this.Lsb2Button.Name = "Lsb2Button";
            this.Lsb2Button.Size = new System.Drawing.Size(54, 17);
            this.Lsb2Button.TabIndex = 26;
            this.Lsb2Button.TabStop = true;
            this.Lsb2Button.Text = "2 LSB";
            this.Lsb2Button.UseVisualStyleBackColor = true;
            // 
            // Lsb3Button
            // 
            this.Lsb3Button.AutoSize = true;
            this.Lsb3Button.Location = new System.Drawing.Point(247, 539);
            this.Lsb3Button.Name = "Lsb3Button";
            this.Lsb3Button.Size = new System.Drawing.Size(54, 17);
            this.Lsb3Button.TabIndex = 27;
            this.Lsb3Button.TabStop = true;
            this.Lsb3Button.Text = "3 LSB";
            this.Lsb3Button.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(247, 453);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 34);
            this.textBox3.TabIndex = 41;
            this.textBox3.Text = "(Less bits = less space/higher quality.\r\nMore bits = more space/lower quality.)";
            // 
            // Lsb4Button
            // 
            this.Lsb4Button.AutoSize = true;
            this.Lsb4Button.Location = new System.Drawing.Point(247, 562);
            this.Lsb4Button.Name = "Lsb4Button";
            this.Lsb4Button.Size = new System.Drawing.Size(54, 17);
            this.Lsb4Button.TabIndex = 42;
            this.Lsb4Button.TabStop = true;
            this.Lsb4Button.Text = "4 LSB";
            this.Lsb4Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 865);
            this.Controls.Add(this.decodedText);
            this.Controls.Add(this.Lsb4Button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Lsb3Button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Lsb2Button);
            this.Controls.Add(this.Lsb1Button);
            this.Controls.Add(this.embedButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openTextBtn);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.stegoLengthLabel);
            this.Controls.Add(this.decodedLabel);
            this.Controls.Add(this.embedLabel);
            this.Controls.Add(this.textToEmbed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.TextBox textToEmbed;
        private System.Windows.Forms.Button embedButton;
        private System.Windows.Forms.Label embedLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton Caesar_btn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxStego;
        private System.Windows.Forms.Label decodedLabel;
        private System.Windows.Forms.TextBox decodedText;
        private System.Windows.Forms.Label stegoLengthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button openTextBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveStegoBtn;
        private System.Windows.Forms.Button openStegoBtn;
        private System.Windows.Forms.Label inputStegoLabel;
        private System.Windows.Forms.TextBox stegobox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox routeBox;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label infoHeight;
        private System.Windows.Forms.Label infoWidth;
        private System.Windows.Forms.Label infoSize;
        private System.Windows.Forms.Label infoPixelDepth;
        private System.Windows.Forms.Label infoRes;
        private System.Windows.Forms.Label infoStorage;
        private System.Windows.Forms.RadioButton Lsb1Button;
        private System.Windows.Forms.RadioButton Lsb2Button;
        private System.Windows.Forms.RadioButton Lsb3Button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton Lsb4Button;
    }
}

