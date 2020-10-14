using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

/*
* 
* C# 프로그래밍 28일차 4단원 C# 확장기능 : 57강 - CRUD 인메모리 데이터베이스 구현 
* Copyright 2020. Jeong kyojun, All pictures cannot be copied without permission.
*
*/

namespace task29_InMemoryDatabase
{
    class InMemoryDatabase
    {
        static CategoryRepositoryInMemory _category;

        #region Print
        /// <summary>
        /// [0] 카테고리 출력 공통 메서드
        /// </summary>
        /// <param name="categories">카테고리 리스트</param>
        private static void PrintCategories(List<Category> categories)
        {
            foreach (var category in categories)
            {
                WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }
            WriteLine();
        }
        #endregion

        #region Has
        /// <summary>
        /// [1] 건수
        /// </summary>
        private static void HasCategory()
        {
            if(_category.Has()>0)
            {
                WriteLine("기본 데이터가 존재합니다.");
            }
            else
            {
                WriteLine("기본 데이터가 없습니다.");
            }
            WriteLine();
        }
        #endregion

        #region Read
        /// <summary>
        /// [2] 출력
        /// </summary>
        private static void ReadCategories()
        {
            var categories = _category.Read();
            PrintCategories(categories);
        }
        #endregion

        #region Add
        /// <summary>
        /// [3] 입력
        /// </summary>
        private static void AddCategory()
        {
            var category = new Category() { CategoryName = "생활용품" };
            _category.Add(category);
            ReadCategories();
        }
        #endregion

        #region Browse
        /// <summary>
        /// [4] 상세
        /// </summary>
        private static void BrowseCategory()
        {
            int categoryId = 4;
            var category = _category.Browse(categoryId);
            if(category !=null)
            {
                WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }
            else
            {
                WriteLine($"{categoryId}번 카테고리가 없습니다.");
            }
            WriteLine();
        }
        #endregion

        #region Edit
        /// <summary>
        /// [5] 수정
        /// </summary>
        private static void EditCategory()
        {
            _category.Edit(new Category { CategoryId = 4, CategoryName = "가전용품" });
            ReadCategories();
        }
        #endregion

        #region Delete
        /// <summary>
        /// [6] 삭제
        /// </summary>
        private static void DeleteCategory()
        {
            int categoryId = 1;
            _category.Delete(categoryId);
            WriteLine($"{categoryId}번 데이터를 삭제합니다.");
            ReadCategories();
        }
        #endregion

        #region Search
        /// <summary>
        /// [7] 검색
        /// </summary>
        private static void SearchCategories()
        {
            var query = "강의";
            var categories = _category.Search(query);
            PrintCategories(categories);
        }
        #endregion

        #region Paging
        /// <summary>
        /// [8] 페이징
        /// </summary>
        private static void PagingCategories()
        {
            var categories = _category.Paging(2, 2);
            if(categories.Count > 1)
            {
                categories.RemoveAt(0);
            }
            PrintCategories(categories);
        }
        #endregion

        #region Ordering
        /// <summary>
        /// [9] 정렬
        /// </summary>
        private static void OrderingCategories()
        {
            var categories = _category.Ordering(Dul.Data.OrderOption.Descending);
            PrintCategories(categories.ToList());
        }
        #endregion

        static void Main(string[] args)
        {
            _category = new CategoryRepositoryInMemory();

            WriteLine("[1] 기본값이 있는지 확인 : ");
            HasCategory();

            WriteLine("[2] 기본 데이터 출력 : ");
            ReadCategories();

            WriteLine("[3] 데이터 입력 : ");
            AddCategory();

            WriteLine("[4] 상세 보기 : ");
            BrowseCategory();

            WriteLine("[5] 데이터 수정 : ");
            EditCategory();

            WriteLine("[6] 데이터 삭제 : ");
            DeleteCategory();

            WriteLine("[7] 데이터 검색 : ");
            SearchCategories();

            WriteLine("[8] 페이징 : ");
            PagingCategories();

            WriteLine("[9] 정렬 : ");
            OrderingCategories();

        }
    }
}
