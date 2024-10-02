using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository cr;

        public CategoryManager()
        {
            cr = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            repo.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            if (category.CategoryName != "" && category.CategoryDescription != null && category.CategoryName.Length >= 5)
            {
                repo.Delete(category);
            }
            else
            {
                //Hata MEsajı
            }
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
