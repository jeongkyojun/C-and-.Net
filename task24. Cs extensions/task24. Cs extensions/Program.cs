using System;
using static System.Console;
/*
* 
* C# 프로그래밍 23일차 4단원 C# 확장기능 : 51강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/
namespace task24._Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TupleDemo tupledemo = new TupleDemo();
            tupledemo.output();
        }
    }

    class TupleDemo
    {
        void TupleHead()
        {
            WriteLine("51. 튜플");
            WriteLine("튜플이란, 값을 한번에 하나이상 전달하거나 제공받을때 사용하는 데이터 구조이다.");
            //리스트와 딕셔너리를 합친 개념으로 생각하면 된다.
        }
        void TupleMain()
        {
            var r = (12, 34, 56);
            WriteLine("- 기본");
            WriteLine("tuple의 원소는 Item1, Item2, Item3 등 Item을 이용해 출력한다.");
            WriteLine($"Ex) r = (12, 34, 56)\n-> {r.Item1},{r.Item2},{r.Item3}");

            WriteLine("\n- 이름 지정");
            var uhd = (Width: 3840, Height: 2160);
            WriteLine("tuple 내의 원소는 dictionary처럼 이름 지정이 가능하다.");
            WriteLine($"Ex) UDH : {uhd.Width} x {uhd.Height}");

            WriteLine("\n- 이름과 형식 지정");
            (ushort Width, ushort Height) hd = (1366, 768);
            WriteLine("tuple의 정의는 () 내에 지정하고자하는 변수들의 자료형과 변수명을 입력한 뒤, 튜플의 이름을 지정하는 것이다.");
            WriteLine($"Ex) (ushort Width, ushort Height) hd : {hd.Width} x {hd.Height}");
            WriteLine($"{hd.Width.GetType()},{hd.Height.GetType()}");

            WriteLine("\n-튜플 리턴 형식");
            var returnTuple = Tally1();
            WriteLine($"return 받은 tuple의 값 : {returnTuple.Item1},{returnTuple.Item2}");
            WriteLine("튜플 리턴 형식 또한 이름을 지정할 수 있다.");
        }
        static (int, int) Tally1()
        {
            var r = (12, 3);
            return r;
        }

        public void output()
        {
            TupleHead();
            TupleMain();
        }
    }
}
