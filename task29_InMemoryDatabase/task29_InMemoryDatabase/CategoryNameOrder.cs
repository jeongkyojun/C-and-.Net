using System;
using System.Collections.Generic;
using System.Text;

namespace task29_InMemoryDatabase
{
    //한국식 발음 : 오브설리트
    [Obsolete("OrderOption 열거형을 사용하세요")]
    ///<summary>
    ///열거형 : 카테고리 이름 정렬 방법
    ///</summary>
    public enum CategoryNameOrder
    {
        /// <summary>
        /// 오름차순
        /// </summary>
        Asc,
        /// <summary>
        /// 내림차순
        /// </summary>
        Desc
    }
}
