using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AccountOwnerServer.Models.Repository
{
   public  interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long ID);
        void Add(TEntity entity);
        void update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity); 



    }
}
