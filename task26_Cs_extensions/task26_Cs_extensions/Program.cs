using System;
using static System.Console;
using System.Threading;
using System.Diagnostics;
/*
* 
* C# 프로그래밍 25일차 4단원 C# 확장기능 : 54강 ~ 55강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/
namespace task26_Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ThreadDemo threademo = new ThreadDemo();
            threademo.output();
            ThreadDemo2 td2 = new ThreadDemo2();
            td2.output();
        }
    }

    class ThreadDemo
    {
        static void Other()
        {
            WriteLine("[?] 다른 작업자 일 실행");
            Thread.Sleep(1000); //  1초간 대기(지연)
            WriteLine("[?] 다른 작업자 일 종료");
        }

        void ThreadHead()
        {
            WriteLine("56. 스레드");
            WriteLine("스레드란, 운영체제가 프로세서 시간을 할당하는 기본 단위로, " +
                "동시에 여러 스레드를 통해 서로 다른 작업을 동시에 수행할 수 있다.");
            WriteLine("Ex)");
        }
        void ThreadMain()
        {
            WriteLine("[1] 메인 작업자 일 시작");
            var other = new Thread(new ThreadStart(Other)); // Thread 를 실행할 때 Thread 를 이용한다.
            other.Start();
            WriteLine("[2] 메인 작업자 일 종료");
        }
        public void output()
        {
            ThreadMain();
        }
    }

    class ThreadDemo2
    {
        private static void Ide()
        {
            Thread.Sleep(5000);
            WriteLine("[3] IDE : Visual Studio"); // IDE : Integrated Development Environment (통합 개발 환경)
        }
        private static void Sql()
        {
            Thread.Sleep(4000);
            WriteLine("[2] DBMS : SQL Server");
        }
        private static void Win()
        {
            Thread.Sleep(3000);
            WriteLine("[1] OS : Windows Server");
        }

        static void ThreadMain()
        {
            WriteLine("Thread를 실행하기 위한 함수들을 ThreadStart를 이용해 다른 이름으로 저장해놓을 수 있다.");
            ThreadStart ts1 = new ThreadStart(Win);
            ThreadStart ts2 = new ThreadStart(Sql);
            //ThreadStart ts3 = new ThreadStart(Ide);
            Thread t1 = new Thread(ts1);
            var t2 = new Thread(ts2);
            var t3 = new Thread(new ThreadStart(Ide));
            t1.Start();
            t2.Start();
            t3.Start();
            //Process.Start("IExplore.exe"); //프로세스 이름이 일치하지 않아 주석처리
            Process.Start("Notepad.exe"); // 메모장 실행
        }
        public void output()
        {
            ThreadMain();
        }
    }

    class ThreadDemo3
    {

        /*
         * 그 외
         * 1. 스레드 동기화
         * lock(this(메서드))
         * {
         * 
         *      //하고자 하는 행동
         *
         * }
         * 구문을 통해 this에 속하는 메서드를 동기화하여 해당 메서드에 대한 다른 스레드의 접근을 막을수 있다.
         * 자세한 설명 : https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/lock-statement
         * (마이크로소프트 docs)
         * 
         * 2. 병렬처리
         * Parallel 클래스를 이용해 그 안의 For나 ForEach 메서드를 이용하여 
         * 병렬로 컴퓨터 자원을 최대한 사용해 빠르게 작업을 처리할 수 있다.
         * Ex ) Parallel.For(0,200_000,(i)=>{Console.WriteLine(i);});
         * 위 구문을 이용하면 0부터 200,000까지의 숫자가 무작위적으로 한번씩 출력된다.
         * 위의 병렬처리 구문은 CPU를 최대한으로 사용하게 된다. (TPL 라이브러리 참조)
         * 자료 : https://docs.microsoft.com/ko-kr/dotnet/standard/parallel-programming/data-parallelism-task-parallel-library
         * (마이크로소프트 docs - 데이터 병렬처리 부분)
         */
    }
}
