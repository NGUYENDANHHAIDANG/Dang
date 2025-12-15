using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WaterBill.LoginForm;

namespace WaterBill
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtRegisterU.Text.Trim();
            string password = txtRegisterP.Text.Trim();

            if (username == "" || password == "" )
            {
                MessageBox.Show("Nhập đủ thông tin đi bạn!", "Lỗi");
                return;
            }


          
            MessageBox.Show("Thành công rồi đó !\nUsername: " + username, "Hahahaha");

            UserStore.Username = username;
            UserStore.Password = password;

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
