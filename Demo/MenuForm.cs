using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Icon = new Icon("2048.ico");

            this.Text = "2048";
        }

        // Sự kiện khi bấm chọn lưới 4x4
        private void label4x4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Form 1 cho lưới 4x4
            form1.Show();
            this.Hide();
        }


        private void label5x5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form 2 cho lưới 5x5
            form2.Show();
            this.Hide();
        }

        private void labelAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game 2048 - Nhóm 6\n Nguyễn Văn Hậu \n Nguyễn Ngọc Sang \n Tô Thanh Tuấn", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát chương trình
            }
        }

        private void min2_4x4_Click(object sender, EventArgs e)
        {
            Min2Form1 min2form1 = new Min2Form1(); // Form 1 cho lưới 4x4 có tính thời gian
            min2form1.Show();
            this.Hide();
        }

        private void min2_5x5_Click(object sender, EventArgs e)
        {
            Min2Form2 min2form2 = new Min2Form2(); // Form 2 cho lưới 5x5 có tính thời gian
            min2form2.Show();
            this.Hide();
        }
    }
}

