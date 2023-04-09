using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf3_FindNumber
{
    public partial class Form1 : Form
    {
        private int FindNumber = 0; //랜던값을 저장하는 변수
        private int chance = 0; // 입력값을 저장하는 변수 
        private object display;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();    
            FindNumber = rand.Next(1, 21);
            chance = 10;
            Label1.Text = "맞출 숫자를 입력하세요.";
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox.Text);
            if (inputNumber == FindNumber)
            {
                display.Text = "승리했습니다!!!";
            }
            else
            {
                chance--;
                display.Text = "기회는" + chance + "번 남았습니다.";
            }

            if (chance <= 0)
            {
                display.Text = "실패했습니다!!!";
            }
        }
    }
}
