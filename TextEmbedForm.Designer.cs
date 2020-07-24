namespace ProductionProject
{
    partial class TextEmbedForm
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
            this.textToEmbed = new System.Windows.Forms.TextBox();
            this.embedButton = new System.Windows.Forms.Button();
            this.embedLabel = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Caesar_btn = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBoxStego = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.Lsb1Button = new System.Windows.Forms.RadioButton();
            this.Lsb2Button = new System.Windows.Forms.RadioButton();
            this.Lsb3Button = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lsb4Button = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textToEmbed
            // 
            this.textToEmbed.BackColor = System.Drawing.Color.White;
            this.textToEmbed.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToEmbed.Location = new System.Drawing.Point(13, 242);
            this.textToEmbed.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textToEmbed.MaxLength = 200000;
            this.textToEmbed.Multiline = true;
            this.textToEmbed.Name = "textToEmbed";
            this.textToEmbed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToEmbed.Size = new System.Drawing.Size(444, 230);
            this.textToEmbed.TabIndex = 6;
            this.textToEmbed.TextChanged += new System.EventHandler(this.textToEmbed_TextChanged);
            // 
            // embedButton
            // 
            this.embedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.embedButton.Location = new System.Drawing.Point(375, 565);
            this.embedButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.embedButton.Name = "embedButton";
            this.embedButton.Size = new System.Drawing.Size(80, 26);
            this.embedButton.TabIndex = 7;
            this.embedButton.Text = "Embed";
            this.embedButton.UseVisualStyleBackColor = true;
            this.embedButton.Click += new System.EventHandler(this.embedButton_Click);
            // 
            // embedLabel
            // 
            this.embedLabel.AutoSize = true;
            this.embedLabel.Location = new System.Drawing.Point(17, 226);
            this.embedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.embedLabel.Name = "embedLabel";
            this.embedLabel.Size = new System.Drawing.Size(79, 14);
            this.embedLabel.TabIndex = 8;
            this.embedLabel.Text = "Text to embed:";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(375, 595);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(80, 26);
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
            this.Caesar_btn.Location = new System.Drawing.Point(9, 22);
            this.Caesar_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Caesar_btn.Name = "Caesar_btn";
            this.Caesar_btn.Size = new System.Drawing.Size(59, 18);
            this.Caesar_btn.TabIndex = 18;
            this.Caesar_btn.TabStop = true;
            this.Caesar_btn.Text = "Caesar";
            this.Caesar_btn.UseVisualStyleBackColor = true;
            this.Caesar_btn.CheckedChanged += new System.EventHandler(this.Caesar_btn_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 44);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 18);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Symetric";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 21);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Encrypt key";
            // 
            // decodedLabel
            // 
            this.decodedLabel.AutoSize = true;
            this.decodedLabel.Location = new System.Drawing.Point(21, 631);
            this.decodedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decodedLabel.Name = "decodedLabel";
            this.decodedLabel.Size = new System.Drawing.Size(74, 14);
            this.decodedLabel.TabIndex = 32;
            this.decodedLabel.Text = "Decoded text:";
            // 
            // decodedText
            // 
            this.decodedText.BackColor = System.Drawing.Color.White;
            this.decodedText.Location = new System.Drawing.Point(13, 648);
            this.decodedText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.decodedText.Multiline = true;
            this.decodedText.Name = "decodedText";
            this.decodedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decodedText.Size = new System.Drawing.Size(444, 230);
            this.decodedText.TabIndex = 33;
            this.decodedText.TextChanged += new System.EventHandler(this.decodedText_TextChanged);
            // 
            // stegoLengthLabel
            // 
            this.stegoLengthLabel.AutoSize = true;
            this.stegoLengthLabel.Location = new System.Drawing.Point(141, 631);
            this.stegoLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stegoLengthLabel.Name = "stegoLengthLabel";
            this.stegoLengthLabel.Size = new System.Drawing.Size(45, 14);
            this.stegoLengthLabel.TabIndex = 34;
            this.stegoLengthLabel.Text = "Length: ";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(189, 226);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(45, 14);
            this.lengthLabel.TabIndex = 35;
            this.lengthLabel.Text = "Length: ";
            // 
            // openTextBtn
            // 
            this.openTextBtn.Location = new System.Drawing.Point(103, 214);
            this.openTextBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.openTextBtn.Name = "openTextBtn";
            this.openTextBtn.Size = new System.Drawing.Size(80, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 178);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File:";
            // 
            // saveStegoBtn
            // 
            this.saveStegoBtn.Location = new System.Drawing.Point(184, 136);
            this.saveStegoBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.saveStegoBtn.Name = "saveStegoBtn";
            this.saveStegoBtn.Size = new System.Drawing.Size(80, 26);
            this.saveStegoBtn.TabIndex = 39;
            this.saveStegoBtn.Text = "Save...";
            this.saveStegoBtn.UseVisualStyleBackColor = true;
            this.saveStegoBtn.Click += new System.EventHandler(this.saveStegoBtn_Click_1);
            // 
            // openStegoBtn
            // 
            this.openStegoBtn.Location = new System.Drawing.Point(92, 136);
            this.openStegoBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.openStegoBtn.Name = "openStegoBtn";
            this.openStegoBtn.Size = new System.Drawing.Size(80, 26);
            this.openStegoBtn.TabIndex = 38;
            this.openStegoBtn.Text = "Open...";
            this.openStegoBtn.UseVisualStyleBackColor = true;
            this.openStegoBtn.Click += new System.EventHandler(this.openStegoBtn_Click_1);
            // 
            // inputStegoLabel
            // 
            this.inputStegoLabel.AutoSize = true;
            this.inputStegoLabel.Location = new System.Drawing.Point(6, 94);
            this.inputStegoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputStegoLabel.Name = "inputStegoLabel";
            this.inputStegoLabel.Size = new System.Drawing.Size(66, 14);
            this.inputStegoLabel.TabIndex = 37;
            this.inputStegoLabel.Text = "Stego route:";
            // 
            // stegobox
            // 
            this.stegobox.Location = new System.Drawing.Point(4, 108);
            this.stegobox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.stegobox.Name = "stegobox";
            this.stegobox.Size = new System.Drawing.Size(260, 21);
            this.stegobox.TabIndex = 36;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(184, 66);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 26);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "Save...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(92, 66);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(80, 26);
            this.openButton.TabIndex = 34;
            this.openButton.Text = "Open...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
            // 
            // routeBox
            // 
            this.routeBox.Location = new System.Drawing.Point(4, 38);
            this.routeBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.routeBox.Name = "routeBox";
            this.routeBox.Size = new System.Drawing.Size(260, 21);
            this.routeBox.TabIndex = 33;
            this.routeBox.Text = "D:\\UNI\\testFiles\\colourScale.jpg";
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(6, 17);
            this.inputFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(68, 14);
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
            this.groupBox2.Location = new System.Drawing.Point(297, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(160, 178);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image file stats";
            // 
            // infoStorage
            // 
            this.infoStorage.AutoSize = true;
            this.infoStorage.Location = new System.Drawing.Point(6, 140);
            this.infoStorage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoStorage.Name = "infoStorage";
            this.infoStorage.Size = new System.Drawing.Size(93, 14);
            this.infoStorage.TabIndex = 6;
            this.infoStorage.Text = "Potential storage:";
            // 
            // infoPixelDepth
            // 
            this.infoPixelDepth.AutoSize = true;
            this.infoPixelDepth.Location = new System.Drawing.Point(6, 115);
            this.infoPixelDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoPixelDepth.Name = "infoPixelDepth";
            this.infoPixelDepth.Size = new System.Drawing.Size(63, 14);
            this.infoPixelDepth.TabIndex = 5;
            this.infoPixelDepth.Text = "Pixel depth:";
            // 
            // infoRes
            // 
            this.infoRes.AutoSize = true;
            this.infoRes.Location = new System.Drawing.Point(6, 94);
            this.infoRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoRes.Name = "infoRes";
            this.infoRes.Size = new System.Drawing.Size(61, 14);
            this.infoRes.TabIndex = 4;
            this.infoRes.Text = "Resolution:";
            // 
            // infoHeight
            // 
            this.infoHeight.AutoSize = true;
            this.infoHeight.Location = new System.Drawing.Point(6, 69);
            this.infoHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoHeight.Name = "infoHeight";
            this.infoHeight.Size = new System.Drawing.Size(42, 14);
            this.infoHeight.TabIndex = 3;
            this.infoHeight.Text = "Height:";
            // 
            // infoWidth
            // 
            this.infoWidth.AutoSize = true;
            this.infoWidth.Location = new System.Drawing.Point(6, 45);
            this.infoWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoWidth.Name = "infoWidth";
            this.infoWidth.Size = new System.Drawing.Size(38, 14);
            this.infoWidth.TabIndex = 2;
            this.infoWidth.Text = "Width:";
            // 
            // infoSize
            // 
            this.infoSize.AutoSize = true;
            this.infoSize.Location = new System.Drawing.Point(6, 17);
            this.infoSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoSize.Name = "infoSize";
            this.infoSize.Size = new System.Drawing.Size(29, 14);
            this.infoSize.TabIndex = 1;
            this.infoSize.Text = "Size:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxInput);
            this.groupBox3.Location = new System.Drawing.Point(463, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(548, 425);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Original image:";
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxInput.Location = new System.Drawing.Point(8, 17);
            this.pictureBoxInput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(536, 397);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInput.TabIndex = 5;
            this.pictureBoxInput.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pBar1);
            this.groupBox4.Controls.Add(this.pictureBoxStego);
            this.groupBox4.Location = new System.Drawing.Point(463, 457);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox4.Size = new System.Drawing.Size(548, 421);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stego image:";
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(76, 4);
            this.pBar1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(464, 11);
            this.pBar1.TabIndex = 43;
            // 
            // pictureBoxStego
            // 
            this.pictureBoxStego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxStego.Location = new System.Drawing.Point(6, 18);
            this.pictureBoxStego.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxStego.Name = "pictureBoxStego";
            this.pictureBoxStego.Size = new System.Drawing.Size(536, 399);
            this.pictureBoxStego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStego.TabIndex = 25;
            this.pictureBoxStego.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.decryptBtn);
            this.groupBox5.Controls.Add(this.encryptBtn);
            this.groupBox5.Controls.Add(this.Caesar_btn);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(13, 480);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Size = new System.Drawing.Size(232, 143);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Encryption:";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(149, 112);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 25;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Enabled = false;
            this.encryptBtn.Location = new System.Drawing.Point(8, 112);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 24;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // Lsb1Button
            // 
            this.Lsb1Button.AutoSize = true;
            this.Lsb1Button.Location = new System.Drawing.Point(253, 539);
            this.Lsb1Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Lsb1Button.Name = "Lsb1Button";
            this.Lsb1Button.Size = new System.Drawing.Size(51, 18);
            this.Lsb1Button.TabIndex = 25;
            this.Lsb1Button.TabStop = true;
            this.Lsb1Button.Text = "1 LSB";
            this.Lsb1Button.UseVisualStyleBackColor = true;
            this.Lsb1Button.CheckedChanged += new System.EventHandler(this.Lsb1Button_CheckedChanged);
            // 
            // Lsb2Button
            // 
            this.Lsb2Button.AutoSize = true;
            this.Lsb2Button.Location = new System.Drawing.Point(253, 561);
            this.Lsb2Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Lsb2Button.Name = "Lsb2Button";
            this.Lsb2Button.Size = new System.Drawing.Size(51, 18);
            this.Lsb2Button.TabIndex = 26;
            this.Lsb2Button.TabStop = true;
            this.Lsb2Button.Text = "2 LSB";
            this.Lsb2Button.UseVisualStyleBackColor = true;
            // 
            // Lsb3Button
            // 
            this.Lsb3Button.AutoSize = true;
            this.Lsb3Button.Location = new System.Drawing.Point(253, 583);
            this.Lsb3Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Lsb3Button.Name = "Lsb3Button";
            this.Lsb3Button.Size = new System.Drawing.Size(51, 18);
            this.Lsb3Button.TabIndex = 27;
            this.Lsb3Button.TabStop = true;
            this.Lsb3Button.Text = "3 LSB";
            this.Lsb3Button.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(253, 497);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 38);
            this.textBox3.TabIndex = 41;
            this.textBox3.Text = "(Less bits = less space/higher quality.\r\nMore bits = more space/lower quality.)";
            // 
            // Lsb4Button
            // 
            this.Lsb4Button.AutoSize = true;
            this.Lsb4Button.Location = new System.Drawing.Point(253, 605);
            this.Lsb4Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Lsb4Button.Name = "Lsb4Button";
            this.Lsb4Button.Size = new System.Drawing.Size(51, 18);
            this.Lsb4Button.TabIndex = 42;
            this.Lsb4Button.TabStop = true;
            this.Lsb4Button.Text = "4 LSB";
            this.Lsb4Button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 23);
            this.panel1.TabIndex = 43;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Textual steganography";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.BackgroundImage = global::ProductionProject.Properties.Resources.iconfinder_exit_delete_remove_close_x_2931151;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(1004, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextEmbedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 891);
            this.Controls.Add(this.panel1);
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
            this.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "TextEmbedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

