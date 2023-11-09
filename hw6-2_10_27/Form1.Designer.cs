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
            ExportBtn = new Button();
            MarkLabel1 = new Label();
            MarkLabel2 = new Label();
            SuspendLayout();
            // 
            // Box
            // 
            Box.Location = new Point(1182, 12);
            Box.Multiline = true;
            Box.Name = "Box";
            Box.ReadOnly = true;
            Box.ScrollBars = ScrollBars.Vertical;
            Box.Size = new Size(276, 306);
            Box.TabIndex = 1;
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
            TimePicker.TabIndex = 2;
            // 
            // SettingLabel
            // 
            SettingLabel.AutoSize = true;
            SettingLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingLabel.Location = new Point(795, 300);
            SettingLabel.Name = "SettingLabel";
            SettingLabel.Size = new Size(105, 20);
            SettingLabel.TabIndex = 3;
            SettingLabel.Text = "設定鬧鐘時間";
            // 
            // StartBtn
            // 
            StartBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(1039, 297);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(75, 26);
            StartBtn.TabIndex = 4;
            StartBtn.Text = "啟動";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileLabel.Location = new Point(149, 300);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(0, 20);
            FileLabel.TabIndex = 5;
            // 
            // SelectRingBtn
            // 
            SelectRingBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SelectRingBtn.Location = new Point(50, 296);
            SelectRingBtn.Name = "SelectRingBtn";
            SelectRingBtn.Size = new Size(84, 26);
            SelectRingBtn.TabIndex = 6;
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
            NoonLabel.Size = new Size(0, 35);
            NoonLabel.TabIndex = 7;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 200;
            Timer1.Tick += Timer1_Tick;
            // 
            // ExportBtn
            // 
            ExportBtn.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ExportBtn.Location = new Point(1182, 324);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(90, 25);
            ExportBtn.TabIndex = 8;
            ExportBtn.Text = "匯出記錄檔";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // MarkLabel1
            // 
            MarkLabel1.Font = new Font("Goudy Stout", 50F, FontStyle.Bold, GraphicsUnit.Point);
            MarkLabel1.Location = new Point(370, 45);
            MarkLabel1.Name = "MarkLabel1";
            MarkLabel1.Size = new Size(68, 165);
            MarkLabel1.TabIndex = 9;
            MarkLabel1.Text = ".\r\n.";
            MarkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MarkLabel2
            // 
            MarkLabel2.Font = new Font("Goudy Stout", 50F, FontStyle.Bold, GraphicsUnit.Point);
            MarkLabel2.Location = new Point(740, 45);
            MarkLabel2.Name = "MarkLabel2";
            MarkLabel2.Size = new Size(68, 165);
            MarkLabel2.TabIndex = 9;
            MarkLabel2.Text = ".\r\n.";
            MarkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 361);
            Controls.Add(MarkLabel2);
            Controls.Add(MarkLabel1);
            Controls.Add(ExportBtn);
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
        private Button ExportBtn;
        private Label MarkLabel1;
        private Label MarkLabel2;
    }
}