using System;
using System.Diagnostics;
using System.Threading;
using static System.Console;


/*
 * 
 * C# 프로그래밍 7일차 3단원 C# 활용 : 24강
 * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
 *
 */


namespace task8._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("Hello World!");
            ClassDemo.Classoutput();
            timer.Stop();
            WriteLine("main문 내에서 실행시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);
            WriteLine("main문 내에서 실행시간 : {0}초", timer.Elapsed.TotalSeconds);
        }
    }

    class ClassDemo
    {
        static void Class1()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            WriteLine("24. 클래스");
            WriteLine("클래스는 struct와 비슷하게 다양한 변수들을 모아놓은 집합이다.");
            WriteLine("단, struct와는 달리 함수 또한 class 안에 담아서 사용할 수 있으며, 내부의 변수를 매개변수로 사용할 수 있다.");

            /*
             * 자주쓰는 내장 클래스
             * 1. String 클래스 : 문자열 처리와 관련한 속성과 메서드 등을 제공
             * 2. StringBuilder 클래스 : 대용량 문자열 처리 관련 클래스, System.Text 네임스페이스 내에 있다.
             * 3. Array 클래스 : 배열 관련 클래스
             */

            WriteLine("\n24.6. Environment 클래스를 이용해 프로그램 강제 종료");
            //Environment.Exit(0);// Environment.Exit를 사용하면 해당 프로그램은 종료된다. (exit(1)와 비슷하게 사용됨)

            WriteLine("출력될까요?(위의 Exit를 주석처리했음)");

            WriteLine("\n24.7. 환경변수");
            WriteLine(Environment.SystemDirectory); //시스템 폴더
            WriteLine(Environment.Version);         //닷넷 기준 버전
            WriteLine(Environment.OSVersion);       //운영체제 버전
            WriteLine(Environment.MachineName);     //컴퓨터 이름
            WriteLine(Environment.UserName);        //사용자 이름
            WriteLine(Environment.CurrentDirectory);//현재 폴더
            WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));//문서 폴더

            WriteLine("\n\n24.8. exe 파일 실행하기");
            WriteLine("1. 메모장 실행");
            Process.Start("Notepad.exe");
            WriteLine("2. 인터넷 실행");
            Process.Start("Explorer.exe", "https://www.naver.com");

            WriteLine("\n\n24.9. Random 클래스");
            Random random = new Random();// Random 클래스를 통해 난수 입력받기;
            WriteLine($"무작위 정수 : {random.Next()}");
            WriteLine($"0~4 내의 무작위 정수 : {random.Next(5)}");
            WriteLine($"1~10 이내의 무작위 정수 : {random.Next(1, 10)}");

            WriteLine("\n\n24.10. 프로그램 실행시간 구하기");
            timer.Stop();
            WriteLine("class 내에서 실행시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);
            WriteLine("class 내에서 실행시간 : {0}초", timer.Elapsed.TotalSeconds);
        }
        public static void Classoutput()
        {
            Class1();
        }
    }
}
