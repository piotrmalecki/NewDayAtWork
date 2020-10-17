using System.Collections.Generic;
using System.Linq;
using Fullstack.Challenge.Models;

namespace Fullstack.Challenge.Data
{
	public class UserRepository
	{
		private static readonly List<User> _users;

		public User GetUserByLogin(string login)
		{
			return _users.FirstOrDefault(u => u.Login == login);
		}

		public User GetUserById(int userId)
		{
			User user = _users.First(u => u.Id == userId);
			return user;
		}

		public void UpdateUserBlance(int userId, int newBalance)
		{
			User user = _users.First(u => u.Id == userId);
			user.Balance = user.Balance - newBalance;
		}

		static UserRepository()
		{
			_users = new List<User>
			{
				new User
				{
					Id = 1,
					Login = "user1@example.com",
					Password = "1",
					Balance = 120
				},
				new User
				{
					Id = 2,
					Login = "user2@example.com",
					Password = "1",
					Balance = 30
				},
				new User
				{
					Id = 3,
					Login = "user1@example.com",
					Password = "1",
					Balance = 50
				}
			};
		}
	}
}