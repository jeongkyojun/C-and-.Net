using System;
using System.Collections.Generic;
using static System.Console;


/*
* 
* C# 프로그래밍 27일차 4단원 C# 확장기능 : 57강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task28_Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CRUDDemo crudDemo = new CRUDDemo();
            crudDemo.output();
            RepositoryPatternDemo RP = new RepositoryPatternDemo();

            RP.output();
        }
    }

    /// <summary>
    /// 모델 클래스
    /// </summary>
    public class SignBase
    {
        public int SignId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    /// <summary>
    /// 리포지토리 클래스
    /// </summary>
    public class SignRepository
    {
        public List<SignBase> GetAll()
        {
            var signs = new List<SignBase>()
            {
                new SignBase() { SignId = 1, Email = "a@a.com", Password = "1234" },
                new SignBase() { SignId = 2, Email = "b@b.com", Password = "2345" },
                new SignBase() { SignId = 3, Email = "c@c.com", Password = "3456" }
            };
            return signs;
        }
    }
    /// <summary>
    /// 컨텍스트 클래스
    /// </summary>
    public class SignContext
    {
        public List<SignBase> Signs
        {
            get
            {
                return (new SignRepository()).GetAll();
            }
        }
    }

    class CRUDDemo
    {
        void Head()
        {
            WriteLine("57.인메모리 데이터베이스 프로그래밍");
            WriteLine("인메모리 데이터베이스\n" +
                "");
        }
        void CRUDMain()
        {
            WriteLine("CRUD : Create, Read, Update, Delete");
            var signs = (new SignContext()).Signs;
            foreach(var sign in signs)
            {
                WriteLine($"{sign.SignId} - {sign.Email} - {sign.Password}");
            }
        }
        public void output()
        {
            Head();
            CRUDMain();
        }
    }


    // 리포지토리 패턴 사용하기
    public interface ITableRepository
    {
        string getAll();
    }
    public class TableInMemoryRepository:ITableRepository
    {
        public string getAll()
        {
            return "인-메모리 데이터베이스 사용";
        }
    }
    public class TableSqlRepository : ITableRepository
    {
        public string getAll()
        {
            return "SQL Server 데이터베이스 사용";
        }
    }
    public class TableXmlRepository : ITableRepository
    {
        public string getAll() => "XML 데이터베이스 사용";
    }

    class RepositoryPatternDemo
    {
        public void output()
        {
            // SQL, InMemory, XML 등 넘어오는 값에 따른 인스턴스 생성(저장소 결정)
            string repo = "SQL";

            ITableRepository repository;
            if(repo == "InMemory")
            {
                repository = new TableInMemoryRepository();
            }
            else if(repo == "XML")
            {
                repository = new TableXmlRepository();
            }
            else
            {
                repository = new TableSqlRepository();
            }
            WriteLine(repository.getAll());
        }
    }
}
