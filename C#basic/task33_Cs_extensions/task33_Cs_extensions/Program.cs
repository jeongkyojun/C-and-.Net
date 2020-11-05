using System;
using static System.Console;

/*
* 
* C# 프로그래밍 32일차 4단원 C# 확장기능 : 62강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task33_Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ModernDemo PatternWithIf = new ModernDemo();
            PatternWithIf.output();
            WriteLine("\n");
            PatternMatchingWithSwitch PatternWithSwitch = new PatternMatchingWithSwitch();
            PatternWithSwitch.output();
        }
    }


    #region 패턴 매칭

    /// <summary>
    /// 패턴 매칭 : C#의 최신기술 중 하나로, 이를 사용시 패턴과 값이 일치하는지 확인할 수 있다.
    /// </summary>
    class Shape { }
    class Rectangle:Shape
    {
        public string Name { get; set; } = "사각형";
    }
    class ModernDemo
    {
        void Head() => WriteLine("62. 모던 C#");
        static void Body() => ShowShape(new Rectangle());
        static void ShowShape(Shape shape)
        {
            // [1] if 구문을 사용한 패턴 매칭
            if(shape is Rectangle r)
            {
                WriteLine(r.Name);
            }
        }
        public void output()
        {
            Head();
            Body();
        }
    }
    #endregion

    #region switch문을 이용한 패턴매칭
    class Circle
    {
        public int Radius { get; set; } = 10;
    }

    class Rectangle2
    {
        public int Length { get; set; }
        public int Height { get; set; }
    }
    class PatternMatchingWithSwitch
    {
        void Body()
        {
            PrintShape(new Circle());                                   // 원
            PrintShape(new Rectangle2() { Length = 20, Height = 10 });  // 직사각형
            PrintShape(new Rectangle2() { Length = 10, Height = 10 });  // 정사각형
        }

        void PrintShape(object shape)
        {
            switch(shape)
            {
                case Rectangle2 s when (s.Length == s.Height):
                    WriteLine($"정사각형 {s.Length} x {s.Height}");
                    break;
                case Rectangle2 r:
                    WriteLine($"직사각형 {r.Length} x {r.Height}");
                    break;
                case Circle c:
                    WriteLine($"원 : 반지름({c.Radius})");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
                default:
                    WriteLine("---<기타 도형>---");
                    break;

            }
        }
        public void output()=>Body();
    }
    #endregion
}
