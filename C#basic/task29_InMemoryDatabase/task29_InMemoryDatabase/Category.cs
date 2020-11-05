using System;
using System.Collections.Generic;
using System.Text;

namespace task29_InMemoryDatabase
{
    public class Category
    {
        /// <summary>
        /// 카테고리 고유 일련번호
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 카테고리 이름
        /// </summary>
        public string CategoryName { get; set; }
    }
}
