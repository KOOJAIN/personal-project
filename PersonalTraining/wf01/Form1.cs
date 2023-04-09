using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 도구상자가 안보일경우 ctrl + alt + x 버튼을 누르면 됩니다.
// 속성창이 안보일경우 F4 버튼을 누르면 됩니다.
namespace wf01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            label1.Text = "Hello World!!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
