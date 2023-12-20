using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.SqlServer;
namespace mrr22023
{
    internal class ZavodRepository
    {

        protected AppDbcontext _dbcontext;
        public ZavodRepository(AppDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Zavod> GetAll()
        {
            return _dbcontext.Zavods.ToList();
        }
    }
}
