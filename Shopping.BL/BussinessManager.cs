using Shopping.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shopping.ENT.Entities;
using static Shopping.REP.Repositories;

namespace Shopping.BL
{
    public class BussinessManager
    {
        public class CategoriesManager: CategroiesRepository
        {
            public List<CategroiesDTO> KategoriListe()
            {
                return GenelListe().Select(x => new CategroiesDTO {CategoryID=x.CategoryID,CategoryName=x.CategoryName }).ToList();
            }
           
    }
        public class ProductsManager : ProductssRepository
        {
            public List<ProductsDTO> UrunListe()
            {
                return GenelListe().Select(x => new ProductsDTO {ProductID=x.ProductID,CategoryID=(int)x.CategoryID,ProductName=x.ProductName,UnitPrice=(decimal)x.UnitPrice }).ToList();
            }
        }
        public class SuppliersManager : SuppliersRepository { }
        public class UsersManager : UsersRepository
        {
            public UsersDTO Denetle(string UserID,string Password)
            {
                Users user = null;
                user = Bul(UserID);

                if (user !=null)
                {
                    if (user.Password == Password)
                    {
                        UsersDTO userDto = new UsersDTO();
                        userDto.UserID = user.UserID;
                        userDto.Role = user.Role;
                        return userDto;
                    }
                    else return null;
                }
                else return null;
            }
        }
    }
}
