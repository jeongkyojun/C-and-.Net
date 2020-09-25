using System;
using System.Collections.Specialized;
using static System.Console;

/*
 * 
 * C# 프로그래밍 4일차 2단원 C#기초 : 13강 ~ 16강
 * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
 *
 */

namespace task4._Cs_basic3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ControlDemo.outputControl();
        }
    }

    class ControlDemo
    {
        // 13.제어문
        static void Sequence()
        {
            WriteLine("13.1. 순차문");
            WriteLine("프로그램은 말 그대로 순차적(Sequencial)으로 구문을 수행한다.");
            //Ex1.
            int kor = 100;
            int eng = 90;
            int tot = kor + eng; //위의 kor값과 eng값을 더한다.
            double avg = tot / 2; // 위에서 얻은 tot값을 2로 나누어 평균을 구한다.
            WriteLine("국어 : {0}, 영어 : {1}, 총합 : {2}, 평균 : {3:F1}", kor, eng, tot, avg);//여기서 :F1은 소수점 첫째자리까지만 구한다는 뜻이다.
        }

        static void IF_ELSE()
        {
            WriteLine("13.2 조건문");
            WriteLine("조건문은 조건을 걸어두고 해당 조건이 참일 경우에 구문을 수행한다.");
            int x = 10;
            if(x==10)
            {
                WriteLine("x는 {0}입니다.", x);
            }
            if(x!=20)
            {
                WriteLine("x는 20이 아닙니다.");
            }
            WriteLine("\nif/else문");
            Write("숫자 10을 입력하시오 >>");
            string num = ReadLine();
            try
            {
                int number = Convert.ToInt32(num);
                if(number ==10)
                {
                    WriteLine("number는 10 입니다.");
                }

                else
                {
                    WriteLine("number가 10이 아닙니다! number = {0}", number);
                }
            }
            catch(Exception e)
            {
                WriteLine("error! 숫자를 입력하지 않았습니다.");
            }

            WriteLine("그 외에도 if - else if - else 로 여러가지의 조건문을 만들 수도 있다.");
        }

        static void SWITCH()
        {
            WriteLine("14. switch문");
            WriteLine("if/else문은 특정 범위나 논리값을 이용한 조건문이라고 한다면 switch문은 특정 값에 대한 조건문이다.");
            Write("숫자 입력");
            string input = ReadLine();
            try
            {
                int number = Convert.ToInt32(input);
                switch(number%10)
                {
                    case 0:
                        WriteLine("1의 자리가 0");
                        break;
                    case 1:
                        WriteLine("1의 자리가 1");
                        break;
                    case2:
                        WriteLine("1의 자리가 2");
                        break;
                    default:
                        WriteLine("그 외");
                        break;
                }
            }
            catch(Exception e)
            {
                WriteLine("error!");
            }
            WriteLine("\nswitch문은 c나 c++과 다르게 case 이후에 반드시 break를 써줘야 된다.");
        }
        
        static void ITER()
        {
            WriteLine("15. 반복문(for문)");
            WriteLine("for 문은 for(초기조건;종료조건;증/감조건){수행구문} 으로 구성된 반복문이다.\n\nEx)\n");
            for(int i=0;i<10;i++)
            {
                WriteLine("{0} 번째 수행", i + 1);
            }
            WriteLine("\n이와같이 특정한 횟수나 구간을 반복시키는데 사용된다.");
            WriteLine("\n또한, 중첩하여 사용해서 2차원이나 3차원의 n x m, n x m x l의 횟수로 반복하는데도 사용된다.");

            WriteLine("아래는 이중포문을 이용한 구구단 출력이다.");
            for(int i=1;i<=9;i++)
            {
                for(int j=1;j<9;j++)
                {
                    Write("{0} x {1} = {2}\t", i, j, i * j);
                }
                WriteLine();
            }

            WriteLine("또한 조건문을 걸어, 특정 숫자일 때 특정 행동을 취하는 방식의 반복문 또한 사용할 수 있다.");
            WriteLine("이를 이용하여 짝수의 덧셈이나 홀수의 덧셈 등을 사용할 수 있다.");
            WriteLine("\n\n");
            WriteLine("16.반복문(while문)");
            WriteLine("while문은 for문과는 다르게, 특정한 조건만 확인하여 반복시키는 반복문으로, while(조건){수행구문} 으로 구성된다.");
            int number = 0;
            while(number<10)
            {
                WriteLine("number = {0}이므로 number<10이란 조건에 부합합니다.");
                WriteLine("++number이 되어 다음 number의 값 : {0} 이 됩니다.",++number);
            }
            WriteLine("위와 같이 while에서 조건에 맞지 않는 경우 반복이 끝나게 된다.");
            WriteLine("이러한 성질때문에 정해진 횟수나 특정한 구간을 반복하는 for문과 다르게 while문은 주로 일정한 조건 내에서 무한히 반복시키는데 사용된다.");
            
        }
        public static void outputControl()
        {
            Sequence();
            IF_ELSE();
            SWITCH();
            ITER();
        }
    }
}
