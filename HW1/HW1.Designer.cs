namespace HW1
{
    partial class HW1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.G_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.R_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.B_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.G_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.R_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.B_radioButton = new System.Windows.Forms.RadioButton();
            this.G_radioButton = new System.Windows.Forms.RadioButton();
            this.R_radioButton = new System.Windows.Forms.RadioButton();
            this.All_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "開啟調色盤";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "開啟字型選項";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Gray;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(13, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 411);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_hScrollBar);
            this.groupBox1.Controls.Add(this.G_hScrollBar);
            this.groupBox1.Controls.Add(this.R_hScrollBar);
            this.groupBox1.Controls.Add(this.B_numericUpDown);
            this.groupBox1.Controls.Add(this.G_numericUpDown);
            this.groupBox1.Controls.Add(this.R_numericUpDown);
            this.groupBox1.Controls.Add(this.B_radioButton);
            this.groupBox1.Controls.Add(this.G_radioButton);
            this.groupBox1.Controls.Add(this.R_radioButton);
            this.groupBox1.Controls.Add(this.All_radioButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(110, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "背景色彩選擇";
            // 
            // B_hScrollBar
            // 
            this.B_hScrollBar.Location = new System.Drawing.Point(74, 86);
            this.B_hScrollBar.Maximum = 255;
            this.B_hScrollBar.Name = "B_hScrollBar";
            this.B_hScrollBar.Size = new System.Drawing.Size(199, 27);
            this.B_hScrollBar.TabIndex = 14;
            this.B_hScrollBar.Value = 128;
            this.B_hScrollBar.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChanged);
            // 
            // G_hScrollBar
            // 
            this.G_hScrollBar.Location = new System.Drawing.Point(74, 53);
            this.G_hScrollBar.Maximum = 255;
            this.G_hScrollBar.Name = "G_hScrollBar";
            this.G_hScrollBar.Size = new System.Drawing.Size(199, 27);
            this.G_hScrollBar.TabIndex = 13;
            this.G_hScrollBar.Value = 128;
            this.G_hScrollBar.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChanged);
            // 
            // R_hScrollBar
            // 
            this.R_hScrollBar.Location = new System.Drawing.Point(74, 20);
            this.R_hScrollBar.Maximum = 255;
            this.R_hScrollBar.Name = "R_hScrollBar";
            this.R_hScrollBar.Size = new System.Drawing.Size(199, 27);
            this.R_hScrollBar.TabIndex = 12;
            this.R_hScrollBar.Value = 128;
            this.R_hScrollBar.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChanged);
            // 
            // B_numericUpDown
            // 
            this.B_numericUpDown.Location = new System.Drawing.Point(6, 86);
            this.B_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.B_numericUpDown.Name = "B_numericUpDown";
            this.B_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.B_numericUpDown.TabIndex = 11;
            this.B_numericUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.B_numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // G_numericUpDown
            // 
            this.G_numericUpDown.Location = new System.Drawing.Point(6, 53);
            this.G_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.G_numericUpDown.Name = "G_numericUpDown";
            this.G_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.G_numericUpDown.TabIndex = 10;
            this.G_numericUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.G_numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // R_numericUpDown
            // 
            this.R_numericUpDown.Location = new System.Drawing.Point(6, 20);
            this.R_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.R_numericUpDown.Name = "R_numericUpDown";
            this.R_numericUpDown.Size = new System.Drawing.Size(65, 27);
            this.R_numericUpDown.TabIndex = 6;
            this.R_numericUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.R_numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // B_radioButton
            // 
            this.B_radioButton.AutoSize = true;
            this.B_radioButton.Location = new System.Drawing.Point(295, 86);
            this.B_radioButton.Name = "B_radioButton";
            this.B_radioButton.Size = new System.Drawing.Size(35, 20);
            this.B_radioButton.TabIndex = 9;
            this.B_radioButton.TabStop = true;
            this.B_radioButton.Text = "B";
            this.B_radioButton.UseVisualStyleBackColor = true;
            this.B_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // G_radioButton
            // 
            this.G_radioButton.AutoSize = true;
            this.G_radioButton.Location = new System.Drawing.Point(295, 53);
            this.G_radioButton.Name = "G_radioButton";
            this.G_radioButton.Size = new System.Drawing.Size(36, 20);
            this.G_radioButton.TabIndex = 8;
            this.G_radioButton.TabStop = true;
            this.G_radioButton.Text = "G";
            this.G_radioButton.UseVisualStyleBackColor = true;
            this.G_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // R_radioButton
            // 
            this.R_radioButton.AutoSize = true;
            this.R_radioButton.Location = new System.Drawing.Point(295, 20);
            this.R_radioButton.Name = "R_radioButton";
            this.R_radioButton.Size = new System.Drawing.Size(35, 20);
            this.R_radioButton.TabIndex = 7;
            this.R_radioButton.TabStop = true;
            this.R_radioButton.Text = "R";
            this.R_radioButton.UseVisualStyleBackColor = true;
            this.R_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // All_radioButton
            // 
            this.All_radioButton.AutoSize = true;
            this.All_radioButton.Location = new System.Drawing.Point(355, 20);
            this.All_radioButton.Name = "All_radioButton";
            this.All_radioButton.Size = new System.Drawing.Size(44, 20);
            this.All_radioButton.TabIndex = 6;
            this.All_radioButton.TabStop = true;
            this.All_radioButton.Text = "All";
            this.All_radioButton.UseVisualStyleBackColor = true;
            this.All_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(499, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 108);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(547, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文字選項";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "紅色",
            "黃色",
            "綠色",
            "藍色"});
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "MOD3測試題";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox3.Location = new System.Drawing.Point(272, 71);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 20);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "底線";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(272, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "斜體";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(272, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "粗體";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(6, 87);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(198, 27);
            this.numericUpDown4.TabIndex = 12;
            this.numericUpDown4.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "(,)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // HW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HW1";
            this.Text = "HW_1";
            this.Load += new System.EventHandler(this.HW1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown B_numericUpDown;
        private System.Windows.Forms.NumericUpDown G_numericUpDown;
        private System.Windows.Forms.NumericUpDown R_numericUpDown;
        private System.Windows.Forms.RadioButton B_radioButton;
        private System.Windows.Forms.RadioButton G_radioButton;
        private System.Windows.Forms.RadioButton R_radioButton;
        private System.Windows.Forms.RadioButton All_radioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.HScrollBar B_hScrollBar;
        private System.Windows.Forms.HScrollBar G_hScrollBar;
        private System.Windows.Forms.HScrollBar R_hScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

