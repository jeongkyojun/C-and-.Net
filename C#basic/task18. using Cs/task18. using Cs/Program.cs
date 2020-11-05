using System;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

/*
    * 
    * C# 프로그래밍 17일차 3단원 C# 활용 : 44강
    * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
    *
    */

namespace task18._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OverrideDemo o = new OverrideDemo();
            o.output();
            WriteLine(o.ToString());
            Overload_and_ride o2 = new Overload_and_ride();
            o2.output();
        }
    }
    public class Parent
    {
        public void Say() => WriteLine("부모 : 안녕하세요");
        public void Run() => WriteLine("부모 : (달린다)");
        public virtual void Walk() => WriteLine("부모 : (걷는다)");
    }
    public class Child : Parent
    {
        public void Say() => WriteLine("자식 : 안녕하세요");
        public void Run() => WriteLine("자식 : (달린다)");
        public override void Walk()
        {
            WriteLine("자식 : (걷는다)");
        }
    }
    class OverrideDemo
    {
        public void output()
        {
            WriteLine("44. 메서드 오버라이드");
            WriteLine("오버라이드란, 상속개념에서 부모 클래스에 이미 만든 메서드를 동일한 이름으로 자식클래스에서 재정의하여 사용하는것을 말한다.");
            WriteLine("\nEx)");
            Child c = new Child();
            c.Say();
            c.Run();
            c.Walk();
            WriteLine("\n오버라이드 또한 상속과 같이 sealed 키워드를 붙여 더이상 오버라이드 할 수 없게 만들 수 있다.");
        }
        public override string ToString()
        {
            return "\n오버라이드 한 함수 ToString()";
        }
    }
    class Overload_and_ride
    {
        public void output()
        {
            WriteLine("\n\n메서드 오버라이드와 오버로드의 차이");
            WriteLine("오버로드란, 같은 이름의 서로 다른 매개변수를 가진 함수들을 여러개 정의 하여 하나의 함수처럼 사용하는 것이다.");
            WriteLine("그러나 오버라이드는 같은 이름의 같은 매개변수를 가진 함수의 내용을 바꿔 재정의하는 것을 의미한다.");
            WriteLine("\n오버로드의 예");
            WriteLine($"Sum(int+int) : {Sum(15, 20)}, Sum(double, double) : {Sum(13.3, 12.5)}, Sum(string+string) : {Sum("3", "5")}");
        }

        //오버로드의 예
        int Sum(int a, int b) { return a + b; }
        double Sum(double a, double b) { return a + b; }
        int Sum(string a, string b)
        {
            int numa = Convert.ToInt32(a);
            int numb = Convert.ToInt32(b);
            return numa + numb;
        }
    }
}
