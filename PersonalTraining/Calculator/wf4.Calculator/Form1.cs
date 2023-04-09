using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf4.Calculator
{
    public partial class Form1 : Form
    {
        enum Operators  //Operators 라는 enum를 선언 / enum은 열거형을 말한다.
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }
        // 아래는 초기값을 설정한 것이다. //모든 변수를 초기화 하는것이다
        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        //private object currentOperator;
        //private bool operatorChangeFlag;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEqual(object sender, EventArgs e) //영상에서는 btResult즉 '='버튼이다
        {
            secondOperand = Int32.Parse(display.Text);
            if(currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text += firstOperand.ToString();
            }
            else if(currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == Operators.Divide) // 나눗셈만 예외처리를 해줌
            {
                if(secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }

        private void BtnAllClear(object sender, EventArgs e)
        {
            firstOperand = 0;       //연산자와
            secondOperand = 0;          // 피연산자를
            currentOperator = Operators.Add;    // 모두초기화하고
            display.Text = "0";     // 화면에는 0을 출력합니다.
        }

        private void Btn0(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false; 
            }
            string strNumber = display.Text += "0"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void BtnDot(object sender, EventArgs e)
        {

        }

        private void BtnPlus(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void Btn1(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true) //연산자가 눌리면 기존에 저장했던 내용을 지워야하기 때문
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1"; //display 상단의 레이블을 의미 //.text
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void Btn2(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void Btn3(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void BtnMinus(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void Btn4(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void Btn5(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void Btn6(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void BtnMultiple(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void Btn7(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void Btn8(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn도 동일하다
        }

        private void Btn9(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true) // operatorChange가 변경됐다는 Flag가 설정이 돼면
            {
                display.Text = "";        // 화면을 지워지고
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9"; // 숫자를 추가해줄수 있게끔 작성된 코드. 0이기에 0을 추가
            int intnumber = Int32.Parse(strNumber);
            display.Text = intnumber.ToString();    //나머지 숫자btn코드도 동일하다
        }

        private void BtnDivid(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }
    }
}
