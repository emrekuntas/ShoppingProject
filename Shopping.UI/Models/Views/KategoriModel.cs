using Shopping.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.UI.Models.Views
{
    public class KategoriModel
    {
        public List<CategroiesDTO> clist { get; set; }
        public List<ProductsDTO> plist { get; set; }
        //program starshop sayfasında başlangıç değer almadığı için patlıyordu o hatayı önlemek için Constructer yaptık
        public KategoriModel()
        {
            this.plist = new List<ProductsDTO>();
        }
    }
}