
using API.Context;
using API.Models;
using API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories.Data
{
    public class SatuanRepository 
    {
        MyContext myContext;

        public SatuanRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(int id)
        {
            var delsat = myContext.Satuan.Where(a => a.Id == id).FirstOrDefault();
            myContext.Satuan.Remove(delsat);
            var result = myContext.SaveChanges();
            return result;
        }

        public List<Satuan> Get()
        {
            var data = myContext.Satuan.ToList();
            return data;
        }



        public int Post(Satuan satuan)
        {
            myContext.Satuan.Add(satuan);
            var result = myContext.SaveChanges();
            return result;
        }

       
    }
}
