using System;

/*
 * 
 * C# 프로그래밍 6일차 2단원 C#기초 : 20강. C# 인터랙티브
 * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
 *
 */

namespace task6._Cs_Interactive
{
    /*
     * C# 인터랙티브 : 보기 - 다른창 -> C# 대화창 ( C# interactive ) 를 켜서 대화형 형식으로 활용하는 도구모음
     * ctrl + q 를 이용해 검색해도 된다.
     * 
     * #help를 치면 도움말 확인 가능
     * #cls 또는 #clear 로 커맨드창 비우기(초기화) 가능
     
    
    - C# 인터랙티브에서 윈도우 폼 띄우기 - 
     * #r "System.Windows.Forms"
     * using System.Windows.Forms;
     * var f = new Form { BackColor = System.Drawing.Color.Yellow };
     * f.ShowDialog();

     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
