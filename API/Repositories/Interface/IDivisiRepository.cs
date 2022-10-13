using API.Models;
using System.Collections.Generic;

namespace API.Repositories.Interface
{
    public interface IDivisiRepository
    {
        List<Divisi> Get();
        Divisi Get(int id);

        int Post(Divisi divisi);
        int Put(Divisi divisi);
        int Delete(int id);
    }
}
