using System.Globalization;
using System.Windows.Forms;
using System.Media;
using System.Net.Mime;

namespace hw6_2_10_27 {
	public partial class Form1 : Form {

		List<int>[] nums = new List<int>[10] {
			new List<int> { 1, 2, 3, 5, 9, 10, 14, 20, 24, 25, 29, 31, 32, 33 },
			new List<int> { 9, 14, 24, 29 },
			new List<int> { 1, 2, 3, 9, 14, 16, 17, 18, 20, 25, 31, 32, 33 },
			new List<int> { 1, 2, 3, 9, 14, 16, 17, 18, 24, 29, 31, 32, 33 },
			new List<int> { 5, 9, 10, 14, 16, 17, 18, 24, 29 },
			new List<int> { 1, 2, 3, 5, 10, 16, 17, 18, 24, 29, 31, 32, 33 },
			new List<int> { 1, 2, 3, 5, 10, 16, 17, 18, 20, 24, 25, 29, 31, 32, 33 },
			new List<int> { 1, 2, 3, 9, 14, 24, 29 },
			new List<int> { 1, 2, 3, 5, 9, 10, 14, 16, 17, 18, 20, 24, 25, 29, 31, 32, 33 },
			new List<int> { 1, 2, 3, 5, 9, 10, 14, 16, 17, 18, 24, 29, 31, 32, 33 }
		};

		SoundPlayer player = new();
		WMPLib.WindowsMediaPlayer wplayer = new();
		bool isMP3 = false;
		PictureBox[,] moniters = new PictureBox[6, 35];
		TimeOnly alarmTime = new();
		bool alarmOn = false;
		bool alarmStarted = false;

		void Log(string s) {
			Box.AppendText(DateTime.Now.ToString("G") + ": " + s + "\r\n");
		}

		void SetNum(int index, int num) {
			for (int i = 0; i < 35; i++)
				moniters[index, i].BackColor = Color.White;
			foreach (int i in nums[num])
				moniters[index, i].BackColor = Color.Blue;
		}

		public Form1() {
			InitializeComponent();
			for (int i = 0; i < 6; i++) {
				for (int j = 0; j < 35; j++) {
					moniters[i, j] = new PictureBox {
						BorderStyle = BorderStyle.FixedSingle,
						BackColor = Color.White,
						Location = new Point(50 + 185 * i + 30 * (j % 5), 45 + 30 * (j / 5)),
						Name = $"Block{i}_{j}",
						Size = new Size(30, 30),
						TabIndex = 0,
						TabStop = false
					};
					Controls.Add(moniters[i, j]);
				}
			}
			MarkLabel1.SendToBack();
			MarkLabel2.SendToBack();
		}

		private void SelectRingBtn_Click(object sender, EventArgs e) {
			//OFD.InitialDirectory = Application.StartupPath;
			OFD.Title = "選擇鬧鈴";
			OFD.Filter = "音樂檔案(*.mp3;*.wav)|*.wav;*.mp3|所有檔案(*.*)|*.*";
			if (OFD.ShowDialog() == DialogResult.OK) {
				FileLabel.Text = OFD.FileName;
				if (OFD.FileName.EndsWith(".mp3")) {
					isMP3 = true;
					wplayer.URL = OFD.FileName;
					wplayer.controls.stop();
				} else {
					isMP3 = false;
					player.SoundLocation = OFD.FileName;
				}
				Log("已設定鬧鈴");
			}
		}

		private void StartBtn_Click(object sender, EventArgs e) {
			if (!alarmOn) {
				// check if alarm music is selected
				if (FileLabel.Text == "") {
					Log("錯誤訊息!");
					MessageBox.Show("請先設定鬧鈴音樂", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				// set alarmTime from TimePicker
				alarmTime = new TimeOnly(TimePicker.Value.Hour, TimePicker.Value.Minute);
				alarmOn = true;
				StartBtn.Text = "停止";
				Log("已設定鬧鐘");
			} else {
				alarmOn = false;
				alarmStarted = false;
				StartBtn.Text = "啟動";
				if (isMP3) wplayer.controls.stop();
				else player.Stop();
				Log("已關閉鬧鐘");
			}
		}

		private void Timer1_Tick(object sender, EventArgs e) {
			string s = DateTime.Now.ToString("hhmmss");
			for (int i = 0; i < 6; i++) {
				SetNum(i, Convert.ToInt32(s[i].ToString()));
			}
			NoonLabel.Text = DateTime.Now.ToString("tt").Insert(1, "\n");

			if (alarmOn && !alarmStarted && alarmTime == new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute)) {
				if (isMP3) {
					wplayer.settings.setMode("loop", true);
					wplayer.controls.play();
				} else player.PlayLooping();
				alarmStarted = true;
				MessageBox.Show("時間到!\n該起床囉~", "鬧鈴", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ExportBtn_Click(object sender, EventArgs e) {
			//SFD.InitialDirectory = Application.StartupPath;
			SFD.Title = "匯出記錄檔";
			SFD.Filter = "文字檔案(*.txt)|*.txt";
			if (SFD.ShowDialog() == DialogResult.OK) {
				StreamWriter sw = new(SFD.FileName);
				sw.Write(Box.Text);
				sw.Close();
				Log("已匯出記錄檔");
			}
		}
	}
}