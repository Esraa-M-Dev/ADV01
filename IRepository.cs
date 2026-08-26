using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmnentAdvancedC_01
{
    internal interface IRepository<TEntity>
    {
        void Create(TEntity item);
        
        List<TEntity> GetAll();

        

        TEntity GetById(int id);

        
        void Delete(int id);
    }
}
