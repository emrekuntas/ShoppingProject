using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.BL.DTOs
{
    public class CategroiesDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
    public class ProductsDTO
    {
        public int ProductID { get; set; }
        public int CategoryID{ get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class UsersDTO
    {
        public string UserID { get; set; }
        public string Role { get; set; }
    }
}