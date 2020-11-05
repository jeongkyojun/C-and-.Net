using System;
using System.Collections.Generic;
using System.Text;

namespace Dul.Data
{
    public interface IBreadShop<T> where T : class
    {
        /// <summary>
        /// 상세
        /// </summary>
        T Browse(int id);

        /// <summary>
        /// 출력
        /// </summary>
        List<T> Read();

        /// <summary>
        /// 수정
        /// </summary>
        bool Edit(T model);

        /// <summary>
        /// 입력
        /// </summary>
        T Add(T model);

        /// <summary>
        /// 삭제
        /// </summary>
        bool Delete(int id);

        /// <summary>
        /// 검색
        /// </summary>
        List<T> Search(string query);

        /// <summary>
        /// 건수
        /// </summary>
        int Has();

        /// <summary>
        /// 정렬
        /// </summary>
        IEnumerable<T> Ordering(OrderOption orderOption);//List<T> 로 정해도 무관

        /// <summary>
        /// 페이징
        /// </summary>
        List<T> Paging(int pageNumber, int pageSize);
    }
}
