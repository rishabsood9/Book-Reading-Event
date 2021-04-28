using MVCAssignment.Models;
using Shared;
using AutoMapper;
namespace MVCAssignment.Helper
    {
    public class RegisterUserModelToUserHelper
        {
        public User RegisterUserModelToUserMapping(RegisterUserModel e)
            {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<RegisterUserModel, User>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = e;

            var destination = iMapper.Map<RegisterUserModel, User>(source);
            return destination;
            }
        }
    }