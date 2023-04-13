// while(조건식)  => 반복 실행될 코드
// while(조건식) => { // 반복 실행될 코드가 두줄 이상인 경우}

//using System;
//class MinClass
//{
//    public static void Main(string[] args)
//    {
//        int i = 1; // 1=> i
//        while (i < 11)
//            Console.WriteLine(i++);
//    }
//}

using System;
class Program
{
    public static void Main(string[] args)
    {
        int i = 1;
        while (i < 11)
        {
            Console.WriteLine(i++); //Console.WriteLine(i);
            // i++;

            //if (i > 10)
              //  break;
        }
    }
}