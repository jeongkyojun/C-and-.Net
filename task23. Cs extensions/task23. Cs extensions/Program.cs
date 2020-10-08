using System;
using static System.Console;

/*
* 
* C# 프로그래밍 21일차 4단원 C# 확장기능 : 48강 ~ 49강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task23._Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DynamicDemo dynamicDemo = new DynamicDemo();
            dynamicDemo.output();
        }
    }

    public class DynamicDemo
    {
        void DynamicHead()
        {
            WriteLine("50. 동적 형식");
            WriteLine("dynamic 키워드를 통해 런타임 시점에서 형식이 정해지는 동적 형식을 제공받을 수 있다.");
        }
        void DynamicMain()
        {
            dynamic x;
            x = 1234;
            WriteLine($"dynamic x : {x}(type : {x.GetType()})");
            WriteLine("\n- 동적 바인딩");
            WriteLine("동적 바인딩이란, 런타임 때에 데이터 형식을 결정하는 것이다.");

            dynamic now = DateTime.Now;
            int hour = now.Hour;
            WriteLine(hour);

            WriteLine("확장 메서드는 동적 바인딩을 통해서는 실행되지 않는다.");
        }
        public void output()
        {
            DynamicHead();
            DynamicMain();
        }
    }
}
