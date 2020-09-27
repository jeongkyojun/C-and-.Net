using System;
using System.Collections.Generic;
using static System.Console;

/*
* 
* C# 프로그래밍 11일차 3단원 C# 활용 : 31강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/


namespace task12._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AlgorithmDemo.outputAlgorithm();
        }
    }
    class AlgorithmDemo
    {
        static void AlgorithmMain()
        {
            WriteLine("31. 알고리즘 및 절차지향 프로그래밍\n");
        }
        static void AlgorithmSum()
        {
            WriteLine("31.2. 합계 알고리즘");
            int[] score = new int[5];
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i=0;i<5;i++)
            {
                try
                {
                    Write("숫자 입력 >>");
                    score[i] = Convert.ToInt32(ReadLine());
                    WriteLine($"점수 {i + 1} : {score[i]}");
                    if(max<score[i])
                    {
                        max = score[i];
                    }
                    if(min>score[i])
                    {
                        min = score[i];
                    }
                    sum += score[i];
                }
                catch(Exception e)
                {
                    WriteLine($"error : 숫자가 아닙니다 (errorcode : {e})");
                    i--;
                }
            }
            WriteLine($"합계 : {sum}");
            AlgorithmCount(score);
            AlgorithmAverage(sum, score);
            WriteLine("\n\n31.5/6. 최대/최솟값 구하기");
            WriteLine($"위의 입력 과정에서 구함. max : {max}, min : {min}");
            AlgorithmNear(score);
            AlgorithmRank(score);
        }

        static void AlgorithmCount(int[] score)
        {
            WriteLine("\n\n31.3 Count 알고리즘");
            WriteLine("위의 배열 score의 개수를 출력");
            int count = 0;
            for(int i=0;i<score.Length;i++)
            {
                count++;
            }
            WriteLine($"배열 내 원소의 개수 : {count}");
        }
        static void AlgorithmAverage(int sum,int[] score)
        {
            WriteLine("\n\n31.4 평균 알고리즘");
            WriteLine("위의 배열 score의 개수와 sum을 이용해 평균 출력");
            double average = sum / score.Length;
            WriteLine($"배열 내 원소의 개수 : {average}");
        }

        static void AlgorithmNear(int[] score)
        {
            WriteLine("\n\n31.7. 근사값 구하기");
            int min = int.MaxValue;
            List<int> point = new List<int>();
            try
            {
                int number = Convert.ToInt32(ReadLine());
                for(int i=0;i<score.Length;i++)
                {
                    int set = Math.Abs(number - score[i]);
                    if(min>set)
                    {
                        point.Clear();
                        min = set;
                        point.Add(i);
                    }
                    else if(min==set)
                    {
                        point.Add(i);
                    }
                }
                Write($"가장 입력한 값에 근접한 수(들)는 ");
                foreach (int i in point)
                {
                    Write($"{score[i]}\t");
                }
                WriteLine("이다.");
            }
            catch(Exception e)
            {
                WriteLine($"error : errorcode : {e}");
            }
        }

        static void AlgorithmRank(int[] score)
        {
            WriteLine("\n\n31.8. 순위 구하기");
            WriteLine("score에서 등수 정하기");
            Dictionary<int, int> ranking = new Dictionary<int, int>();
            try
            {
                for(int i=0;i<score.Length;i++)
                {
                    ranking[score[i]] = 1;
                    for(int j=0;j<i;j++)
                    {
                        if(score[j]<score[i])
                        {
                            ranking[score[j]]++;
                        }
                        else
                        {
                            ranking[score[i]]++;
                        }
                    }
                }
                foreach(int i in ranking.Keys)
                {
                    WriteLine($"{i} : {ranking[i]} 등");
                }
            }
            catch (Exception e)
            {
                WriteLine($"error : errorcode : {e}");
            }
        }
        /*
         * 31.9 정렬 알고리즘
         * bubble sort , heap sort, merge sort, quick sort 등이 있으며, 책의 알고리즘은 버블정렬로 나와있다.
         * 나중에 한번에 알아보기 위해 이번에는 간단하게 식만 적어놓겠다.
         * int temp;
         * if(score[i]>score[i+1]){ temp = score[i]; score[i] = score[i+1]; score[i+1] = temp; }
         */

        /*
         * 31.10 탐색 알고리즘
         * 이진탐색과 순차탐색이 있는데, 순차탐색은 처음부터 순차적으로 찾는 방법이며 O(n)의 시간복잡도를 가진다.
         * 이진탐색은 중간을 찾아 조건에 맞지않는 절반을 버리는 것을 반복하면서 찾는 방법으로, O(log n)의 시간복잡도를 갖나, 정렬되어있어야 한다는 제한점이 존재한다.
         * 책에서는 이진탐색을 이용하는 것을 보여준다.
         * 
         * while(low > high)
         * {
         *      int mid = (low + high) /2;
         *      if(score[mid] > number)
         *          high = mid-1;
         *      else if(score[mid] < number)
         *          low = mid+1;
         *      else
         *      {
         *          WriteLine("탐색 성공!");
         *          break;
         *      }
         * }
         */
        public static void outputAlgorithm()
        {
            AlgorithmMain();
            AlgorithmSum();
            
        }
    }
}
