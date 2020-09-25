using System;
using static System.Console;

/*
 * 
 * C# 프로그래밍 2일차 2단원 C#기초 : 5강~8강
 * Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
 *
 */

namespace task2._Cs_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // #5.1. 자료형 사용하기
            variable.var();

            // #5.2. 리터럴 사용하기
            Literal.lit();
            //5.3은 5.1과 동일하므로 생략 , 5.4와 5.5, 5.6은 5.1에 합하여 적용

            //7.2 문자열 사용 및 보간법
            MultiLineString.MLS();

            //7.5 닷넷 데이터 형식
            DotNetVariable.DNV();

            //8.1 입력 및 형식변환
            InputName.Input();

            //8.3 이진수 다루기
            BinaryString.Binary();

            //8.4 var 키워드
            VarInput.Varfunc();
        }
    }

    class Line_set_up
    {
        public static void setLine()
        {
            WriteLine("-----------------------------------------");
        }
    }

    class variable
    {
        public static void var()
        {
            int number;
            number = 7;
            int[] numbers = { 10, 20, 30 };
            const int Constnum = 100;// 상수는 변화하지 않는 값을 넣는데 사용한다.
            Line_set_up.setLine();
            WriteLine("variable");
            Line_set_up.setLine();
            Console.WriteLine(number);
            Console.WriteLine("{0}", number);
            WriteLine("{0},{1},{2}", numbers[0], numbers[1], numbers[2]);
            WriteLine("const number 'Constnum' : {0}", Constnum);
            Line_set_up.setLine();
        }
    }
    class Literal
    {
        public static void lit()
        {
            Line_set_up.setLine();
            WriteLine("Literal");
            Line_set_up.setLine();
            Console.WriteLine(1234);// 정수 리터럴
            Console.WriteLine(3.14f);//실수 리터럴
            Console.WriteLine('A');//문자 리터럴
            Console.WriteLine("Hello");//문자열 리터럴
            Line_set_up.setLine();
        }
    }

    /*
 * 숫자 데이터 형식
 * '정수 데이터 형식' 과 '실수 데이터 형식' 으로 나뉘어 있다.
 * 
 * 정수 데이터 형식은 부호가 있는 signed와 부호가 없이 모두 양수취급받는 unsigned로 나뉘어 진다.
 * -부호 있는 정수 : sbyte (SByte), short (Int16), int (Int32), long(Int64)
 * -부호 없는 정수 : byte (Byte), ushort (UInt16), uint (UInt32), uling (UInt64) [여기서 괄호 안의 단어는 닷넷 형식]
 * 닷넷형식에서 Int뒤의 숫자는 비트의 숫자를 나타낸다.
 * ex) Int32 = 32비트 -> 범위 : -2의 31제곱 ~ 2의 31제곱-1(약 -21억 ~ 21억)
 * byte의 경우 8비트이다. (sbyte : -127~127, byte : 0~255)
 * 부호가 없는 정수 자료형의 경우 범위가 양의 쪽으로 이동하므로 양의 범위에 한해서 *2배가 된다.(음의 범위는 0이 된다.)
 * 
 * 실수 데이터 형식은 부동소수점 데이터 형식과 10진 방식을 다루는 데이터 형식인 float, double, decimal이 있다.
 * double과 float는 부동소수점 방식, decimal은 소수 28자리 정도까지의 범위를 다루는 10진 방식이다.
 * 
 * 
 * 문자 데이터 형식
 * 문자는 char를 사용하며 따옴표('')를 사용하여 나타낸다.
 * 
 * 문자열은 string을 사용하며, 큰따옴표("")를 사용하여 나타낸다.
 * 
 */

    class MultiLineString 
    {
        public static void MLS()
        {
            string multiLines = @"안녕하세요.
            반갑습니다.
            \n\n\t\t\b\r
            줄바꿈 표시도 그대로 나오네요
            "; // 문자열 앞에 @를 붙이면 문자열 자체를 그대로 문자열로 저장한다. 하지만 그때문에 "를 내부에 사용할 수 없다.
            Line_set_up.setLine();
            WriteLine("MultiLineString");
            Line_set_up.setLine();
            WriteLine(multiLines);
            WriteLine($"문자열 보간법을 사용할때, 따옴표 앞에 $를 붙여서 사용합니다. 이렇게요.\n{multiLines}");
            Line_set_up.setLine();
            //이 외에도 문자열을 붙이는 방법은 자리표시자 ("{0}", message) , 문자열 더하기 (" " + message) 가 있다.
        }
    }
    /*
     * 논리 데이터 형식 (bool)
     * true,false 값을 저장하는 변수
     * 끝
     * 
     * 상수 : const를 이용해 사용하며, '변하지 않는' 문자열 데이터나 숫자를 저장할 때 사용한다.
     */

    class DotNetVariable
    {
        public static void DNV()
        {
            Char c = 'A';// char형의 닷넷 데이터 형식은 System.Char
            String s = "안녕하세요"; // string 형의 닷넷 데이터 형식은 System.String
            Boolean b = true; // bool 형의 닷넷 데이터 형식은 System.Boolean
            Line_set_up.setLine();
            WriteLine("DotNet Data class");
            Line_set_up.setLine();
            WriteLine("{0}\n{1}\n{2}", c, s, b);
            Line_set_up.setLine();

            //이러한 닷넷 데이터 형식을 '래퍼 형식(wrapper type)'이라고도 한다.
        }
    }
    class InputName
    {
        public static void Input()
        {
            Line_set_up.setLine();
            WriteLine("InputName");
            Line_set_up.setLine();
            Write("이름을 입력하시오 =>");
            string name = ReadLine();
            WriteLine("입력한 이름은 {0} 입니다.", name);

            while (true)
            {
                Write("숫자를 입력하시오 =>");
                string number = ReadLine();
                try
                {
                    // 형 변환을 사용하기 위해서는 Convert를 사용해서 바꾸면 된다. 단, 형변환은 래퍼타입으로한다.
                    int number2 = Convert.ToInt32(number);
                    WriteLine(number2);
                    break;
                }
                catch(Exception e)
                {
                    WriteLine("error find! :: errorType : {0}", e);
                }
            }
            Line_set_up.setLine();
        }
    }

    class BinaryString
    {
        public static void Binary()
        {
            byte x = 10;
            Line_set_up.setLine();
            WriteLine("BinaryString");
            Line_set_up.setLine();
            //ToString(x,2)  : x를 2번째 옵션(2진법)으로 변환한다.
            //PadLeft(x,'y') : x칸을 기준으로 왼쪽을 y로 채운다. ex) PadLeft(8,'0') = 8칸 기준으로 왼쪽을 0으로 채운다. 
            WriteLine($"십진수:{x} -> 이진수: {Convert.ToString(x, 2).PadLeft(8, '0')}");
            

            //이진수의 경우 OB 또는 Ob를 앞에 붙임으로써 리터럴로 사용할 수 있다.
            //Ex)
            byte BinaryNumber = 0b0010;
            WriteLine("이진수 리터럴 : {0} = {1}", BinaryNumber,Convert.ToString(BinaryNumber,2).PadLeft(8,'0'));
            Line_set_up.setLine();
        }
    }

    /*
     * 암시적으로 형식화된 로컬 변수
     * var 자료형을 이용해 아직 명확하게 지정되지 않은 자료의 경우 컴파일러가 자동으로 추론할 수 있게 만들 수 있다.
     * 
     * ex)
     * var number = 1234;
     */
    class VarInput
    {
        public static void Varfunc()
        {
            Write("input Var type variable >>");
            var s = ReadLine();
            try
            {
                WriteLine("{0}'s type is {1}", s, s.GetType());
            }
            catch(Exception e)
            {
                WriteLine("error!");
            }
        }
    }

    /*
     * default 키워드
     * 기본값으로 적용하고 싶을 때,
     * int number = default; 와 같이 default 키워드를 이용해 초기화할 수 있다.
     * 숫자 데이터 형식은 0, char는 \0, string 은 null값을 기본값으로 가진다.
     */
}
