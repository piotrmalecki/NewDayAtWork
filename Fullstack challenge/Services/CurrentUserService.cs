using System;
using Fullstack.Challenge.Data;
using Fullstack.Challenge.Models;

namespace Fullstack.Challenge.Services
{
	public class CurrentUserService
	{
		private readonly UserRepository _userRepository;
		private readonly AuthenticationService _authenticationService;

		public CurrentUserService(
			UserRepository userRepository,
			AuthenticationService authenticationService)
		{
			_userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
			_authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
		}

		public int GetBalance()
		{
			int userId = _authenticationService.GetCurrentUserId();
			User user = _userRepository.GetUserById(userId);
			return user.Balance;
		}

		public void UpdateBalance(int newBalance)
		{
			int userId = _authenticationService.GetCurrentUserId();
			_userRepository.UpdateUserBlance(userId, newBalance);
		}

		public string GetUserName()
		{
			int userId = _authenticationService.GetCurrentUserId();
			User user = _userRepository.GetUserById(userId);
			return user.Login;
		}
	}
}