using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        List<T> Search(Expression<Func<T, bool>> where);
        List<nvmodel> tknhanvien(int manv, DateTime bd, DateTime kt);


    }
}
