using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using System.Runtime.CompilerServices;

/*
* 
* C# 프로그래밍 21일차 4단원 C# 확장기능 : 48강 ~ 49강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task22._Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GenericDemo gDemo = new GenericDemo();
            gDemo.output();
            LINQGenericDemo LINQgDemo = new LINQGenericDemo();
            LINQgDemo.output();
            DictDemo dict = new DictDemo();
            dict.output();
            ExtensionFunction.output();
        }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    class GenericDemo
    {
        void GenericHead() => WriteLine("48. 제네릭 클래스 만들기");
        void GenericMain()
        {
            
            var categories = new List<Category>();
            categories.Add(new Category() { CategoryId = 1, CategoryName = "좋은 책" });
            categories.Add(new Category() { CategoryId = 2, CategoryName = "좋은 강의" });
            categories.Add(new Category() { CategoryId = 3, CategoryName = "좋은 컴퓨터" });

            foreach(var i in categories)
            {
                WriteLine("{0} - {1}", i.CategoryId, i.CategoryName);
            }
        }
        public void output()
        {
            GenericHead();
            GenericMain();
        }
    }
    /*
     * 제네릭 개체를 초기화하는 세가지 방법
     * 1. 개체 형식의 리스트 생성 : 컬렉션 이니셜라이저로 값 초기화
     * ex)
     * List<class> classList = new List<class>()
     * {
     * new class{ value1 = 1, value2 = 10};
     * new class{ value1 = 2, value2 = 20};
     * new class{ value1 = 3, value2 = 30};
     * new class{ value1 = 4, value2 = 40};
     * new class{ value1 = 5, value2 = 50};
     * }
     * 
     * 2. Add() 메서드로 값 추가 : 개체 이니셜라이저로 값 초기화
     * ex)
     * classList.Add(new class(){ value1 = 6, value2 = 60};
     * 
     * 3. AddRange() 메서드로 리스트에 값들 추가
     * var classes2 = new List<class>();
     * {
     * new class{ value1 = 7, value2 = 70};
     * new class{ value1 = 8, value2 = 80};
     * new class{ value1 = 9, value2 = 90};
     * };
     * classes.AddRange(classes2); // classes 에 classes2의 값을 모두 더한다.
     */

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    class LINQGenericDemo
    {
        void LINQGenericHead() => WriteLine("\n\n- LINQ로 제네릭 데이터 다루기");
        void LINQGetCars(IEnumerable<Car> cars)
        {
            foreach (var car in cars)
            {
                WriteLine($"{car.Make} - {car.Model} - {car.Year}");
            }
        }
        
        void LINQGenericMain()
        {
            List<Car> cars = new List<Car>()
            {
                new Car{ Make = "Camper",Model = "Camper1",Year = 2015},
                new Car{ Make = "Camper",Model = "Camper3",Year = 2016},
                new Car{ Make = "SUV",Model = "AAA",Year = 2017},
                new Car{ Make = "SUV",Model = "BBB",Year = 2018},
                new Car{ Make = "SUV",Model = "CCC",Year = 2019},
                new Car{ Make = "SUV",Model = "DDD",Year = 2020},
            };

            // Maker == camper 인 데이터만 저장
            var campers = from car in cars
                          where car.Make == "Camper"
                          select car;
            WriteLine("LINQ로 출력한 Camper 목록");
            LINQGetCars(campers);

            //Maker == SUV 인 데이터만 저장
            var SUVs = from car in cars
                       where car.Make == "SUV"
                       select car;
            WriteLine("\nLINQ로 출력한 SUV 목록");
            LINQGetCars(SUVs);

            var newCars = from car in cars
                          where car.Year >= 2015
                          select car;
            WriteLine("\n2015년 이후 모델 목록");
            LINQGetCars(newCars);

            var orderedCars = from car in cars 
                              orderby car.Year descending 
                              select car;
            WriteLine("\n최근 모델부터 나열한 목록");
            LINQGetCars(orderedCars);

        }
        public void output()
        {
            LINQGenericHead();
            LINQGenericMain();
        }
    }

    class DictDemo
    {
        void DictHead() => WriteLine("\nDictionary 활용\n");
        void DictMain()
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            pairs.Add(1, 100);
            pairs.Add(2, 200);
            Write("pairs = { ");
            foreach(var d in pairs)
            {
                Write(d.Key + " : " + d.Value+" , ");
            }
            WriteLine("}");
        }
        public void output()
        {
            DictHead();
            DictMain();
        }
    }
    static class ExtensionFunction
    {
        static string Three(this string value)
        {
            return value.Substring(0, 3);
        }

        static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static void output()
        {
            WriteLine("\n\n49. 확장 메서드 만들기");
            WriteLine("확장 메서드란, 원본 형식을 바꾸지 않고 이미 있는 형식에 추가 기능을 덧붙이는 것이다.");
            WriteLine("Ex) 글자를 3글자만 남기는 확장 메서드의 경우");
            WriteLine("안녕하세요".Three());

            WriteLine("\n 이와같이 확장 메서드는 \n1. static 클래스 내에서 \n2. static 메서드를 만들고, \n3. 첫번째 매개변수에 this를 붙여 만든다.");
            WriteLine("또한, 위의 문장의 글자수를 세는 함수를 아래와 같이 만들수 있다.");
            WriteLine("Ex2) 단어수 출력 : "+"\n 이와같이 확장 메서드는 \n1. static 클래스 내에서 \n2. static 메서드를 만들고, \n3. 첫번째 매개변수에 this를 붙여 만든다.".Count());
        }
    }
}
