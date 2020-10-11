using System;
using static System.Console;
using task25_Cs_extension_ClassLibrary._03_String;
/*
* 
* C# 프로그래밍 24일차 4단원 C# 확장기능 : 52강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/
namespace task25._Cs_extensions
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClasslibraryDemo CLDemo = new ClasslibraryDemo();
            CLDemo.output();
        }
    }

    class ClasslibraryDemo
    {
        /*
        * 52. 클래스 라이브러리 프로젝트
        * .exe 파일을 .dll 파일로 변환하여 다른 프로그램에서 참조하여 사용할 수 있도록 하는 프로젝트이다.
        * 
        * 클래스 라이브러리 프로젝트의 예
        * 1 : .NetFramework 
        * 2 : .Net Core
        * 3 : 자마린
        * 4 : .Net Standard
        * 닷넷 스탠다드는 닷넷을 사용하는 모든 영역에서 공통적으로 사용하는 API를 모아놓기 때문에 닷넷 스탠다드를 기준으로 잡는다.
        */
        void CLHead()
        {
            WriteLine("52. 클래스 라이브러리");
        }
        void CLMain()
        {
            WriteLine("클래스 라이브러리는 결과물들을 DLL 파일로 만든다. 이러한 파일을 어셈블리 라고 한다.");
            WriteLine("C#에서 컴파일된 소스 코드의 결과를 닷넷 어셈블리라고 한다.");
            /*
             * 전역 어셈블리 캐시
             * 
             * 컴퓨터의 윈도 환경에서는 사용되는 모든 어셈블리를 모아놓은 폴더가 있는데, 그것이 어셈블리 캐시(GAC:Global Assembly Cache)이다.
             * 경로 => C:\Windows\Assembly 폴더
             * GAC 또는 다른 클래스의 어셈블리를 사용하려면 Visual Studio에서 참조(reference) 추가를 해면 된다.
             */
            WriteLine("커스텀 클래스 라이브러리 사용하기");
            WriteLine("1. 종속성에서 참조추가를 누른다.");
            WriteLine("2. 원하는 dll파일을 선택한다.");
        }
        void CLTest()
        {
            WriteLine("\n-----테스트-----");
            WriteLine("1. "+task25_Cs_extension_ClassLibrary._01_Creator.Creator.Getname());
            WriteLine("2. " + task25_Cs_extension_ClassLibrary._02_Mathematics.Math.Abs(-1234));
            WriteLine("3. " +"안녕하세요".CutStringUniCode(6));
        }
        public void output()
        {
            CLHead();
            CLMain();
            CLTest();
        }
    }

    /*
     * day 25. 54강 NuGet 패키지
     * NuGet 패키지를 통해 내가 만든 클래스 라이브러리를 공유할 수 있다.
     */
}
