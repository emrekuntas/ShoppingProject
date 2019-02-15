using Shopping.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.REP
{
    public class DBSingleTone
    {
        static NORTHWNDEntities db;
        public static NORTHWNDEntities GetInstance()
        {
            if (db == null)
            {
                db = new NORTHWNDEntities();
            }
            return db;
        }
    }
}
