using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories, string>
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        public void Add(Categories x)
        {
            throw new NotImplementedException();
        }

        public void Delete(Categories x)
        {
            throw new NotImplementedException();
        }

        public bool Exist(string x)
        {
            throw new NotImplementedException();
        }
        public void Update(Categories x)
        {
            throw new NotImplementedException();
        }
    }
}
