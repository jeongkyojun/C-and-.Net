using System;
using System.Net;
using static System.Console;

/*
 * 
 * C# 프로그래밍 5일차 2단원 C#기초 : 17강 ~ 19강
 * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
 *
 */
namespace task5._Cs_basic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Collection.show();
        }
    }

    class Collection
    {

        /// <summary>
        /// 19.7 특정 함수 설명문
        /// </summary>
        /// <param name="array">첫번째 배열, 1,3,5,7,9가 저장</param>
        /// <param name="array2">두번째 배열, 선언과 동시에 값 할당</param>
        /// <param name="gogoo">세번째 배열, 이차원 배열로, 구구단 값 저장</param>
        /// <returns>리턴값 없음</returns>
        /// 
        //위와 같이 XML문서 주석을 통해 함수에 대한 설명을 적을 수 있다.
        static void array()
        {
            WriteLine("18.1. 배열");
            WriteLine("배열은 하나의 데이터에 같은 자료형 여러개를 입력할 수 있다.");
            WriteLine("자료형[] 변수명 = new 자료형[배열크기]; 의 형식으로 배열을 선언할 수 있으며, 그 뒤 변수명[배열 번호] = 값; 의 형식으로 배열을 채울 수 있다.");
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;
            WriteLine("예시");
            for (int i = 0; i < 5; i++)
            {
                WriteLine("array[{0}] = {1}", i, array[i]);
            }

            //배열 선언과 동시에 값 할당
            int[] array2 = new int[5] { 9, 8, 7, 6, 5 };
            for (int i = 0; i < 5; i++)
            {
                WriteLine("array2[{0}] = {1}", i, array[i]);
            }

            //foreach문으로 표시한 배열
            foreach (int i in array2)
            {
                WriteLine("number {0}", i);
            }

            WriteLine("배열 안에 배열을 위치시켜 다차원 배열 또한 가능하다.");
            int[,] gogoo = new int[9, 9]; // c나 c++과는 다르게, 다차원 배열의 구분을 콤마(,)로 구분한다.
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    gogoo[i - 1, j - 1] = i * j;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    WriteLine("{0} x {1} = {2}", i + 1, j + 1, gogoo[i, j]);
                }
            }

            // 그 외에도 배열.getLength(차수) 로 배열에서 원하는 차수의 길이를 확인할 수도 있으며,
            // 배열.Rank 로 차수 길이 또한 확인할 수 있다.

            //또한, 기존 c나 c++에서 쓰던것처럼, var[][] array = new var[3][]; 의 예처럼 가변 배열을 선언할 수도 있다.
        }

        static void Func()
        {
            WriteLine("19. 함수");
            WriteLine("지금 이렇게 static (자료형) 함수명(매개변수){} 의 방식으로 사용하는것이 함수이다.");
            WriteLine("함수에 대한 설명은 생략하겠다.");
        }

        //함수 오버로드
        static int plus(int a)
        {
            return a++;
        }
        static int plus(int a,int b)
        {
            return a+b;
        }
        static int plus(int a, int b, int c)
        {
            return a + b + c;
        }
        //위와 같이 같은 이름으로 다른 변수를 사용할 수 있게 하는것이 오버로드이다.

        public static void show()
        {
            array();
            Func();
        }
    }
}
