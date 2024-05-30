using AutoMapper;
using DAL.EF.Models;
using DAL;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthServices
    {
        public static TokenDTO Authenticate(string Username, string Password)
        {
            var user = DataAccessFactory.AuthDataAccess().Authenticate(Username, Password);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(cfg);

            if (user != null)
            {

                var tk = new Token();
                tk.UId = user.UId;
                tk.UserType = user.UserType;
                tk.CreatedDate = DateTime.Now;
                tk.ExpDate = null;
                tk.LoginToken = Guid.NewGuid().ToString();
                var rttk = DataAccessFactory.TokenDataAccess().Add(tk);
                if (rttk != null)
                {
                    var data = mapper.Map<TokenDTO>(rttk);
                    return data;
                }
            }
            return null;
        }
        public static TokenDTO IsTokenValid(string token)
        {
            var tk = DataAccessFactory.AuthDataAccess().GetToken(token);
            if (tk != null && tk.ExpDate == null)
            {
                var cfg = new MapperConfiguration(c => {
                    c.CreateMap<Token, TokenDTO>();
                });
                var mapper = new Mapper(cfg);
                var data = mapper.Map<TokenDTO>(tk);
                return data;
            }
            return null;
        }

        public static bool ExpToken(string token)
        {
            var tk = DataAccessFactory.AuthDataAccess().GetToken(token);
            if (tk != null && tk.ExpDate == null)
            {
                tk.ExpDate = DateTime.Now;
                var uptk = DataAccessFactory.TokenDataAccess().Update(tk);
                if (uptk != null)
                {
                    return true;
                }
                return false;

            }
            return false;


        }
    }
}
