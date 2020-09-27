using System;
using static System.Console;
using System.Linq; // Linq 사용
using System.ComponentModel.DataAnnotations;

/*
* 
* C# 프로그래밍 10일차 3단원 C# 활용 : 30강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task11._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinqSum.outputLinqSum();
            LambdaDemo.outputLambdaDemo();
        }
    }

    class LinqSum
    {
        static void LinqSumMain()
        {
            WriteLine("30. LINQ");
            WriteLine(" Linq 란 Language INtegrated Query 의 약자로, 컬렉션의 데이터를 가공하기 위한 다양한 메서드를 제공한다.");
        }
        
        static void LinqSumMain2()
        {
            WriteLine("\n\n30.2. 확장 메서드 사용하기\n");
            int[] numbers = { 114, 27, 35 };
            WriteLine("numbers = {114,27,35}");
            int sum = numbers.Sum();        // 배열 numbers 내의 배열의 합을 구하는 linq 구문
            WriteLine($"sum : {sum}");
            int count = numbers.Count();    // 배열 numbers 의 배열 개수
            WriteLine($"numbers의 배열 개수 : {count} 개");
            double average = numbers.Average(); // 배열 평균값 구하기
            WriteLine($"배열 평균 : {average:#,###.##}");
            int max = numbers.Max();        // 배열 내에서 가장 큰 값 구하기
            int min = numbers.Min();
            WriteLine($"배열 중 가장 큰 수 : {max}, 가장 작은 수 : {min}");
        }

    
        public static void outputLinqSum()
        {
            LinqSumMain();
            LinqSumMain2();
        }
    }

    class LambdaDemo
    {
        static void LambdaMain()
        {
            WriteLine("\n\n30.3. 화살표 연산자와 람다식으로 연산처리\n");
            WriteLine("Func<매개변수 자료형, 리턴값 자료형>으로 정의한다.");
            Func<int, bool> isEven = x => x % 2 == 0;
            int num1 = 5;
            WriteLine($"{num1} is Even? => {isEven(num1)}");
            int num2 = 8;
            WriteLine($"{num2} is Even? => {isEven(num2)}");


            WriteLine("\nEx1. 배열에서 홀수만 추출");
            int[] arr = { 1, 2, 3, 4, 5 };
            var q = arr.Where(num => num % 2 == 1);
            Write("result : ");
            foreach(int i in q)
            {
                Write($"{i}\t");
            }
            WriteLine();
            WriteLine("위의 식처럼 응용하여 where구문과 함께 =>구문을 이용해 조건식을 만들 수 있다.");
        }
        public static void outputLambdaDemo()
        {
            LambdaMain();
        }
    }
}
