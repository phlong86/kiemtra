using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "PhuocLong" && txtpassword.Text == "12345")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");

            }
            else
            {
                MessageBox.Show("Sai tên dăng nhập hoặc mật khẩu", "Thông báo");
            }
        }
    }
}
