using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories, int>
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        public void Add(Categories item)
        {
            context.Categories.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var categorieDelete = context.Categories.FirstOrDefault(r => r.CategoryID == id);
            context.Categories.Remove(categorieDelete);
            context.SaveChanges();
        }
        public void Update(Categories item)
        {
            var categoriesUpdate = context.Categories.Find(item.CategoryID);

            categoriesUpdate.CategoryName = item.CategoryName;
            categoriesUpdate.Description = item.Description;
            categoriesUpdate.Picture = item.Picture;
            context.SaveChanges();
        }
    }
}
