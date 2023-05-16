using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportmaster
{
    class DB
    {
        private static SportmagazinEntities _context;
        public static SportmagazinEntities GetContext()
        {
            if (_context == null)
                _context = new SportmagazinEntities();
            return _context;
        }
    }
}
