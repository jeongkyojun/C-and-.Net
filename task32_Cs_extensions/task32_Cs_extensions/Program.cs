using System;
using static System.Console;
/*
* 
* C# 프로그래밍 31일차 4단원 C# 확장기능 : 61강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task32_Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FOPdemo fopdemo = new FOPdemo();
            fopdemo.output();
        }
    }

    class FOPdemo
    {
        void FOPHead()
        {
            WriteLine("61. 함수및 함수형 프로그래밍");
            WriteLine("C#은 절차지향과 더불어 함수형 프로그래밍을 지원한다.");
        }
        #region 61.2
        static string GetResultWithStatement(int score)
        {
            string r;
            if (score >= 60)
                r = "합격";
            else
                r = "불합격";
            return r;
        }
        static string GetResultWithExpression(int score) => score >= 60 ? "합격" : "불합격";
        void FOPMain()
        {
            WriteLine("\n61.2 문과 식");
            WriteLine("C#은 문과 식으로 표현한다.");
            WriteLine("문은 여러줄로 표현하고, 식은 한줄로 표현하기 때문에, 식을 사용하여 결과값을 바로 가져오는 방법을 많이 쓴다.");
            // [1] 문을 이용한 출력
            WriteLine("60점 : " + GetResultWithStatement(60));
            // [2] 식을 사용하는 출력
            WriteLine("60점 : " + GetResultWithExpression(60));
            WriteLine("위는 각각 문과 식을 사용하여 같은 기능을 구현했으며, 둘의 차이는 거의 없으나," +
                "최근에는 식을 사용하여 코드를 간결하게 유지하곤 한다.");
        }
        #endregion


        #region 61.3

        // [1] 매개변수가 Action<T>
        static void FunctionParameterWithAction(Action<string> action, string message)
        {
            action(message);
        }

        Action<string> action = message => WriteLine(message);

        // [2] 매개변수가 Func<T>
        static void FunctionParameterWithFunc(Func<int,int> func, int number)
        {
            int result = func(number);
            WriteLine($"{number}*{number} = {result}");
        }

        Func<int, int> func = x => x * x;

        // [3] 반환값이 Action<T>
        static Action<string> FunctionReturnValueWithAction() => msg => WriteLine($"{msg}");

        // [4] 반환값이 Func<T>
        static Func<int, int> FunctionReturnValueWithFunc() => x => x * x;
        void FOPMain2()
        {
            WriteLine("\n61.3 고차함수");
            WriteLine("고차함수란, 함수 자체를 매개변수 또는 반환값으로 가지는 함수이다.");

            // [a] Action<T> 매개변수 전달 : 문자열을 받아 출력하는 함수 정의
            FunctionParameterWithAction(action, "고차함수 : 매개변수");

            // [b] Func<T> 매개변수 전달 : 정수값을 받아 두 번 곱한 후 다시 정수값 반환
            FunctionParameterWithFunc(func, 3);

            // [c] Action<T> 반환값
            FunctionReturnValueWithAction()("고차함수 : 반환값");

            // [d] Func<T> 반환값
            int number = 3;
            int result = FunctionReturnValueWithFunc()(number);
            WriteLine($"{number} * {number} = {result}");
        }
        #endregion

        public void output()
        {
            FOPHead();
            FOPMain();
            FOPMain2();
        }
    }
}
