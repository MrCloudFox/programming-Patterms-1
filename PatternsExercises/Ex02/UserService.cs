using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex02
{
    public abstract class UserService<T>
    {
        protected abstract string GetName(string userId);
        protected abstract string Parse(string pageUrl);
        protected abstract T[] GetFriendsById(string userId);

        protected abstract UserInfo[] ConvertToUserInfo(T[] user);

        public UserInfo GetUserInfo(string pageUrl)
        {
            var userId = Parse(pageUrl);
            var users = GetFriendsById(userId);
            return new UserInfo
            {
                Name = GetName(userId),
                UserId = userId,
                Friends = ConvertToUserInfo(users)
            };
        }
    }
}
