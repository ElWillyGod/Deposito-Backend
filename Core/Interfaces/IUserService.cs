

namespace Core.Interfaces;

	public interface IUserService
	{
		Task<User> GetUserByEmailAsync(string email);
		Task<bool> CreateUserAsync(User user);
		Task<bool> UpdateUserAsync(User user);
		Task<bool> DeleteUserAsync(int id);
		Task<String> AuthenticateUserAsync(string email, string password);
	}
