using DataLayer.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAO
{
    public class UserDao
    {
        NTQShopEntities1 db = new NTQShopEntities1();
        public long Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }
        public User GetById(string Email)
        {
            return db.Users.SingleOrDefault(x => x.Email == Email);
        }
        public int Login(string Email, string Password)
        {
            var result = db.Users.SingleOrDefault(x => x.Email == Email && x.PassWord == Password);
            if(result == null )
            {
                return 0;
            }
            else
            {
                if(result.Status == 0)
                {
                    return -1;
                }
                else
                {
                    if (result.PassWord == Password) 
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }
    }
}
