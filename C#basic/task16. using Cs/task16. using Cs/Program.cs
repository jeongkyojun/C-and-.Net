using System;
using sys = System;
using static System.Console;
/*
* 
* C# 프로그래밍 15일차 3단원 C# 활용 : 40강 ~ 41강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/


namespace task16._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DelegateDemo.output();
            EventDemo eventdemo = new EventDemo();
            eventdemo.output();
        }
    }

    class DelegateDemo
    {
        static void Hi() => Console.WriteLine("안녕하세요"); //출력함수 생성
        static void GoodBye() => WriteLine("안녕히가세요");
        delegate void sayDelegate(); // 대리자 생성

        public static void output()
        {
            WriteLine("40. 대리자");
            WriteLine("대리자란, 함수 자체를 데이터 하나로 보고 대신 실행시켜 주는 기능이다.");
            WriteLine("delegate 키워드를 이용하여 생성하며, 한번에 메서드 하나 이상을 대신해서 호출할 수 있는 개념이다.");
            
            sayDelegate say = Hi;
            Write("일반 선언 >> ");
            say();

            Write("인스턴스 선언 >>");
            var hi = new sayDelegate(Hi);
            hi();

            WriteLine("또한, 대리자는 += 를 이용하여 대신 선언할 메서드를 하나 이상 등록할 수 있다.");

            hi += new sayDelegate(GoodBye);
            WriteLine("GoodBye 함수 추가 >> ");
            hi();
            WriteLine("\n또한, -=를 이용해 메서드를 제외할 수도 있다.\n");
            hi -= new sayDelegate(Hi);
            hi();
            WriteLine("\n메서드는 더해진 순서대로 실행된다.\n");
            hi += new sayDelegate(Hi);
            hi();
        }
    }

    class ButtonClass
    {
        public delegate void EventHandler(); // 메서드를 여러개 등록 후 호출 가능
        public event EventHandler Click; // 이벤트 선언 - 클릭 이벤트
        public void OnClick()
        {
            if(Click !=null)
            {
                Click();
            }
        }
    }

    class EventDemo
    {
        public void output()
        {
            WriteLine("41. 이벤트");
            WriteLine("\n이벤트란, 대리자를 이용해 특정 상황(트리거)이 벌어졌을 때, 원하는 상황을 일으켜주는 멤버이다.");
            ButtonClass btn = new ButtonClass();
            WriteLine("아무것도 없을때의 OnClick() 호출 >>");
            btn.OnClick();
            btn.Click += Hi1; // btn.Click +=new ButtonClass.EventHandler(Hi1);
            btn.Click += Hi2; // btn.Click +=new ButtonClass.EventHandler(Hi2);
            WriteLine("\n\n이벤트를 둘 추가 한뒤의 OnClick() 호출 >>");
            btn.OnClick(); // 이벤트 처리기를 사용한 이벤트 발생 : 다중 메서드 호출
        }
        static void Hi1() => WriteLine("C#");
        static void Hi2() => WriteLine(".Net");
    }
}
