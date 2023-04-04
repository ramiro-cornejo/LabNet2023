using Lab.EF.Entities;
using Lab.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Control
{
    public class SuppliersControl : BaseLogic, IABMLogic<Suppliers, string>
    {
        private readonly SuppliersLogic _spLogic;

        public SuppliersControl()
        {
            _spLogic = new SuppliersLogic();
        }



        public List<Suppliers> GetAll()
        {
            try
            {
                return _spLogic.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Suppliers x)
        {
            try
            {
                _spLogic.Add(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Exist(string x)
        {
            try
            {
                return _spLogic.Exist(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Update(Suppliers x)
        {
            try
            {
                _spLogic.Update(x);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _spLogic.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
