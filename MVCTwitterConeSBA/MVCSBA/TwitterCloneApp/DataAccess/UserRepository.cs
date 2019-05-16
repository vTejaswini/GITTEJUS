﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
     public class UserRepository
    {
        public void AddUser(PERSON objUser)
        {
            try
            {
                using (TwitterCloneContext objContext = new TwitterCloneContext())
                {
                    objContext.People.Add(objUser);
                    objContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool VerifyUser(string username, string password)
        {
            try
            {
                using (TwitterCloneContext objContext = new TwitterCloneContext())
                {
                    var NoOfUsers = (from obj in objContext.People
                                     where obj.user_id == username && obj.password == password
                                     select obj).Count();
                    if (NoOfUsers > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
