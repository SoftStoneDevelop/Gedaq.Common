using System;
using System.Linq;

namespace Gedaq.Provider
{
    public abstract class GedaqRequest
    {
        public IQueryable<T> Query<T>(string methodName)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> QueryAsync<T>(string methodName)
        {
            throw new NotImplementedException();
        }
    }
}