﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Diagnostics;

namespace BUS
{
    public class TOURDD_BUS
    {
        IRepository<TOURDD> tourdd;
      
        public TOURDD_BUS()
        {
            tourdd = new Repository<TOURDD>();
                    }
        public List<TOURDD> GetAll()
        {
            return tourdd.GetAll();
        }
        public bool insert(int idt,int iddd)
        {
            TOURDD t = new TOURDD();
            t.IDT = idt;
            t.IDDD = iddd;
            return tourdd.Insert(t);
        }
        public bool edit(TOURDD t)
        {
            return tourdd.Update(t);
        }
        //public int iddd(String name)
        //{
        //    TOURDD ct = new TOURDD();
        //    List<NOITHAMQUAN> lct = new List<NOITHAMQUAN>();
        //    lct = tourdd.GetAll();
        //    foreach (TOURDD t in lct)
        //    {
        //        if (t.CTNTQ.TENGOI.Equals(name))
        //        {
        //            return t.CTNTQ.ID;
        //        }
        //    }
        //    return -1;
        //}
        public int id()
        {
            return tourdd.GetAll().Max(c => c.ID);
        }

        public List<ddview> load(int id)
        {
            List<ddview> lddv = new List<ddview>();
            List<TOURDD> ltdd = tourdd.GetAll().Where(c => c.IDT==id).ToList();
            foreach(TOURDD tdd in ltdd)
            {
                ddview temp = new ddview();
                temp.tinhthanh = tdd.CTNTQ.NOITHAMQUAN.TENGOI;
                temp.diadiem = tdd.CTNTQ.TENGOI;
                lddv.Add(temp);
            }
            return lddv;
        }
        public void delete(int idt)
        {
            TOURDD tdd = new TOURDD();
            List<TOURDD> ltdd = tourdd.GetAll().Where(c => c.IDT == idt).ToList();
            foreach(TOURDD t in ltdd)
            {
                tourdd.Delete(t);
            }
        }

    }
}
