using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Demo
{
    public partial class Min2Form1 : Form
    {
        private int tag = 5; // Khoảng cách giữa các ô
        private Random rand = new Random();
        private int score = 0;
        private int highScore = 0;
        private Label[,] cardLabel = new Label[4, 4];
        int[,] cards = new int[4, 4];
        private Timer gameTimer;
        private int timeLeft = 120; // 2 phút (120 giây)

        public Min2Form1()
        {
            InitializeComponent();

            this.Load += Min2Form1_Load;
            this.Paint += Min2Form1_Paint;
            this.KeyDown += Min2Form1_KeyDown;
            this.KeyPreview = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Icon = new Icon("2048.ico");

            this.Text = "2048";
        }

        private void Min2Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo label
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cardLabel[i, j] = new Label
                    {
                        Location = new Point(tag + i * (100 + tag), tag + j * (100 + tag)),
                        Size = new Size(100, 100),
                        TabIndex = i * 4 + j,
                        Name = $"lb{i}{j}",
                        BackColor = Color.FromName("ActiveBorder"),
                        Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    this.Controls.Add(cardLabel[i, j]);
                }
            }

            // Tải điểm cao
            LoadHighScore();
            lbHighScore.Text = highScore.ToString();

            // Khởi tạo game
            initCards();
            Reset.Click += Reset_Click;
            ExitToMenu.Click += ExitToMenu_Click;

            // Thiết lập bộ đếm thời gian
            gameTimer = new Timer();
            gameTimer.Interval = 1000; // Mỗi giây
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lbTimer.Text = $"{timeLeft / 60}:{timeLeft % 60:D2}"; // Hiển thị thời gian dạng phút:giây

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                GameOver("Hết giờ! Điểm của bạn là: {score}");
            }
        }

        private void Min2Form1_Paint(object sender, PaintEventArgs e)
        {
            // Điền giá trị vào các label
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cardLabel[i, j].Text = cards[i, j] == 0 ? "" : cards[i, j].ToString();
                    setCardColor(i, j);
                }
            }
            lbScore.Text = score.ToString();
        }

        private bool creatRandomCard()
        {
            List<int> emptyPositions = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                if (cards[i / 4, i % 4] == 0)
                {
                    emptyPositions.Add(i);
                }
            }
            if (emptyPositions.Count > 0)
            {
                int set = emptyPositions[rand.Next(emptyPositions.Count)];
                cards[set / 4, set % 4] = rand.Next(1, 100) > 90 ? 4 : 2;
                score += cards[set / 4, set % 4];
                return true;
            }
            return false;
        }

        #region Xử lý di chuyển
        bool doUp()
        {
            bool isDo = false;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int y1 = y + 1; y1 < 4; y1++)
                    {
                        if (cards[x, y1] > 0)
                        {
                            if (cards[x, y] == 0)
                            {
                                cards[x, y] = cards[x, y1];
                                cards[x, y1] = 0;
                                y--;
                                isDo = true;
                            }
                            else if (cards[x, y] == cards[x, y1])
                            {
                                cards[x, y] *= 2;
                                cards[x, y1] = 0;
                                isDo = true;
                            }
                            break;
                        }
                    }
                }
            }
            if (isDo)
                creatRandomCard();
            return isDo;
        }

        bool doDown()
        {
            bool isDo = false;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 3; y >= 1; y--)
                {
                    for (int y1 = y - 1; y1 >= 0; y1--)
                    {
                        if (cards[x, y1] > 0)
                        {
                            if (cards[x, y] == 0)
                            {
                                cards[x, y] = cards[x, y1];
                                cards[x, y1] = 0;
                                y++;
                                isDo = true;
                            }
                            else if (cards[x, y] == cards[x, y1])
                            {
                                cards[x, y] *= 2;
                                cards[x, y1] = 0;
                                isDo = true;
                            }
                            break;
                        }
                    }
                }
            }
            if (isDo)
                creatRandomCard();
            return isDo;
        }

        bool doRight()
        {
            bool isDo = false;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 3; x >= 1; x--)
                {
                    for (int x1 = x - 1; x1 >= 0; x1--)
                    {
                        if (cards[x1, y] > 0)
                        {
                            if (cards[x, y] == 0)
                            {
                                cards[x, y] = cards[x1, y];
                                cards[x1, y] = 0;
                                x++;
                                isDo = true;
                            }
                            else if (cards[x, y] == cards[x1, y])
                            {
                                cards[x, y] *= 2;
                                cards[x1, y] = 0;
                                isDo = true;
                            }
                            break;
                        }
                    }
                }
            }
            if (isDo)
                creatRandomCard();
            return isDo;
        }

        bool doLeft()
        {
            bool isDo = false;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int x1 = x + 1; x1 < 4; x1++)
                    {
                        if (cards[x1, y] > 0)
                        {
                            if (cards[x, y] == 0)
                            {
                                cards[x, y] = cards[x1, y];
                                cards[x1, y] = 0;
                                x--;
                                isDo = true;
                            }
                            else if (cards[x, y] == cards[x1, y])
                            {
                                cards[x, y] *= 2;
                                cards[x1, y] = 0;
                                isDo = true;
                            }
                            break;
                        }
                    }
                }
            }
            if (isDo)
                creatRandomCard();
            return isDo;
        }
        #endregion

        private void Min2Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool moved = false;
            if (e.KeyData == Keys.Up) moved = doUp();
            if (e.KeyData == Keys.Down) moved = doDown();
            if (e.KeyData == Keys.Right) moved = doRight();
            if (e.KeyData == Keys.Left) moved = doLeft();
            if (moved)
            {
                this.Refresh();
                UpdateHighScore();

                // Kiểm tra game over
                if (CheckGameOver())
                {
                    SaveHighScore();
                    GameOver("Điểm của bạn là: " + score.ToString() + "\nBạn có muốn chơi lại không?");
                }
            }
        }

        private void GameOver(string message)
        {
            DialogResult dia = MessageBox.Show(message, "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.No)
                Application.Exit();
            else
                ResetGame();
        }

        private bool CheckGameOver()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (cards[x, y] == 0 ||
                        (y < 3 && cards[x, y] == cards[x, y + 1]) ||
                        (x < 3 && cards[x, y] == cards[x + 1, y]))
                    {
                        return false; // Vẫn còn di chuyển được
                    }
                }
            }
            return true; // Không còn di chuyển được
        }

        private void ResetGame()
        {
            if (score > highScore)
            {
                highScore = score;
                SaveHighScore();
            }
            score = 0;
            timeLeft = 120; // Đặt lại thời gian về 2 phút
            gameTimer.Start(); // Bắt đầu lại bộ đếm thời gian
            initCards();
            lbHighScore.Text = highScore.ToString();
        }

        private void LoadHighScore()
        {
            if (File.Exists("highscoremin2.txt"))
            {
                string scoreText = File.ReadAllText("highscoremin2.txt");
                int.TryParse(scoreText, out highScore);
            }
        }

        private void SaveHighScore()
        {
            File.WriteAllText("highscoremin2.txt", highScore.ToString());
        }

        private void initCards()
        {
            score = 0;
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                    cards[x, y] = 0;
            creatRandomCard();
            creatRandomCard();
            this.Refresh();
        }

        private void UpdateHighScore()
        {
            if (score > highScore)
            {
                highScore = score;
                SaveHighScore();
                lbHighScore.Text = highScore.ToString();
            }
        }

        private void setCardColor(int x, int y)
        {
            switch (cards[x, y])
            {
                case 0: cardLabel[x, y].BackColor = Color.FromArgb(205, 193, 180); break;  // Màu nền
                case 2: cardLabel[x, y].BackColor = Color.FromArgb(238, 228, 218); break;  // Màu nhạt
                case 4: cardLabel[x, y].BackColor = Color.FromArgb(237, 224, 200); break;  // Màu vàng nhạt
                case 8: cardLabel[x, y].BackColor = Color.FromArgb(242, 177, 121); break;  // Màu cam
                case 16: cardLabel[x, y].BackColor = Color.FromArgb(245, 149, 99); break;  // Màu cam đậm
                case 32: cardLabel[x, y].BackColor = Color.FromArgb(246, 124, 95); break;  // Màu đỏ cam
                case 64: cardLabel[x, y].BackColor = Color.FromArgb(246, 94, 59); break;   // Màu đỏ
                case 128: cardLabel[x, y].BackColor = Color.FromArgb(237, 207, 114); break; // Màu vàng
                case 256: cardLabel[x, y].BackColor = Color.FromArgb(237, 204, 97); break;  // Màu vàng sáng
                case 512: cardLabel[x, y].BackColor = Color.FromArgb(237, 200, 80); break;  // Màu vàng đậm
                case 1024: cardLabel[x, y].BackColor = Color.FromArgb(237, 197, 63); break; // Màu vàng đậm hơn
                case 2048: cardLabel[x, y].BackColor = Color.FromArgb(237, 194, 46); break; // Màu vàng tối
                case 4096: cardLabel[x, y].BackColor = Color.FromArgb(60, 58, 50); break;   // Màu nâu xám
                case 8192: cardLabel[x, y].BackColor = Color.FromArgb(45, 43, 37); break;   // Màu nâu đậm
                default: cardLabel[x, y].BackColor = Color.FromArgb(60, 58, 50); break;     // Màu mặc định cho giá trị cao hơn
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        // Kiểm tra nếu MenuForm chưa mở
        private bool menuFormOpened = false;

        private void ExitToMenu_Click(object sender, EventArgs e)
        {
            // Dừng bộ đếm thời gian
            gameTimer.Stop();

            if (!menuFormOpened) // Kiểm tra nếu MenuForm chưa mở
            {
                menuFormOpened = true; // Đánh dấu rằng MenuForm đã được mở
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Close();
            }
        }

    }
}

