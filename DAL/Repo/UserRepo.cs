using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : Repo,IRepo<User,int,User> ,IAuth
    {
        public User Add(User obj)
        {
            db.Users.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public User Authenticate(string Email, string Password)
        {
            var obj = db.Users.FirstOrDefault(x => x.Email.Equals(Email) && x.Password.Equals(Password));
            return obj;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public Token GetToken(string token)
        {
            var obj = db.Tokens.FirstOrDefault(x => x.LoginToken.Equals(token));
            return obj;
        }

        public User GetUser(string Email)
        {
            var obj = db.Users.FirstOrDefault(x => x.Email.Equals(Email));
            return obj;
        }

        public User Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
