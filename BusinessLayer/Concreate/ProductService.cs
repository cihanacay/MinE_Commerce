using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ProductService : IProductService
    {
        IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetListAll()
        {
            var list = _productDal.GetListAll();
            return list;

        }

        public List<Product> GetListAll(Expression<Func<Product, bool>> filter)
        {
            var list = _productDal.GetListAll(filter);
            return list;
        }

        public void TAdd(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            var model = _productDal.GetById(id);
            return model;
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
