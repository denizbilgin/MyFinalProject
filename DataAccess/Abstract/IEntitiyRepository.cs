using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint = generic kısıtlamak
    //IEntity olabilir veya IEntity implemente eden bir nesne olabilir (new yazılmadan önce)
    //new dendiği için IEntity interfacesi kullanılamadı
    public interface IEntitiyRepository<T> where T:class,IEntity,new()
    {
        //filtreleme
        //null yazan yer eğer filtre girilmezse hepsini getirir
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        //tek bir ürünü getirme
        T Get(Expression<Func<T, bool>> filter);
        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
