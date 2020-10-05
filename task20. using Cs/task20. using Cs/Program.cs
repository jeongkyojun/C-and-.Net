using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using static System.Console;

/*
    * 
    * C# 프로그래밍 19일차 3단원 C# 활용 : 46강 
    * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
    *
    */

namespace task20._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AttributeDemo attDemo = new AttributeDemo();
            attDemo.output();
            Attribute.GetCustomAttributes(typeof(CustomAttributeTest));

            NickNameAttributeTest nickattr = new NickNameAttributeTest();
            nickattr.output();
        }
    }
    class AttributeDemo
    {
        [Conditional("DEBUG")]/*Debug 를 가지는 경우 실행*/static void DebugMethod() => WriteLine("디버그 환경에서만 표시");

        [Conditional("RELEASE")]/*Release 기호가 있는경우 실행*/static void ReleaseMethod() => WriteLine("릴리스 환경에서만 표시");
        void AttributeMain()
        {
            Console.WriteLine("46. 특성과 리플렉션");
            WriteLine("특성이란 현재 상태에 따라 조건적으로 정해지는 성격을 의미한다.");
        }
        public void output()
        {
            AttributeMain();
            WriteLine("\n디버그/릴리즈 상태에 따라 호출");
            DebugMethod();
            ReleaseMethod();
            WriteLine("\n특성을 사용하여 메서드 호출 정보 얻기");
            TraceMessage("여기서 무엇인가 실행...");
        }
        public static void TraceMessage(string message,
            [CallerMemberName] string membername = "",
            [CallerFilePath] string sourcefilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLine("실행 내용 : {0}\n멤버 이름 : {1}\n소스 경로 : {2}\n실행 라인 : {3}", message, membername, sourcefilePath, sourceLineNumber);
        }
    }

    

    public class SampleAttribute : Attribute
    {
        public SampleAttribute() => WriteLine("\n\nAttribute 클래스를 상속하여 사용자 지정 특성 만들기");
    }
    [AttributeUsage(
        AttributeTargets.Method|AttributeTargets.Class, AllowMultiple =true)] // AttributeUsage를 이용해 제약조건 설정
    public class NickNameAttribute : Attribute
    {
        public string Name { get; set; }
        public NickNameAttribute(string Name) => this.Name = Name;
    }


    [Sample]
    public class CustomAttributeTest{}

    [NickName("길벗")]
    [NickName("RedPlus")]
    class NickNameAttributeTest
    {
        public void output() =>ShowMetaData();

        static void ShowMetaData()
        {
            WriteLine("\n매개변수가 있는 사용자 지정 특성 만들기\n");
            Attribute[] attrs =
                Attribute.GetCustomAttributes(typeof(NickNameAttributeTest));
            foreach(var attr in attrs)
            {
                if (attr is NickNameAttribute)
                {
                    NickNameAttribute ais = (NickNameAttribute)attr;
                    WriteLine("ais: {0}", ais.Name);
                }
                NickNameAttribute aas = attr as NickNameAttribute;
                if(aas!=null)
                {
                    WriteLine("aas: {0}", aas.Name);
                }
            }
        }
    }

}
