using System;

namespace A013_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 51961189;             //int num을 선언하고 5... 를 할당합니다.
            long bigNum = num; // 암시적 형변환 //long 변수 bigNum을 선언하고 num 변수의 값을 할당합니다. // int 보다 long이 더 커서 암시적 형변환이 가능하다
            Console.WriteLine(bigNum); //bigNum을 출력하는데 이때 출력값은 num변수값을 가지고 있습

            double x = 1234.5; // 선언 ㅇㅇ
            int a;

            a = (int)x;     // 명시적 형변환
            Console.WriteLine(a);
        }
    }
}