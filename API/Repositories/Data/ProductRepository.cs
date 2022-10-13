
using API.Context;
using API.Models;
using API.Repositories.Interface;
using API.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories.Data
{
    public class ProductRepository 
    {
        MyContext mycontext;

        public ProductRepository(MyContext myContext)
        {
            this.mycontext = myContext;
        }
        public int Delete(int id)
        {
            var deldiv = mycontext.Product.Where(a => a.Id == id).FirstOrDefault();
            mycontext.Product.Remove(deldiv);
            var result = mycontext.SaveChanges();
            return result;
        }

        public List<Product> Get()
        {
            var data = mycontext.Product.Include(x => x.IdSupplierNavigation).
                Include(y => y.IdSatuanNavigation).ToList();

            return data;
        }

        public Product Get(int id)
        {
            var data = mycontext.Product.Where(a => a.Id == id).Include(x => x.IdSupplierNavigation).Include(y => y.IdSatuanNavigation).FirstOrDefault();
            return data;
        }

        public int Post(TambahProduct product)
        {
            Product product1 = new Product()
            {
               NamaProduk = product.NamaProduk,
               HargaProduct = product.HargaProduct,
               StockProduct = product.StockProduct,
               IdSatuan = product.IdSatuan,
               IdSupplier  =   product.IdSupplier

            };
            mycontext.Product.Add(product1);
            var result = mycontext.SaveChanges();
            return result;
        }

        public int Put(EditProduct product)
        {
            var data = Get(product.Id);


            data.NamaProduk = product.NamaProduk;
            data.HargaProduct = product.HargaProduct;
            data.StockProduct = product.StockProduct;
            data.IdSatuan = product.IdSatuan;
            data.IdSupplier = product.IdSupplier;
                mycontext.Product.Update(data);
                var result = mycontext.SaveChanges();
            return result;
        }

           
        }
    }

