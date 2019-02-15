using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shopping.ENT.Entities;

namespace Shopping.REP
{
    public class Repositories
    {
        public class CategroiesRepository : BaseRepository<Categories> { }
        public class ProductssRepository : BaseRepository<Products> { }
        public class SuppliersRepository : BaseRepository<Suppliers> { }
        public class UsersRepository : BaseRepository<Users> { }
    }
}
