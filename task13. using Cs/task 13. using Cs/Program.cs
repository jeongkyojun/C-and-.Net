using System;
using static System.Console;

/*
* 
* C# 프로그래밍 12일차 3단원 C# 활용 : 32강 ~ 33강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/
namespace task_13._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ObjectNote.ObjMain();
            NoNameClass.NNCMain();
            NoNameClass noname = new NoNameClass();
            WriteLine(noname); // 해당 클래스 데이터 자체를 출력시 ToString에서 반환하는 값을 출력하기 때문에, override하여 원하는 출력문을 반환시킬 수 있다.
            NameSpaceDemo.output();
        }
    }

    public class Counter
    { 
        public void GetTodayVisitCount()
        {
            WriteLine("오늘 1234명이 접속했습니다.");
        }
    }
    class ObjectNote
    {
        public static void ObjMain()
        {
            Counter counter = new Counter();
            counter.GetTodayVisitCount();
        }
    }

    class NoNameClass
    {
        public override string ToString()
        {
            return "NoNameClass에서 반환 문자열을 지정";
        }
        public static void NNCMain()
        {
            var cls = new { Name = "people", Age = 21 };
            WriteLine($"이름 : {cls.Name}, 나이 : {cls.Age}");
        }
    }
    class NameSpaceDemo
    {
        public static void output()
        {
            WriteLine("33. 네임 스페이스");
            WriteLine("\n using 지시문을 이용해 namespace를 선언할 수 있다.");
            /*
             * Ex)
             * using MyNamespace ; // MyNamespace namespace를 사용할 것이라고 선언
             * 
             * namespace MyNamespace
             * {
             *      // namespace 내부에서 namespace를 사용할 수도 있으며, 내부에서 클래스를 만들거나 함수를 만들 수도 있다.
             *      // 자바나 파이썬에서 패키지, C 또는 C++에서의 헤더와 비슷한 느낌이라고 생각하면 될 것 같다.
             * }
             */
            //위에서, using name = MyNamespace; 같은 방식으로 MyNamespace를 다른 이름으로 치환해서 선언할 수도 있다.
        }
    }
}
