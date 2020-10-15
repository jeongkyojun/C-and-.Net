using System;
using static System.Console;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
/*
* 
* C# 프로그래밍 29일차 4단원 C# 확장기능 : 58강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task30_Cs_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetFileNameDemo filenameDemo = new GetFileNameDemo();
            filenameDemo.output();

            WriteLine("\n----- 파일 저장 -----\n");
            StreamWriteLineDemo filestreamDemo = new StreamWriteLineDemo();
            filestreamDemo.output();

            WriteLine("\n----- 파일 출력 -----\n");
            StreamReaderReadToEndDemo fileRead = new StreamReaderReadToEndDemo();
            fileRead.output();

            WriteLine("\n----- 파일 정보 읽기 -----\n");
            FileAndFileInfo fileinfo = new FileAndFileInfo();
            fileinfo.output();

            WriteLine("\n----- 폴더 정보 읽기 -----\n");
            DirectoryAndDirectoryInfo dirInfo = new DirectoryAndDirectoryInfo();
            dirInfo.output();

            WriteLine("\n----- 파일을 읽어 컬렉션 데이터에 저장하기 -----\n");
            CheckToCollection ctc = new CheckToCollection();
            ctc.output();
        }
    }

    #region 파일 경로 구하기
    class GetFileNameDemo
    {
        void Head()
        {
            WriteLine("58. 스트림과 파일 입출력 맛보기");
        }
        void GetFileNameMain()
        {
            // [1] 입력
            string dir= "C:\\Website\\RedPlus\\images\\test.gif";
            string fullName = String.Empty;
            string name = "";
            string ext = name;

            // [2] 처리
            fullName = dir.Substring(dir.LastIndexOf('\\')+1);
            name = fullName.Substring(0, fullName.LastIndexOf('.'));
            ext = fullName.Substring(fullName.LastIndexOf('.') + 1);

            // [3] 출력
            WriteLine($"전체 파일 이름 : {fullName}");
            WriteLine($"순수 파일 이름 : {name}");
            WriteLine($"확장자 : {ext}");

            // [4] Path 클래스로 파일이름 및 확장자, 폴더 정보 얻기
            // using System.IO 사용
            WriteLine("\n\nPath 클래스를 이용한 경로 확인");
            WriteLine($"전체 파일 이름 : {Path.GetFileName(dir)}");
            WriteLine($"순수 파일 이름 : {Path.GetFileNameWithoutExtension(dir)}");
            WriteLine($"확장자 : {Path.GetExtension(dir)}");
            WriteLine($"경로 : {Path.GetDirectoryName(dir)}");
            WriteLine($"파일 전체 경로 : {Path.GetFullPath(dir)}");
        }
        public void output()
        {
            Head();
            GetFileNameMain();
        }
    }
    #endregion

    #region 파일쓰기
    class StreamWriteLineDemo
    {
        string data;
        string dir;

        public StreamWriteLineDemo()
        {
            data = "안녕하세요.\r\n반갑습니다." + Environment.NewLine + "또 만나요.";
            dir = "D:\\Git\\C#\\task30_Cs_extensions\\task30_Cs_extensions\\Test.txt";
        }

        public StreamWriteLineDemo(string dir,string data)
        {
            this.data = data;
            this.dir = dir;
        }
        void StreamWriteLineMain()
        {
            
            // [1] StreamWriter 클래스를 사용하여 파일 생성
            // C 드라이브에 Temp 폴더를 미리 생성해야 함
            StreamWriter sw = new StreamWriter(dir);

            // [2] Write() 메서드 : 저장
            sw.WriteLine(data);
            WriteLine("파일 저장 완료");

            // [3] StreamWrite 개체를 생성했으면 반드시 닫을것!
            sw.Close();
            
            // [4] 메모리 해제
            sw.Dispose();
        }
        public void output()
        {
            StreamWriteLineMain();
        }
    }
    #endregion

    #region 파일읽기
    class StreamReaderReadToEndDemo
    {
        string dir;

        public StreamReaderReadToEndDemo()
        {
            dir = "D:\\Git\\C#\\task30_Cs_extensions\\task30_Cs_extensions\\Test.txt";
        }

        public StreamReaderReadToEndDemo(string dir)
        {
            this.dir = dir;
        }
        void StreamWriteLineMain()
        {

            // [1] StreamWriter 클래스를 사용하여 파일 생성
            // C 드라이브에 Temp 폴더를 미리 생성해야 함
            StreamReader sr = new StreamReader(dir);

            // [2] ReadToEnd 메서드 : 텍스트 내용을 읽어 콘솔에 출력
            WriteLine("{0}", sr.ReadToEnd());

            // [3] 파일을 닫기
            sr.Close();

            // [4] 메모리 해제
            sr.Dispose();
        }
        public void output()
        {
            StreamWriteLineMain();
        }
    }
    #endregion

    #region 텍스트 파일 정보 얻기
    class FileAndFileInfo
    {
        string dir;
        string dir2;
        public FileAndFileInfo()
        {
            dir = "D:\\Git\\C#\\task30_Cs_extensions\\task30_Cs_extensions\\Test.txt";
            dir2 = "D:\\Git\\C#\\task30_Cs_extensions\\task30_Cs_extensions\\Test2.txt";
        }

        public FileAndFileInfo(string dir,string dir2 = "D:\\Git\\C#\\task30_Cs_extensions\\task30_Cs_extensions\\Test2.txt")
        {
            this.dir = dir;
            this.dir2 = dir2;
        }

        void FileInfoMain()
        {
            // [1] File 클래스 : 정적 멤버 제공
            if(File.Exists(dir)) // 파일 존재시
            {
                WriteLine("{0}", File.GetCreationTime(dir));
                File.Copy(dir, dir2,true); // 파일 복사 테서트
            }

            // [2] FileInfo 클래스 : 인스턴스 멤버 제공
            FileInfo fi = new FileInfo(dir);
            if(fi.Exists) // 파일 존재시
            {
                WriteLine($"{fi.FullName}"); // 파일 이름 출력
            }
        }
        public void output()
        {
            FileInfoMain();
        }
    }
    #endregion

    #region 폴더 정보 얻기
    class DirectoryAndDirectoryInfo
    {
        string dir;
        public DirectoryAndDirectoryInfo()
        {
            dir = "D:\\";
            
        }

        void DirectoryInfoMain()
        {
            if(Directory.Exists(dir))
            {
                WriteLine("[1] D 드라이브의 모든 폴더 목록 출력");
                foreach (string folder in Directory.GetDirectories(dir))
                {
                    WriteLine($"{folder}");
                }
            }

            DirectoryInfo di = new DirectoryInfo(dir+ "Git\\C#\\task30_Cs_extensions\\task30_Cs_extensions\\");
            if(di.Exists)
            {
                WriteLine("[2] 해당 프로젝트 내의 모든 파일 목록 출력");
                foreach (var file in di.GetFiles())
                {
                    WriteLine($"{file}");
                }
            }
        }
        public void output()
        {
            DirectoryInfoMain();
        }
    }

    #endregion


    #region 텍스트 데이터를 컬렉션 데이터로 가져오기
    public class Record
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string AuthCode { get; set; }
    }
    class CheckToCollection
    {
        string dir;
        public CheckToCollection()
        {
            dir = "D:\\Git\\C#\\task30_Cs_extensions\\task30_Cs_extensions\\src.txt";

        }
        void CheckToCollectionMain()
        {
            string[] lines = File.ReadAllLines(dir,System.Text.Encoding.Default);
            foreach(var line in lines)
            {
                WriteLine(line);
            }

            List<Record> records = new List<Record>();
            foreach(var line in lines)
            {
                string[] splitData = line.Split(',');
                records.Add(new Record
                {
                    Name = splitData[0],
                    PhoneNumber = splitData[1],
                    BirthDate = Convert.ToDateTime(splitData[2]),
                    AuthCode = splitData[3]
                });
            }
            WriteLine(records[0]?.Name ?? "데이터가 없습니다.");
        }
        public void output()
        {
            CheckToCollectionMain();
        }
    }
    #endregion
}
