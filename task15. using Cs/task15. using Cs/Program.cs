using System;
using static System.Math;
using static System.Console;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Globalization;
/*
* 
* C# 프로그래밍 14일차 3단원 C# 활용 : 37강 ~ 39강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task15._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog dog = new Dog();
            dog.Eat();
            ParamsDemo param = new ParamsDemo();
            param.output();
            DefaultDemo def = new DefaultDemo();
            def.output();

            PropertyDemo propertydemo = new PropertyDemo();
            propertydemo.output();

            IndexerNote.IndexerMain();
            IndexerNote indexers = new IndexerNote();
            indexers[0] = "CLA";
            indexers[1] = "CLS";
            indexers[2] = "AMG";
            WriteLine($"Length : {indexers.Len}");
            WriteLine($"Length(indexer[0]) : {indexers[0].Length}");
        }
    }
    /*
     * 37. 메서드와 매개변수
     * 
     * 메서드 : 클래스 내에서 선언된 함수
     * 
     * 매개변수 : 함수 밖의 지역변수를 함수 내에서 쓸 수 있게 하는 매개가 되는 변수
     */
    class Dog
    {
        public void Eat()
        {
            WriteLine("[1] 밥을 먹는다.");
            this.Digest();
        }

        private void Digest()
        {
            WriteLine("[2] 소화 시킨다.");
        }
    }

    //가변길이 매개변수
    class ParamsDemo
    {
        void ParamMain()
        {
            WriteLine("\n가변길이 매개변수 - params를 이용한 매개변수 적용");
            WriteLine($"sum(3,5) : {SumAll(3, 5)}");
            WriteLine($"sum(3,5,7) : {SumAll(3, 5, 7)}");
            WriteLine($"sum(3,5,7,9) : {SumAll(3, 5, 7, 9)}");
        }

        int SumAll(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public void output()
        {
            ParamMain();
        }
    }
    //default값을 이용한 선택적 매개변수
    class DefaultDemo
    {
        void DefaultMain()
        {
            WriteLine($"\n매개변수 둘 다 적용, 3+5 : {DefaultSum(3, 5)}");
            WriteLine($"Default 값 적용, 3+1(default) : {DefaultSum(3)}");
            WriteLine("매개변수 적용은 왼쪽부터 되므로 default값은 오른쪽부터 적용해야 한다.");
        }
        int DefaultSum(int a, int b = 1)
        {
            return a + b;
        }
        public void output()
        {
            DefaultMain();
        }
    }

    class PropertyDemo
    {
        string Name { get; set; }
        string number { get; set; }
        public PropertyDemo()
        {
            Names = "default name";
            number = "00000000";
        }
        void PropertyMain()
        {
            WriteLine("이전 C++에서는 getName, setName 과 같이 속성함수를 직접 정의하고 설정해주어야 했던 반면,");
            WriteLine("C#에서는 get 과 set 만으로 자동 속성함수를 적용할 수 있게 되었다.");
        }
        public string Names
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public string numbers
        {
            get => number;              // get과 set을 화살표(=>)로 간단하게 표시할 수도 있다.
            set => number = value;
        }
        public void output()
        {
            WriteLine("\n\n\n38. 속성\n");
            PropertyMain();
            WriteLine("Ex1");
            WriteLine($"초기의 기본 Name = {Names} ");

            WriteLine("Name 을 hello world 로 변경");
            Names = "hello world";

            WriteLine($"변경 후 Name : {Names}");
        }
    }

    class Catalog
    {
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index} : 짝수 반환" : $"{index} : 홀수 반환";
            }
        }
    }
    class IndexerNote
    {

        //생성자
        public IndexerNote()
        {
            names = new string[5];
        }
        public IndexerNote(int num)
        {
            names = new string[num];
        }

        // 변수(배열)
        public string[] names;

        //인덱서
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        //변수의 길이 출력
        public int Len
        {
            get { return names.Length; }
        }

        //별개의 인스턴스 출력
        public static void IndexerMain()
        {
            WriteLine("\n\n\n39. 인덱서와 연산자");
            WriteLine("인덱서는 [] 를 이용한 함수라고 생각하면 된다.");
            WriteLine("인덱서는 속성 여러개를 하나로 표현하거나 개체를 배열 형식으로 표현할 때 사용된다.");
            WriteLine("보통의 함수는 '함수이름(매개변수)'의 형식이나, 인덱서는 '함수이름[매개변수]'의 형식으로 작동한다.");
            Catalog catalog = new Catalog();
            WriteLine(catalog[0]);
            WriteLine(catalog[1]);
            WriteLine(catalog[2]);
        }
    }
}
