using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{

    public class EfStockRepository : GenericRepository<Stock>, IStockDal
    {
        private readonly Context _context;
        public EfStockRepository(Context context) : base(context)
        {
            _context = context;
        }



        public List<Stock> GetListWithProductAndAdmin()
        {
            return _context.Stocks
                .Include(x => x.Product)
                .Include(x => x.Admin)
                .ToList();
        }

        public List<Stock> GetListWithUserID(int id)
        {
            return _context.Stocks
                .Where(x => x.UserID == id)
                .Include (x => x.Product)
                .Include(x => x.Admin)    
                .ToList();
        }
    }
}
