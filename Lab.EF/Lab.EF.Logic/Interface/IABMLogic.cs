using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal interface IABMLogic<T, TT>
    {
        List<T> GetAll();
        void Add(T x);
        void Update(T x);
        void Delete(T x);
        bool Exist(TT x);
    }
}
