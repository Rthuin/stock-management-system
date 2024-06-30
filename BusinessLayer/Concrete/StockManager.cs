using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.EntityFramework;

namespace BusinessLayer.Concrete
{
    public class StockManager : IStockService
    {
        private readonly IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public void StockAdd(Stock stock)
        {
            stock.Date = DateTime.Now;
            _stockDal.Insert(stock);
        }

        public void StockRemove(Stock stock)
        {
            _stockDal.Delete(stock);
        }

        public void StockUpdate(Stock stock)
        {
            _stockDal.Update(stock);
        }

        public Stock GetStock(int id)
        {
            return _stockDal.GetById(id);
        }

        public List<Stock> GetAllStocks()
        {
            return _stockDal.GetAll();
        }

        
        public List<Stock> GetAllStocksWithProductAndAdmin()
        {
            return _stockDal.GetListWithProductAndAdmin();
        }

        public List<Stock> GetAllStocksByUserID(int id)
        {
            return _stockDal.GetListWithUserID(id);
        }
    }
}
