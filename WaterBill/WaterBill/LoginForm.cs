using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WaterBill
{
    public partial class LoginForm : Form
    {
        private TextBox txtLoginPass;
        private TextBox txtLoginUser;

        public LoginForm()
        {
            InitializeComponent();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(UserStore.Username))
            {
                MessageBox.Show("Chưa có tài khoản. Vui lòng đăng ký trước!", "Thông báo");
                return;
            }

            if (username == UserStore.Username && password == UserStore.Password)
            {
                MessageBox.Show("Đăng nhập xong rồi đó!", "Thành công");
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai username hoặc password!", "Lỗi");
            }
        }




        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register main = new Register();
            main.Show();
            this.Hide();
        }


        public static class UserStore
        {
            public static string Username { get; set; }
            public static string Password { get; set; }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
