using Lab.EF.Entities;
using Lab.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic.Control
{
    public class ShippersControl : IABMLogic<Shippers,string>
    {
        private ShippersLogic _spLogic;
        public ShippersControl()
        {
            _spLogic = new ShippersLogic();
        }
        public List<Shippers> GetAll()
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
        public void Add(Shippers x)
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

        public void Delete(Shippers x)
        {
            try
            {
                _spLogic.Delete(x);
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

        public void Update(Shippers x)
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
            throw new NotImplementedException();
        }
    }
}
