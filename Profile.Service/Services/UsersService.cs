
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public interface IUsersService 
{
    List<User> GetUsersList();
}

public class UsersService : IUsersService
{
    private readonly IUsersRepository _userRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _userRepository = usersRepository;
    }
    public List<User> GetUsersList()
    {
       return _userRepository.GetListofUsers();
    }
}