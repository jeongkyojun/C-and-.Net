using System;
using static System.Console;

/*
    * 
    * C# 프로그래밍 18일차 3단원 C# 활용 : 45강 
    * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
    *
    */

namespace task_19._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InterfaceDemo interfaceDemo = new InterfaceDemo();
            interfaceDemo.output();
            WriteLine();
            InterfaceDemo2 interfaceDemo2 = new InterfaceDemo2(new good());
            interfaceDemo2.Run();
            new InterfaceDemo2(new bad()).Run();
        }
    }
    
    interface ICar //인터페이스 생성
    {
        void Go(); // 메서드 시그니처만 제공
    }
    class InterfaceDemo : ICar
    {
        void InterfaceMain()
        {
            WriteLine("45. 인터페이스");
            WriteLine("인터페이스는 클래스에서 구현해야 하는 관련 기능의 정의가 포함된 개념이다.");
            WriteLine("인터페이스는 클래스 또는 구조체에 포함될 수 있는 관련있는 메서드들을 묶어서 관리한다.");
            WriteLine("추상클래스와는 다르게 인터페이스 내의 메서드를 모두 구현해야 하며, 정의만 하므로 클래스 내에서 구현해야 하는 메서드를 미리 정의하는데 사용한다.");
            Go();
        }
        public void Go() => WriteLine("상속한 인터페이스 내의 모든 멤버를 반드시 구현해야 한다!");

        public void output()
        {
            InterfaceMain();
        }
    }

    interface IBattery
    {
        string GetName();
        bool GetNum();
    }

    class good : IBattery
    {
        public string GetName() => "Good";
        public bool GetNum() => true;
    }
    class bad : IBattery
    {
        public string GetName() => "Bad";
        public bool GetNum() => false;
    }

    class InterfaceDemo2
    {
        private IBattery _battery;

        public InterfaceDemo2(IBattery battery)
        {
            _battery = battery;
        }
        public void Run()
        {
            WriteLine($"{_battery.GetName()} 배터리를 장착한 자동차가 달립니다.");
            if(_battery.GetNum())
            {
                WriteLine("잘 달립니다.");
            }
            else
            {
                WriteLine("달리다 퍼졌습니다.");
            }
        }
    }
}
