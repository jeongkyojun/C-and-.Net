using System;
using System.Collections.Generic;
using System.Text;

namespace task25_Cs_extension_ClassLibrary._02_Mathematics
{
    public class Math
    {
        ///<summary>
        ///절댓값 구하기
        ///</summary>
        ///<param name = "number">자연수</param>
        ///<returns>절댓값</returns>
        public static int Abs(int number) => (number < 0) ? -number : number;// Abs()를 모방하여 만든 임시 라이브러리
    }
}
