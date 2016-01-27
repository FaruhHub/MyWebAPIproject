using System.Collections.Generic;
using Stats.DataAccess.Entities;

namespace Stats.DataAccess.Repositories {
    public interface IRepository<T> where T : EntityBase {
        List<T> Get( );
        T Get( int id );
        T Update( T obj );
        T Insert( T obj );
        int Delete( T obj );
    }
}