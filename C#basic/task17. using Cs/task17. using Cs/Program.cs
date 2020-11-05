using System;
using static System.Console;

namespace task17._using_Cs
{
    /*
    * 
    * C# 프로그래밍 16일차 3단원 C# 활용 : 42강 ~ 43강
    * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
    *
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PartialclassDemo partialDemo = new PartialclassDemo();
            partialDemo.output();
            WriteLine("\n\n43. 상속");
            WriteLine("상속이란, 부모클래스의 메서드와 변수를 자식클래스에서 그대로 사용할 수 있게 하는 것이다.");
            inheritanceChild child = new inheritanceChild();
            child.Foo();
            child.Bar();
            WriteLine();
            finalchild finalchildren = new finalchild();
        }
    }

    class PartialclassDemo
    {
        void PartialMain()
        {
            WriteLine("42.클래스 기타");
            WriteLine("\n42.1 부분 클래스");
            WriteLine("동일한 이름의 클래스를 서로 다른 CS 파일로 나누어 관리하는 방법이다.");

            var hello = new Hello();
            hello.Hi();             //FirstDeveloper.cs 의 부분클래스 Hello의 Hi 호출
            hello.Bye();            //SecondDeveloper.cs 의 부분클래스 Hello의 Bye 호출
        }

        void PartialPerson()
        {
            WriteLine("\n\nEx) 부분클래스를 이용해 변수와 함수를 따로 관리");
            Person personInfo = new Person("홍길동", 17);
            Person callWilson = new Person();
            personInfo.Print();
            callWilson.Print();
        }
        public void output()
        {
            PartialMain();
            PartialPerson();
        }
    }

    class inheritanceParent
    {
        protected inheritanceParent() => WriteLine("부모클래스 생성");
        public void Foo() => WriteLine("Call the class Parent");
    }
    class inheritanceChild : inheritanceParent
    {
        public inheritanceChild() => WriteLine("자식 클래스 생성");
        public void Bar() => WriteLine("Call the class Child");
    }

    class inheritanceChild2 : inheritanceParent
    {
        public inheritanceChild2() : base() => WriteLine("자식 클래스 생성 2"); // base = super와 동일
    }
    sealed class finalchild : inheritanceChild2
    {
        public finalchild() : base() =>WriteLine("봉인클래스 생성, 이 클래스는 더이상 상속되지 않습니다.");
    }
    /*
    class errorclass : finalchild
    {

    }
    */
    //위의 errorclass 는 sealed되어있는 finalchild를 상속하려했기 때문에 오류가 난다.
}
