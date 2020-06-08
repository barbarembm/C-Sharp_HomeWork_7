using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7
{
    public static class DBSimulator
    {
        public static List<ProdactCategory> GetProductCategories()
        {
            List<ProdactCategory> ls = new List<ProdactCategory>();
            ls.Add(new ProdactCategory { Id = 1, Name = "tansacmeli" });
            ls.Add(new ProdactCategory { Id = 2, Name = "pexsacmeli" });
            ls.Add(new ProdactCategory { Id = 3, Name = "medikomenti" });
            ls.Add(new ProdactCategory { Id = 4, Name = "sakonditro" });
            ls.Add(new ProdactCategory { Id = 5, Name = "aveji" });
            ls.Add(new ProdactCategory { Id = 6, Name = "sasmelebi" });
            return ls;
        }
        public static List<Prodact> GetProducts()
        {
            List<Prodact> ls = new List<Prodact>();
            ls.Add(new Prodact { Categoty_ID = 1, Name = "Jinsis qurtuki",Code="0001",Measuring="cali",Price=100,Valute="lari",Quantity=1 });
            ls.Add(new Prodact { Categoty_ID = 1, Name = "bavshvis kaba", Code = "0002", Measuring = "cali", Price = 50, Valute = "dolari", Quantity = 2 });
            ls.Add(new Prodact { Categoty_ID = 2, Name = "adidasi ketasebi", Code = "0003", Measuring = "cali", Price = 200, Valute = "dolari", Quantity = 3 });
            ls.Add(new Prodact { Categoty_ID = 2, Name = "gamosasvleli", Code = "0004", Measuring = "cali", Price = 250, Valute = "dolari", Quantity = 2 });
            ls.Add(new Prodact { Categoty_ID = 2, Name = "naikis butsi", Code = "0005", Measuring = "cali", Price = 100, Valute = "dolari", Quantity = 2 });
            ls.Add(new Prodact { Categoty_ID = 3, Name = "vitamine C", Code = "0006", Measuring = "abi", Price = 50, Valute = "lari", Quantity = 4,Expiration=new DateTime(2020,7,31) });
            ls.Add(new Prodact { Categoty_ID = 3, Name = "vitamine B", Code = "0007", Measuring = "abi", Price = 75, Valute = "lari", Quantity = 2, Expiration = new DateTime(2020, 8, 31) });
            ls.Add(new Prodact { Categoty_ID = 4, Name = "soko", Code = "0008", Measuring = "pachka", Price = 50, Valute = "lari", Quantity = 2, Expiration = new DateTime(2019, 7, 31) });
            ls.Add(new Prodact { Categoty_ID = 4, Name = "Mtvrali alubali", Code = "0009", Measuring = "cali", Price = 12, Valute = "lari", Quantity = 10, Expiration = new DateTime(2020, 5, 30,23,59,0) });
            ls.Add(new Prodact { Categoty_ID = 4, Name = "napoleoni", Code = "0010", Measuring = "cali", Price = 2.5M, Valute = "lari", Quantity = 10, Expiration = new DateTime(2020, 5, 30,23,59,0) });
            ls.Add(new Prodact { Categoty_ID = 5, Name = "Wignebis taro", Code = "0011", Measuring = "cali", Price = 1200, Valute = "lari", Quantity = 1 });
            ls.Add(new Prodact { Categoty_ID = 5, Name = "Skami", Code = "0012", Measuring = "cali", Price = 50, Valute = "lari", Quantity = 6 });
            ls.Add(new Prodact { Categoty_ID = 5, Name = "Magida", Code = "0013", Measuring = "cali", Price = 750, Valute = "lari", Quantity = 1,Expiration=new DateTime(2020,7,30) });
            ls.Add(new Prodact { Categoty_ID = 5, Name = "divani", Code = "0014", Measuring = "cali", Price = 1200, Valute = "lari", Quantity = 1, Expiration = new DateTime(2020, 7, 30) });
            ls.Add(new Prodact { Categoty_ID = 6, Name = "piva", Code = "0012", Measuring = "litra", Price = 2.5M, Valute = "lari", Quantity = 5, Expiration = new DateTime(2020, 7, 30) });
            ls.Add(new Prodact { Categoty_ID = 6, Name = "limonati", Code = "0013", Measuring = "litra", Price = 3.5m, Valute = "lari", Quantity = 2, Expiration = new DateTime(2020, 7, 30) });
            ls.Add(new Prodact { Categoty_ID = 6, Name = "rze", Code = "0014", Measuring = "litra", Price = 5.5M, Valute = "lari", Quantity = 1, Expiration = new DateTime(2020, 7, 30) });
            return ls;
        }
    }
}
