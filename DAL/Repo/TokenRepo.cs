using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TokenRepo:Repo,IRepo<Token,int,Token>
    {
        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() > 0)
            { return obj; }
            return null;
        }

        public bool Delete(int id)
        {
            var token = Get(id);
            db.Tokens.Remove(token);
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(int id)
        {

            return db.Tokens.Where(x=>x.Id == id).FirstOrDefault();
        }

        public Token Update(Token obj)
        {
            var token = Get(obj.Id);
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return obj;
        }
    }
}
