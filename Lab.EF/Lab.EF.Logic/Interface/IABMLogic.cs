using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    interface IABMLogic<T, TId>
    {
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(TId item);
    }
}
