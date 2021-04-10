using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
     interface IEntityRespository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
