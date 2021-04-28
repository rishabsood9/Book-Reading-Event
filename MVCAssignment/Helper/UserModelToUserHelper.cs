using System;
using System.Collections.Generic;
using Shared;
using MVCAssignment.Models;
using AutoMapper;
using System.Linq;
using System.Web;

namespace MVCAssignment.Helper
    {
    public class UserModelToUserHelper
        {
        public User UserModelToUserMapping(UserModel e)
            {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<UserModel, User>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<UserModel, User>(source);
            return destination;
            }

        /*public IEnumerable<User> GetEvent(IEnumerable<UserModel> userModels)
            {
            List<User> users = new List<User>();
            foreach (var item in userModels)
                {
                users.Add(UserModelToUserMapping(item));
                }
            return users;

            }
            */
        }
    }