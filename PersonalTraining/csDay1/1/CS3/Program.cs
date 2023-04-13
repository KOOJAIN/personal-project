using System;

namespace A026_SplitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력하세요: ");  
            string s = Console.ReadLine(); 
            Console.WriteLine(s);   

            int sum = 0;        // 합을 저장하는 sum 변수를 0 으로 초기화합니다.
            string[] v = s.Split();
            foreach(var i in v)     //배열에 저장된 개수가 몇 개인지 알 수 없으므로
            {                           // foreach() 문을 쓰는것이 좋다.
                sum += int.Parse(i);    // int.Pares()로 배열의 각요소 i를 정수로 변환하여 sum에 더하고 결과를 출력합니다.
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}