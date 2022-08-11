using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IUserRepository
    {
        public IEnumerable<UserInfo> GetAllUsers();
        public void Insert(UserInfo user);
        public void Update(UserInfo user);
        public void Delete(UserInfo user);
        public UserInfo Get(int id);
    }
}
