// + 연산자 양쪽을 더함 ex)reslult = num1 + 5;
// - 왼쪽  아 설명 다필요없고 걍 빼기 .ㅡㅡ ex) 이거 구지 해ㅓ야하냐 걍 
// * 생략
// / 몫 생략
// % 나머지

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int result;
        result = 1 + 2;
        Console.WriteLine(result);

        result = 3 - 1;
        Console.WriteLine(result);

        // 아 이하 생략 의미없다.
    }
}

// ++ 1씩 증가 // -- 1씩 감소

class Otherclass
{
    public static void Main(string[] args)
    {
        int num = 0;
        Console.WriteLine(num++);
        Console.WriteLine(num);
        Console.WriteLine(--num);
        Console.WriteLine(num++);
    }
}