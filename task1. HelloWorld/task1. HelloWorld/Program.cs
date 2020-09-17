using System;//네임스페이스 선언부
using static System.Console;


/*
 * 
 * C# 프로그래밍 1일차
 * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
 *
 */

namespace HelloWorld//네임 스페이스
{
    class HelloWorld//클래스 선언
    {
        static void Main(string[] args)//메인문 선언
        {
            System.Console.WriteLine("Hello World!");//콘솔에 Hello World를 출력시킨다. 
            //맨 윗줄에 using System이 있기 때문에 Console.WriteLine이라 입력한다. 만약, 없다면 System.Console.WriteLine이라 입력한다.
            Console.WriteLine("Hello World?");
            //이후, using static System.Console을 추가하였다. 이제 WriteLine만 적으면 된다.
            WriteLine("Hello World!!");
            //WriteLine = 줄바꿈, Write = 줄바꿈(\n) 없음
            Write("this is not '\\n' using. ");
            Write("but use '\\n', \n this is using '\\n'\n");
            WriteLine("this is {0}. python의 {1}과 유사함.", "자리표시자","{}.format()");
        }
    }
}
/*
 C#은 네임스페이스 - 클래스 - Main()으로 구성된다.
    1) Main문은 하나여야만 한다.
    2) 대소문자는 구분하여야 한다.
 프로그래밍 개발 주기
    1단계 디자인타임 -> 2단계 컴파일 타임 -> 3단계 런타임

 공백처리
    \n : 줄바꿈
    \t : 들여쓰기(tab)
    \r : 줄의 시작으로 이동(carrage-return)
    \' : 작은따옴표 출력
    \" : 큰따옴표 출력
 자리 표시자 : python의 format과 동일한 역할
    WriteLine("{0}","") 의 방식으로 사용, 앞의 중괄호 안에 번호를 입력시, 뒤의 번호에 해당하는 자리의 문구가 입력된다. 
 */
