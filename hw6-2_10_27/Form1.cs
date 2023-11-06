using System.Globalization;
using System.Windows.Forms;

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

        PictureBox[,] moniters = new PictureBox[6, 35];

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
        }

        private void SelectRingBtn_Click(object sender, EventArgs e) {
            OFD.Filter = "音樂檔案(*.mp3,*.wav)|*.wav,*.mp3|所有檔案(*.*)|*.*";
            if (OFD.ShowDialog() == DialogResult.OK) {
                FileLabel.Text = OFD.FileName;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            string s = DateTime.Now.ToString("hhmmsstt");
            for (int i = 0; i < 6; i++) {
                SetNum(i, Convert.ToInt32(s[i].ToString()));
            }
        }
    }
}