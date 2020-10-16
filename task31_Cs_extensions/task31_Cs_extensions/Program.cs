using System;
using static System.Console;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Net;

/*
* 
* C# 프로그래밍 30일차 4단원 C# 확장기능 : 59강 ~ 60강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task31_Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            XElementDemo xmldemo = new XElementDemo();
            xmldemo.output();
            WriteLine("\n\n");
            HttpClientDemo httpdemo = new HttpClientDemo();
            httpdemo.output();
            Thread.Sleep(1000);
            WriteLine("\n");
            WebClientDemo webdemo = new WebClientDemo();
            webdemo.output();
            Thread.Sleep(10000);
        }
    }
    #region XElement 클래스 사용하여 XML 생성 및 가공
    class XElementDemo
    {
        static void XElementHead()
        {
            WriteLine("59. XML과 JSON 맛보기");
        }
        static void XElementMain()
        {
            // [1] XML 요소 생성
            XElement category = new XElement("Menus",
                new XElement("Menu", "책"),
                new XElement("Menu", "강의"),
                new XElement("Menu", "컴퓨터")
                );
            WriteLine(category);

            // [2] XML 요소 가공
            XElement newCategory = new XElement("Menus",
                from node in category.Elements()
                where node.Value.ToString().Length>=2
                select node
                );
            WriteLine(newCategory);
        }
        public void output()
        {
            XElementHead();
            XElementMain();
        }
    }
    #endregion

    #region HttpClient 클래스로 웹 데이터 가져오기
    class HttpClientDemo
    {
        void HttpClientHead()
        {
            WriteLine("60. 네트워크 프로그래밍 맛보기");
        }
        static async Task HttpClientMain()
        {
            // [1] HttpClient 개체 생성
            HttpClient httpClient = new HttpClient();

            // [2] GetAsync() 메서드 호출
            HttpResponseMessage httpResponseMessage =
                await httpClient.GetAsync("http://www.microsoft.com/");

            // [3] HTML 가져오기
            string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

            // [4] 출력
            WriteLine(responseBody);
        }
        public void output()
        {
            HttpClientHead();
            HttpClientMain();
        }
    }
    #endregion

    #region WebClient 클래스로 웹 데이터 읽어오기
    class WebClientDemo
    {
        void WebClientMain()
        {
            WebClient client = new WebClient(); //using System.Net 사용

            string google = client.DownloadString("http://www.google.co.kr");
            WriteLine("google : " + google.Substring(0, 10));//20 글자만 가져오기

            string naver = client.DownloadString("http://www.naver.com");
            WriteLine("naver : " + naver.Substring(0, 10));
            WriteLine("------------------------------------");
            client.DownloadStringAsync(new Uri("http://www.dotnetkorea.com"));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
            Thread.Sleep(3000);//3초간 대기
        }
        private static void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string r = e.Result.Replace("\n", "").Substring(0, 10);
            WriteLine($"DotNetKorea : {r}");
        }
        public void output()
        {
            WebClientMain();
        }
    }
    #endregion
}
