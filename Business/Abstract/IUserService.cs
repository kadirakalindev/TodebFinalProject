using Business.Configuration.Response;
using DTO.User;
using Models.Models;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        public IEnumerable<UserInfo> GetAllUsers();
        public CommandResponse Insert(CreateUserRequest user);
        public CommandResponse Update(UpdateUserRequest user);
        public CommandResponse Delete(UserInfo user);
    }
}
