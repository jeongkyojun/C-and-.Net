using System;
using static System.Console;

/*
* 
* C# 프로그래밍 13일차 3단원 C# 활용 : 34강 ~ 35강
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task14._using_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FieldDemo.output();
            ConstructorDemo construct = new ConstructorDemo();
            ConstructorDemo construct2 = new ConstructorDemo(3);
        }
    }

    class FieldDemo
    {
        static string FieldVariable = "34. 필드 만들기";

        static void FieldDemoMain()
        {
            WriteLine(FieldVariable);
            WriteLine("\n\n위의 제목은 전역변수로 선언한 것이다. ");
            WriteLine("\n 전역변수와 지역변수\n");
            WriteLine("지역 변수란, 클래스 내에서 만들어낸 변수로, 해당 클래스 내에서만 적용할 수 있다.");
            WriteLine("전역변수란, 클래스 밖에서 만들어낸 변수로, 특정 클래스 뿐만이 아닌, 다른 클래스와 같이 공유할 수 있다.");
        }
        static void AccessDemo()
        {
            WriteLine("\n\n\n34.2. 액세스 한정자\n");
            WriteLine("public : 액세스 제한 없음");
            WriteLine("protected : 현재 클래스 또는 상속 관계에서만 액세스 허용");
            WriteLine("private : 현재 클래스 내에서만 액세스 허용");
        }

        public static void output()
        {
            FieldDemoMain();
            AccessDemo();
        }
    }
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            WriteLine("\n\n\n35. 생성자");
            WriteLine("클래스를 선언할 때, 가장 먼저 실행되면서 클래스의 생성을 알리는 것이 생성자이다.");
        }
        public ConstructorDemo(int number)
        {
            WriteLine("\n또한, 같이 매개변수를 넣어서 생성자를 만들 수도 있다. 단, 이런 경우 매개변수 없는 생성자를 사용할 것이라면 따로 선언해주어야 한다.");
            WriteLine("이러한 작업을 '생성자 오버로드' 라고 한다.");
            WriteLine($"매개변수 : {number}");
        }
        ~ConstructorDemo()
        {
            WriteLine("\n\n\n36. 소멸자");
            WriteLine("클래스가 선언되고, 작동된 뒤, 프로그램이 종료되기 전에 클래스를 반환하는 메서드가 바로 소멸자이다.");
            WriteLine("이와 같이 소멸자는 프로그램이 종료되기 전에 실행되면서 클래스를 반환한다.");

            WriteLine("위 프로그램은 닷넷 코어로서, 프로그램 종료 후 소멸자가 실행되기 때문에 출력되지는 않지만, " +
                "닷넷 프레임워크의 경우는 소멸자 생성 후 종료되기 때문에 소멸자 출력을 확인할 수 있다.");
        }
    }
}
