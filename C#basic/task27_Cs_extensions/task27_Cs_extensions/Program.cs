using System;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;
using System.Net.Http;
using System.Linq;
/*
* 
* C# 프로그래밍 26일차 4단원 C# 확장기능 : 56강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task27_Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SyncDemo async = new SyncDemo();
            async.output();
            WriteLine("[Main]비동기 메서드 호출위한 Main문 3초간 일시정지");
            Thread.Sleep(3000); // main문이 기다리지 않고 종료되기 때문에 3초간 일시정지 시켜놓음
            AsyncAwaitDescription async2 = new AsyncAwaitDescription();
            async2.output();
            WriteLine("[Main]비동기 메서드 호출위한 Main문 3초간 일시정지");
            Thread.Sleep(3000); // main문이 기다리지 않고 종료되기 때문에 3초간 일시정지 시켜놓음
            WeatherForecastApp async3 = new WeatherForecastApp();
            async3.output();
        }
    }

    class SyncDemo
    {
        static void Sum(int a, int b) => WriteLine($"{a} + {b} = {a + b}");
        void SyncHead()
        {
            WriteLine("56. 비동기 프로그래밍");
            /*
             * 동기와 비동기
             * 동기 : 프로그램이 순서대로 실행됨
             * 비동기 : 메서드 여러개를 동시에 실행 또는 대기 시점을 변경하여 순서를 재정의함
             */
        }
        void SyncMain()
        {
            WriteLine("-동기 프로그래밍");
            WriteLine("임의로 만든 함수 Sum은 호출한 순서대로 실행된다.");
            Sum(3, 5);
            Sum(5, 7);
            Sum(7, 9);
        }
        async Task SyncMain2()
        {
            WriteLine("-비동기 메서드");
            await Task.Delay(1000);
            WriteLine("3...");
            await Task.Delay(1000);
            WriteLine("2...");
            await Task.Delay(1000);
            WriteLine("1...");
            await Task.Delay(1000);
            WriteLine("비동기 메서드는 이와같이 시간 조절이 가능하다.");
        }
        static async Task SyncMain3()
        {
            WriteLine("비동기 메서드 출력 예제");
            using (var client = new HttpClient())
            {
                var r = await client.GetAsync(
                    "https://dotnetnote.azurewebsites.net/api/WebApiDemo");
                var c = await r.Content.ReadAsStringAsync();

                Console.WriteLine("출력값 : "+c);
            }
        }
        public async Task output()
        {
            SyncHead();
            SyncMain();
            SyncMain2();
            WriteLine("[--class SyncDemo--]비동기 메서드 호출위한 class 5초간 일시정지");
            Thread.Sleep(5000);
            await SyncMain3();
        }
    }
    class AsyncAwaitDescription
    {
        static async void DoPrint()
        {
            await PrintNumberAsync();
        }
        static async Task PrintNumberAsync()
        {
            await Task.Run(() =>
            {
                for (int i=0;i<100;i++)
                {
                    WriteLine(i + 1);
                }
            });
        }
        public void output()
        {
            WriteLine("동기 메서드 내에서 비동기 메서드를 호출하기 위해서는 Run() 함수를 이용한다.");
            Thread.Sleep(500);
            Task.Run(() => DoPrint()); //1,2,3
            WriteLine("[?] async await 사용 예제");
            Thread.Sleep(1); // 1 밀리초 일시 정지
        }
    }

    class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }
    class WeatherForecastService
    {
        private static string[] summaries = new[]
        {
            "Freezing","Bracing","Chilly","Cool","Mild",
            "Warm","Balmy","Hot","Sweltering","Scorching"
        };
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(idx => new WeatherForecast
            {
                Date = startDate.AddDays(idx),
                TemperatureC = rng.Next(-20, 55),
                Summary = summaries[rng.Next(summaries.Length)]
            }).ToArray());
        }
    }
    class WeatherForecastApp
    {
        public async Task output()
        {
            var service = new WeatherForecastService();
            var forecasts = await service.GetForecastAsync(DateTime.Now);

            WriteLine("Date\tTemp. (C)\tTemp. (F)\tSummary");
            foreach(var f in forecasts)
            {
                WriteLine($"{f.Date.ToShortDateString()}\t" +
                    $"{f.TemperatureC}\t{f.TemperatureF}\t{f.Summary}");
            }
        }
    }
}
