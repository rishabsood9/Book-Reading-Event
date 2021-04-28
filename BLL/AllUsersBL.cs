using System;
using System.Collections.Generic;
using Shared;
using DAL;
namespace BL
    {
    public class AllUsersBL
        {
        public IEnumerable<User> GetUsers
            {
            get
                {
                IEnumerable<User> users;
                AllUsersDAL getEventsDAL = new AllUsersDAL();

                users = getEventsDAL.GetUsers;
                return users;
                }
            }

        }
    }
