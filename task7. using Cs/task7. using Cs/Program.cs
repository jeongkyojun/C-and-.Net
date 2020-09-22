using System;

using static System.Console;

// Math 패키지 사용 - 자연로그상수값(E), 원주율(PI), 절댓값(Abs),최대(Max),최솟값(Min), n제곱(Pow), 올림(Ceiling) 또는 버림(Floor) 등의 수학적 기호 사용 가능
// using static System.Math; 를 사용하면 Math.를 쓸 필요 없이 바로 함수를 사용할 수 있다.
using static System.Math;


/*
 * 
 * C# 프로그래밍 6일차 3단원 C# 활용 : 21강 ~ 23강
 * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
 *
 */

struct strDemo
{
    public int X; // 기본 상태는 private이기 때문에, 외부에서 사용하기 위해서는 public을 선언해주어야 한다.
    public int Y;
};

namespace task7._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //21강 Math package
            usingStaticClassDemo.outputStaticClassDemo();

            //22강 구조체 사용
            StructDemo.outputStructDemo();
        }
    }

    class usingStaticClassDemo
    {
        static void UsingStaticMath()
        {
            WriteLine("\n21. Math 패키지 사용하기");
            WriteLine("Math 패키지는 다양한 수학적 함수등을 사용할 수 있게 해주는 패키지이다.\n");
            Write("2의 10제곱 출력 >> ");
            WriteLine(Math.Pow(2, 10));

            Write("3의 5제곱 출력 >> ");
            WriteLine(Pow(3, 5));
            Write("3 과 5 중 큰 값을 출력 >> ");
            WriteLine(Max(3, 5));
        }

        public static void outputStaticClassDemo()
        {
            UsingStaticMath();
        }
    }

    class StructDemo
    {
        static void StructMain()
        {
            strDemo struct1;
            struct1.X = 100;
            struct1.Y = 200;

            WriteLine("struct1.X = {0}, struct1.Y = {1}", struct1.X, struct1.Y);

            Product product;
            product.Id = 1;
            product.Title = "책";
            product.Price = 10000M;

            WriteLine($"\n\n물건 id : {product.Id}\n물건 이름 : {product.Title}\n물건 가격 : {product.Price}\n\n");
        }    
        static void StructArray()
        {
            WriteLine("22.4. 구조체 배열");
            Product[] products = new Product[5];
            products[0].Id= 1; products[0].Title = "책 a";products[0].Price = 5000;
            products[1].Id = 2; products[1].Title = "책 b"; products[1].Price = 7000;
            products[2].Id = 3; products[2].Title = "책 c"; products[2].Price = 12000;
            products[3].Id = 4; products[3].Title = "책 d"; products[3].Price = 6000;
            products[4].Id = 5; products[4].Title = "책 e"; products[4].Price = 4000;

            for(int i=0;i<5;i++)
            {
                WriteLine($"Id : {products[i].Id}, Title : {products[i].Title}, Price : {products[i].Price}");
            }
        }

        static void BuiltinStruct()
        {
            WriteLine("\n22.6. 내장형 구조체");
            WriteLine("1. DateTime 구조체 : 기간/날짜관련 모든 정보를 제공");
            WriteLine($" Ex ) \t현재시간 출력 : {DateTime.Now}\n\t" +
                $"{DateTime.Now.Year}\n\t" +//년
                $"{DateTime.Now.Month}\n\t" +//월
                $"{DateTime.Now.Day}\n\t" +//일
                $"{DateTime.Now.Hour}\n\t" +//시
                $"{DateTime.Now.Minute}\n\t" +//분
                $"{DateTime.Now.Second}\n\t" +//초
                $"{DateTime.Now.Millisecond}\n\t" +//100분의 1초
                $"{DateTime.Now.Date}\n\t" +//날짜(시간은 정각 기준)
                $"{DateTime.Now.ToLongTimeString()}");//시간

            WriteLine("\n\n그 외에도 문자관련 구조체 ToLower (대문자를 소문자로), ToUpper (소문자를 대문자로) 등이 있다.\n\n");
        }

        static void ConsoleColorDemo()
        {
            WriteLine("23.1. 열거형 형식");
            WriteLine("ConsoleColor. 형식을 통해 색상을 편리하게 나타낼 수 있게 하는 구조체이다.");
            WriteLine("아래와 같이 BackgroundColor와 ForeGroundColor를 통해 배경및 글자색을 바꾸는데, 색상값을 편리하게 나타낼 수 있다.");
            Console.ForegroundColor = ConsoleColor.Blue;
            WriteLine("Blue");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Red");
            ResetColor();

            WriteLine("열거형 형식을 만들기 위해서는 enum 키워드를 사용한다.");
            /*
             * enum 열거형 이름
             * {
             *      열거형 변수 1 = 기본값1;
             *      열거형 변수 2 = 기본값2;
             *      열거형 변수 3 = 기본값3;
             * }
             */
            Priority high = Priority.High;
            Priority normal = Priority.Normal;
            Priority low = Priority.Low;
            WriteLine($"\nEx)\n{high}, {normal}, {low}");
            WriteLine($"{(int)high},{(int)normal},{(int)low}");//int형으로 바꾸면 해당 변수와 매핑된 값으로 변하며, 특정 변수만 값이 정해져 있다면 다음 변수는 정하지 않더라도 다음 숫자로 변한다.
        }
        public static void outputStructDemo()
        {
            StructMain();
            StructArray();
            BuiltinStruct();
            ConsoleColorDemo();
        }
    }
}

struct Product
{
    // 구조체란 다양한 자료형의 변수를 하나의 묶음으로 나타낸 것이다.
    public int Id;
    public string Title;
    public decimal Price;

};


//열거형 예시
enum Priority
{
    High=1,
    Normal=2,
    Low=3
}