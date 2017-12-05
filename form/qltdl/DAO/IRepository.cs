using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IRepository<T> where T:class
    {

        List<T> GetAll();
        T GetById(int? id);
        bool Insert(T obj);
        bool Delete(T obj);
        bool Update(T obj);
        bool Exists(T obj);
        List<T> Search(T obj);
       
    }
}
