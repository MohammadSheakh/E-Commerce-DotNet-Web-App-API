using DataAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Helper
{
    public class GenericMethodForRepo<ReturnType, MethodName, CLASS, OBJ>
    {
        //<ReturnType, CLASS, OBJ>

        public GenericMethodForRepo() { }

        // Lets Make Generic for Create Method in Repo

        //public ReturnType Create<CLASS, ReturnType, OBJ>(CLASS obj) where ReturnType : class
        //{
        //    ECommerceContext db = new ECommerceContext();

        //    db.<ReturnType>().Add(OBJ);

        //    if (db.SaveChanges() > 0) return obj;
        //    return null;
        //}


        //public T Create<T>(T obj) where T : class
        //{
        //    ECommerceContext db = new ECommerceContext();

        //    db.Set<T>().Add(obj);
        //    if (db.SaveChanges() > 0) return obj;
        //    return null;
        //}

        //public T Create<T>(T obj) where T : class
        //{
        //    ECommerceContext db = new ECommerceContext();

        //    db.Set<T>().Add(obj);
        //    if (db.SaveChanges() > 0) return obj;
        //    return null;
        //}

        public TResult Create<TInput, TResult>(TInput obj)
                    where TInput : class
                    where TResult : class
        {
            ECommerceContext db = new ECommerceContext();
            db.Set<TInput>().Add(obj);
            if (db.SaveChanges() > 0) return obj as TResult;
            return null;
        }

        //public  TInput Created<TInput, TResult, r>(TResult obj)
        //            where TInput : class
        //            where TResult : class
        //{
        //    ECommerceContext db = new ECommerceContext();
        //    db.Set<TResult>().Add(obj);
        //    if (db.SaveChanges() > 0) return obj as TInput;
        //    return null;
        //}

    }
}
