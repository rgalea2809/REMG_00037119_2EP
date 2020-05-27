using System.Collections.Generic;
using Hugo.databaseObjects;

namespace Hugo.DataAccessObjects
{
    public abstract class AbstractDAO
    {
        public abstract List<Usuario> getTableList();
    }
}