using System.Globalization;

namespace hw6_2_10_27 {
    public partial class Form1 : Form {

        class Moniter {
            static int count = 0;
            static public List<int>[] nums = new List<int>[10] {
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

            public Moniter(int x) {
                for (int i = 0; i < 35; i++) {
                    boxs[i] = new PictureBox {
                        BackColor = Color.Blue,
                        Location = new Point(168, 104),
                        Name = $"Block{++count}_{i}",
                        Size = new Size(30, 30),
                        TabIndex = 0,
                        TabStop = false
                    };
                }
            }
            PictureBox[] boxs = new PictureBox[35];
        }



        public Form1() {
            InitializeComponent();
        }
    }
}