using AssingmentApp.DAL;
using AssingmentApp.Models;

namespace AssingmentApp.Repositories
{
    public class CategoryRepo: ICategoryRepo
    {

        private readonly ApplicationDBConntext db;

        public CategoryRepo(ApplicationDBConntext db)
        {
            this.db = db;
        }

        public int AddCategory(Category cat)
        {
            int res = 0;
            db.Categories.Add(cat);
            res = db.SaveChanges();
            return res;

        }

        public int DeleteCategory(int id)
        {
            int res = 0;
            var c = db.Categories.Where(x => x.CategoryId == id).SingleOrDefault();
            if (c != null)
            {
                db.Categories.Remove(c);
                res = db.SaveChanges();
            }
            return res;

        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();

        }

        public Category GetCategoryById(int id)
        {

            return db.Categories.Where(x => x.CategoryId == id).SingleOrDefault();

        }

        public int UpdateCategory(Category cat)
        {
            int res = 0;
            var c = db.Categories.Where(x => x.CategoryId == cat.CategoryId).SingleOrDefault();
            if (c != null)
            {
                c.CategoryName = cat.CategoryName;
                res = db.SaveChanges();
            }
            return res;
        }
    }
}

