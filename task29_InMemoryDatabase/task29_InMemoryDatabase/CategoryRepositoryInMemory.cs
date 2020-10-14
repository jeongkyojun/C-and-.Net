using Dul.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task29_InMemoryDatabase
{
    public class CategoryRepositoryInMemory : ICategoryRepository
    {
        private static List<Category> _categories = new List<Category>();
        public CategoryRepositoryInMemory()
        {
            _categories = new List<Category>()
            {
                new Category() { CategoryId = 1, CategoryName = "책"},
                new Category() { CategoryId = 2, CategoryName = "강의"},
                new Category() { CategoryId = 3, CategoryName = "컴퓨터" }
            };
        }

        /// <summary>
        /// 입력
        /// </summary>
        public Category Add(Category model)
        {
            model.CategoryId = _categories.Max(c => c.CategoryId) + 1;
            _categories.Add(model);
            return model;
        }
           
        /// <summary>
        /// 상세
        /// </summary>
        public Category Browse(int id)
        {
            return _categories.Where(c => c.CategoryId == id).SingleOrDefault();
        }

        /// <summary>
        /// 삭제
        /// </summary>
        public bool Delete(int id)
        {
            int r = _categories.RemoveAll(c => c.CategoryId == id);
            if(r>0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 수정
        /// </summary>
        public bool Edit(Category model)
        {
            var result = _categories
                .Where(c => c.CategoryId == model.CategoryId)
                .Select(c => { c.CategoryName = model.CategoryName; return c; })
                .SingleOrDefault();
            if(result != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 건수
        /// </summary>
        public int Has()
        {
            return _categories.Count();
        }

        /// <summary>
        /// 정렬
        /// </summary>
        public IEnumerable<Category> Ordering(OrderOption orderOption)
        {
            IEnumerable<Category> categories;
            
            switch(orderOption)
            {
                case OrderOption.Ascending:
                    categories = _categories.OrderBy(c => c.CategoryName);
                    break;
                case OrderOption.Descending:
                    categories = (from category in _categories
                                  orderby category.CategoryName descending
                                  select category);
                    break;
                default:
                    //[c] 기본값
                    categories = _categories;
                    break;
            }

            return categories;
        }

        /// <summary>
        /// 페이징
        /// </summary>
        /// <param name="pageNumber">페이지 번호 : 1, 2, 3, ...</param>
        /// <param name="pageSize">페이지 크기 : 한 페이지당 10개씩 표시</param>
        /// <returns>읽고 쓰기가 가능한(List) 페이징 처리된 레코드셋</returns>
        public List<Category> Paging(int pageNumber=1, int pageSize = 10)
        {
            return _categories
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        ///<summary>
        ///출력
        ///</summary>
        public List<Category> Read()
        {
            return _categories;
        }

        /// <summary>
        /// 검색
        /// </summary>
        public List<Category> Search(string query)
        {
            return _categories
                .Where(category => category.CategoryName.Contains(query)).ToList();
        }
    }
}
