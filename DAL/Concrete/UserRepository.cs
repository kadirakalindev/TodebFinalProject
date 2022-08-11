using DAL.Abstract;
using Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        private TodebFinalDBContext context;
        public UserRepository()
        {

        }
        public UserRepository(TodebFinalDBContext context)
        {
            this.context = context;
        }
        public void Delete(UserInfo user)
        {
            context.UserInfos.Remove(user);
            context.SaveChanges();
        }

        public UserInfo Get(int id)
        {
            return context.UserInfos.FirstOrDefault(x => x.UserId == id);
        }

        public IEnumerable<UserInfo> GetAllUsers()
        {
            return context.UserInfos.ToList();
        }

        public void Insert(UserInfo user)
        {
            context.UserInfos.Add(user);
            context.SaveChanges();
        }

        public void Update(UserInfo user)
        {
            context.UserInfos.Update(user);
            context.SaveChanges();
        }
    }
}
