using System;
using System.Collections.Generic;
using System.Text;

namespace task25_Cs_extension_ClassLibrary._03_String
{
    public static class StringLibrary
    {
        ///<summary>
        ///주어진 문자열을 주어진 길이만큼 잘라서 반환, 나머지는 '...'을 붙임
        /// </summary>
        /// <param name="cut">원본 문자열</param>
        /// <returns>안녕하세요 => 안녕...</returns>
        public static string CutString(this string cut, int length, string suffix = "...")
        {
            if (cut.Length > (length-3))
            {
                return cut.Substring(0, length - 3) + "" + suffix;
            }
            return cut;
        }

        /// <summary>
        /// 유니코드 이모티콘을 포함한 문자열 자르기
        /// </summary>
        /// <param name="str">한글, 영문, 유니코드 문자열</param>
        /// <returns>잘라진 문자열 : 안녕하세요 => 안녕...</returns>
        public static string CutStringUniCode(this string str, int length, string suffix = "...")
        {
            string result = str;
            var si = new System.Globalization.StringInfo(str);
            var l = si.LengthInTextElements;
            if (l>(length-3))
            {
                result = si.SubstringByTextElements(0, length - 3) + "" + suffix;
            }
            return result;
        }
    }
}
