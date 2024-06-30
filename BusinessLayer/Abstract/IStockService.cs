using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStockService
    {
        void StockAdd(Stock stock);
        void StockRemove(Stock stock);
        void StockUpdate(Stock stock);
        List<Stock> GetAllStocks();
        List<Stock> GetAllStocksWithProductAndAdmin();
        List<Stock> GetAllStocksByUserID(int userId);
        Stock GetStock(int id);
    }
}
