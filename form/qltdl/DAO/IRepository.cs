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
        //T Get<T>(int? id);
        //List<T> GetAll<T>(int? id);
        //void Delete<T>(T model);
        //void Insert<T>(T model);
        //void Edit<T>(T model);
        //bool Insert(QLTDLEntities entity);
        //Task<T> Find<T>(T model) where T : class, new();
        //IEnumerable<T> GetAll<T>() where T : class, new();
        //T GetById<T>(object Id) where T : class, new();
        //bool Insert<T>(T obj) where T : class, new();
        //bool Delete<T>(T obj) where T : class, new();
        //bool Update<T>(T obj) where T : class, new();
        List<T> GetAll();
        T GetById(T obj);
        bool Insert(T obj);
        bool Delete(T obj);
        bool Update(T obj);
        bool Exists(T obj);
        List<T> Search(T obj);
    }
}
