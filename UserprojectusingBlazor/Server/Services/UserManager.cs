using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Web.Providers.Entities;
using UserprojectusingBlazor.Server.Interface;
using UserprojectusingBlazor.Server.Models;
using UserprojectusingBlazor.Shared.Models;

namespace UserprojectusingBlazor.Server.Services
{
    public class UserManager : IUserdetail
    {
        readonly DatabaseContext _dbContext = new();
        public UserManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all user details
        public List<UserClass> GetUserDetails()
        {
            try
            {
                return _dbContext.UserDetails.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new user record
        public void AddUser(UserClass user)
        {
            try
            {
                _dbContext.UserDetails.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar user
        public void UpdateUserDetails(UserClass user)
        {
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular user
        public UserClass GetUserById(int id)
        {
            try
            {
                UserClass? user = _dbContext.UserDetails.Find(id);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular user
        public void DeleteUser(int id)
        {
            try
            {
                UserClass? user = _dbContext.UserDetails.Find(id);
                if (user != null)
                {
                    _dbContext.UserDetails.Remove(user);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }


}

