using System;
using static System.Console;
using System.Text;
using System.Collections;
/*
* 
* C# 프로그래밍 8일차 3단원 C# 활용 : 25강 ~ 27강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task9._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringPerformance.outputStringPerformance();
            StackNote.outputStackNote();
        }
    }
    
    class StringPerformance
    {
        static void StringPerformanceStart()
        {
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("25. 문자열 다루기");
            WriteLine("-----------------------------------------------------------------------");
        }
        static void StringPerformanceMain()
        {
            /*
             * 문자열 다루기
             * string 클래스 외에 사용하는 속성 및 메서드
             * Length           : 문자열 길이 값 반환
             * ToUpper/ToLower  : 문자열 모두 대/소문자 변환
             * Trim             : 문자열 양쪽 공백 제거
             * Replace          : 원본 문자열을 대상 문자열로 변경
             * Substring        : 지정된 문자열 인덱스로부터 길이만큼 반환
             * 
             */
            DateTime start = DateTime.Now;

            string msg = "";
            for(int i=0;i<10000;i++)
            {
                msg += "안녕하세요"; //msg문자 뒤에 안녕하세요 붙이기
            }

            DateTime end = DateTime.Now;
            double exec = (end - start).TotalMilliseconds;
            WriteLine("   1. +를 이용해 문자열을 붙였을 때 반복시간 : "+exec+" 밀리초");
        }

        static void StringPerformanceMain2()
        {
            DateTime start = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<10000;i++)
            {
                sb.Append("안녕하세요");
            }

            DateTime end = DateTime.Now;
            double exec = (end - start).TotalMilliseconds;
            WriteLine("   2. append를 이용해 문자열을 붙였을 때 반복시간 : "+exec+" 밀리초");
        }

        static void StringPerformanceEnd()
        {
            WriteLine("\n위와같이 +로 문자열을 붙이는 것보다 append로 문자열을 붙이는 것이 속도가 더 빠르다.");
        }
        public static void outputStringPerformance()
        {
            StringPerformanceStart();
            StringPerformanceMain();
            StringPerformanceMain2();
            StringPerformanceEnd();
        }
    }
    //26. 예외처리는 생략

    class StackNote
    {
        static void StackNoteStart()
        {
            WriteLine("\n\n-----------------------------------------------------------------------");
            WriteLine("27. 컬렉션 사용");
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("C++에서의 STL과 같이 리스트, 스택, dictionary(map) 등의 다양한 형태를 활용하는 것");
        }
        static void StackNoteStack()
        {
            
            WriteLine("\n\nStack : 입력받고, 최근에 입력받은 순서대로 출력한다. (LIFO)");
            Stack stack = new Stack();
            for(int i=0;i<5;i++)
            {
                stack.Push((i + 1) + "번째");
                WriteLine((i + 1) + "번째 입력");
            }
            for(int i=0;i<5;i++)
            {
                WriteLine(stack.Pop()+" 출력");
            }
        }
        static void StackNoteQueue()
        {

            WriteLine("\n\nQueue : 입력받고 입력받은 순서대로 출력한다. (FIFO)");
            Queue queue = new Queue();
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue((i + 1) + "번째");
                WriteLine((i+1) + "번째 입력");
            }
            for (int i = 0; i < 5; i++)
            {
                WriteLine(queue.Dequeue() + " 출력");
            }
        }
        public static void outputStackNote()
        {
            /*
             * 콜렉션 종류
             * Stack
             * Queue
             * ArrayList : 리스트, 배열과 비슷한 방식으로 사용
             * Array : 배열을 사용할때 유용한 기능 제공
             * Hashtable : 정수 인덱스 및 문자열 인덱스를 사용 가능
             */
            StackNoteStart();
            StackNoteStack();
            StackNoteQueue();
        }
    }
}
