using System;
using System.Linq;
using static System.Console;

using System.Collections;           // 컬렉션 사용
using System.Collections.Generic;   // 제네릭 클래스 컬렉션 사용
using System.Data;
/*
* 
* C# 프로그래밍 9일차 3단원 C# 활용 : 28강 ~ 29강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/


namespace task10._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GenericDemo.outputGeneric();
            DictionaryDemo.outputDictionary();
            NullableDemo.outputNullable();
        }
    }

    class GenericDemo
    {
        static void GenericMain()
        {
            WriteLine("28. 제네릭 사용하기");

            WriteLine("\n\n 28.1. Cup of T\n");
            WriteLine("Cup of T 란 컵에 들어가는 Tea(T)에 따라 컵에 대한 정의가 바뀌는 것을 의미한다.");
            WriteLine("함수도 마찬가지로 함수에 사용되는 매개변수 T에 따라 다양하게 정의되며, 보통의 자료형에 특정형식 T를 받아들이게 하는 형식 매개변수가 바로 제네릭 이다.");

            WriteLine("Ex1 ) Stack 제네릭 클래스\n");
            WriteLine("Stack은 System.Collections에 속해있으나, 제네릭 Stack은 System.Collections.Generic에 속해 있다.");

            Stack stack = new Stack();
            Stack<int> stack_generic_int = new Stack<int>();

            WriteLine("위에서 stack은 단순한 Stack() 컬렉션이지만, stack_generic_int는 Stack<int> 인 제네릭 클래스이다.");


            WriteLine("위 둘의 차이점은 stack에서는 object로 담기 때문에 Convert 작업이 필요하지만, stack_generic_int는 int형으로 담기 때문에 Convert 작업이 필요 없다.");
            stack.Push(3840);
            int num = (int)stack.Pop();// int형으로 반환받기 위해서는 int형으로 변환해주어야 한다.


            stack_generic_int.Push(2160);
            int number = stack_generic_int.Pop(); // int형 제네릭이기 때문에 변환이 필요하지가 않다.

            WriteLine("제네릭 클래스를 사용하게 되면 언박싱 과정을 할 필요가 없기 때문에 효율성이 상승한다.\n\n\n");
        }

        public static void outputGeneric()
        {
            GenericMain();
        }
    }

    class DictionaryDemo
    {
        static void DictionaryMain()
        {
            WriteLine("28.5. Dicionary<T,T> 제네릭 클래스 사용하기");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            WriteLine("dictionary는 Hashtable처럼 두개의 자료형을 연관시켜주는 것으로, key와 value로 나뉘어 데이터를 저장하고 연동할 수 있다.");
            dict.Add("apple", 1);
            dict.Add("candy", 3);
            dict.Add("banana", 2);
            dict.Add("data", 4);
            foreach (string key in dict.Keys)
            {
                WriteLine($"dict[{key}] = {dict[key]}");
            }
            dict.Remove("data");
            WriteLine("\n이제 dict[data]를 삭제함( Remove(\"data\")\n");
            foreach (string key in dict.Keys)
            {
                WriteLine($"dict[{key}] = {dict[key]}");
            }
            WriteLine("\n\n\n");
            // dictionary의 key는 .Keys 명령어를 통해 받을 수 있다. 마찬가지로 value값 또한 .Values 명령어를 통해 받을 수 있다.
        }
        public static void outputDictionary()
        {
            DictionaryMain();
        }
    }

    class NullableDemo
    {
        static void NullableMain()
        {
            WriteLine("29. null 다루기");
            WriteLine(" null은 참조형식이면서 아무것도 참조하지 않는 값이다.");
            int i = 0;
            string s = null;
            string empty = "";
            WriteLine("\nEx)");
            if(empty == s)
            {
                WriteLine("null 은 \"\"이다.");
            }
            else
            {
                WriteLine("null과 빈 값은 서로 다른 값이다.");
            }
            WriteLine("\nnull 가능 형식 - nullable<T> 형식");
            // ex) bool형식은 true, false 값만 가지는 반면, nullable<bool> 은 true, false, null 세가지 값을 갖는다.

            var result = s ?? "기본값"; //여기서 ??는 널값인지 아닌지 확인하는 연산자이다.
            WriteLine(result);
        }
        public static void outputNullable()
        {
            NullableMain();
        }
    }
}
