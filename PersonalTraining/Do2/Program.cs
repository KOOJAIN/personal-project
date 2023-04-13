// for(초기화; 조건식; 반복식) => 반복 실행될 코드
// for(초기화; 조건식; 반복식)  {//반복 실행될 코드가 // 두줄 이상인 경우}



// for( 1초기화; 2조건식; 4반복식) {// 3반복 코드}
using System;
class MainClass
{
    public static void Main(string[] args)
    {
        for(int i =1; i<11; i++)        // i = i+1 => i++ | 1~10
            Console.WriteLine(i);
    }
}
