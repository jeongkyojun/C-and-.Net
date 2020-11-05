using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

    /*
    * 
    * C# 프로그래밍 19일차 3단원 C# 활용 : 47강
    * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
    *
    */
namespace task21._using_Cs
{

    // 47. 객체지향 프로그래밍
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLine("47. 개체와 객체지향 프로그래밍");
            WriteLine("클래스, 상속, 오버라이딩 등을 통해 캡슐화 및 다형성을 구현해보자.\n");

            EncapsulationNote capsule = new EncapsulationNote();
            capsule.EncapsulationMain();
            PolymorphismDemo poly = new PolymorphismDemo();
            poly.output();

            CarWorld CW = new CarWorld();
            CW.CarWorldMain();
        }
    }

    //캡슐화 하기
    public class Person
    {
        private string name;
        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }
    }

    class EncapsulationNote
    {
        public void EncapsulationMain()
        {
            WriteLine("- 캡슐화");
            WriteLine(" 클래스 내의 변수를 private로 감춰놓고 Get 함수와 Set 함수로만 변경및 호출할 수 있게 하는 방법이다.");
            Person person = new Person();
            person.SetName("C#");
            WriteLine($"{person.GetName()}");
        }
    }

    public abstract class animal
    {
        public abstract string Cry();
    }
    public class Dog : animal
    {
        public override string Cry() => "멍!멍!";
    }

    public class Cat : animal
    {
        public override string Cry()
        {
            return "야.옹.";
        }
    }

    public class Trainer
    {
        public void DoCry(animal animal)
        {
            WriteLine(animal.Cry());
        }
    }
    public class PolymorphismDemo
    {
        public void output()
        {
            WriteLine("- 다형성");
            WriteLine(" 다형성이란 오버라이드/오버로드를 통해 하나의 값에도 다양한 경우로 만들수 있음을 보여주는 것이다.");
            animal dog = new Dog();
            animal cat = new Cat();
            Trainer trainer = new Trainer();
            WriteLine("개 : {0} , 고양이 : {1}", dog.Cry(), cat.Cry());
            trainer.DoCry(new Cat());
            trainer.DoCry(new Dog());
        }
    }

    interface IStandard { void Run(); }
    class Car : IStandard
    {
        #region field : Private Member Variables
        private string name; // 필드 : 부품
        private string[] names; // 배열형 필드
        private readonly int _Length; // 읽기 전용 필드
        #endregion

        #region field : Constructors
        //생성자
        public Car()
        {
            name = "좋은 차";
        }
        public Car(string name)
        {
            this.name = name;
        }
        public Car(int _Length)
        {
            name = "좋은 차";
            this._Length = _Length;
            names = new string[_Length];
        }
        #endregion

        #region Method : Public Methods
        //메서드 : 기능/동작
        public void Run() => WriteLine("'{0}' 자동차가 달립니다.", name);
        #endregion

        #region Property : Public Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length { get { return _Length; } }
        #endregion

        #region field : Destructor
        ~Car()
        {
            WriteLine("'{0}' 자동차 폐차됨", name);
        }
        #endregion

        #region Indexer
        //인덱서
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region Iterators
        //반복자
        public IEnumerator GetEnumerator()
        {
            for(int i=0;i<_Length;i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region Public Delegates
        public delegate void EventHandler(); // 대리자: 다중 메서드 호출
        #endregion

        #region Public Events
        public event EventHandler Click; // 이벤트
        #endregion

        #region EventHandler
        public void OnClick()
        {
            if(Click != null)
            {
                Click();
            }
        }
        #endregion
    }

    class CarWorld
    {
        public void CarWorldMain()
        {
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            Car sportsCar = new Car();
            sportsCar.Run();
            sportsCar.Name = "스포츠카";
            sportsCar.Run();

            Car cars = new Car(2);
            cars[0] = "일호";
            cars[1] = "이호";

            for(int i=0;i<cars.Length;i++)
            {
                WriteLine($"{cars[i]}");
            }
            WriteLine("\n----------이터레이터 테스트----------\n");
            foreach(string name in cars)
            {
                WriteLine(name);
            }

            Car btn = new Car("전기자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();
        }
    }
}
