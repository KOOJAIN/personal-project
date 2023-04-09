using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userId = ID.Text;
            string userPassword = PASSWORD.Text;

            if (userId == "imgroot" && userPassword == "amazing!") // if(userId.Equals("아이디") && (userPassword.Equal("비밀번호)) 로도 사용이 가능하다.
            {
                MessageBox.Show("로그인에 성공했습니다", "로그인");
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }
        }
    }
}
