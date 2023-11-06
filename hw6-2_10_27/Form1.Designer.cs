namespace hw6_2_10_27 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            Box = new TextBox();
            TimePicker = new DateTimePicker();
            SettingLabel = new Label();
            StartBtn = new Button();
            FileLabel = new Label();
            SelectRingBtn = new Button();
            SFD = new SaveFileDialog();
            OFD = new OpenFileDialog();
            NoonLabel = new Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Box
            // 
            Box.Location = new Point(1182, 12);
            Box.Multiline = true;
            Box.Name = "Box";
            Box.ReadOnly = true;
            Box.ScrollBars = ScrollBars.Vertical;
            Box.Size = new Size(276, 337);
            Box.TabIndex = 57;
            Box.WordWrap = false;
            // 
            // TimePicker
            // 
            TimePicker.CustomFormat = "tt hh:mm";
            TimePicker.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.Location = new Point(908, 298);
            TimePicker.Name = "TimePicker";
            TimePicker.ShowUpDown = true;
            TimePicker.Size = new Size(120, 24);
            TimePicker.TabIndex = 58;
            // 
            // SettingLabel
            // 
            SettingLabel.AutoSize = true;
            SettingLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingLabel.Location = new Point(795, 300);
            SettingLabel.Name = "SettingLabel";
            SettingLabel.Size = new Size(105, 20);
            SettingLabel.TabIndex = 60;
            SettingLabel.Text = "設定鬧鐘時間";
            // 
            // StartBtn
            // 
            StartBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(1039, 297);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(75, 26);
            StartBtn.TabIndex = 61;
            StartBtn.Text = "啟動";
            StartBtn.UseVisualStyleBackColor = true;
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileLabel.Location = new Point(149, 300);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(0, 20);
            FileLabel.TabIndex = 62;
            // 
            // SelectRingBtn
            // 
            SelectRingBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SelectRingBtn.Location = new Point(50, 296);
            SelectRingBtn.Name = "SelectRingBtn";
            SelectRingBtn.Size = new Size(84, 26);
            SelectRingBtn.TabIndex = 63;
            SelectRingBtn.Text = "選擇鬧鈴";
            SelectRingBtn.UseVisualStyleBackColor = true;
            SelectRingBtn.Click += SelectRingBtn_Click;
            // 
            // NoonLabel
            // 
            NoonLabel.AutoSize = true;
            NoonLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NoonLabel.Location = new Point(1137, 185);
            NoonLabel.Name = "NoonLabel";
            NoonLabel.Size = new Size(42, 70);
            NoonLabel.TabIndex = 64;
            NoonLabel.Text = "上\r\n午";
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 200;
            Timer1.Tick += Timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 361);
            Controls.Add(NoonLabel);
            Controls.Add(SelectRingBtn);
            Controls.Add(FileLabel);
            Controls.Add(StartBtn);
            Controls.Add(SettingLabel);
            Controls.Add(TimePicker);
            Controls.Add(Box);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Box;
        private DateTimePicker TimePicker;
        private Label SettingLabel;
        private Button StartBtn;
        private Label FileLabel;
        private Button SelectRingBtn;
        private SaveFileDialog SFD;
        private OpenFileDialog OFD;
        private Label NoonLabel;
        private System.Windows.Forms.Timer Timer1;
    }
}