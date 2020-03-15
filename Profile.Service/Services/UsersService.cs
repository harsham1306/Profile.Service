
using System.Collections.Generic;

public interface IUsersService 
{
    List<User> GetUsersList();
}



public class UsersService : IUsersService
{
    List<User> resultList = new List<User>()
    {
        new User() { Id = "1", FirstName = "Bill", LastName = "Smith" },
        new User() { Id = "2", FirstName = "Bill", LastName = "Smith" },
        new User() { Id = "3", FirstName = "Bill", LastName = "Smith" },
        new User() { Id = "4", FirstName = "Bill", LastName = "Smith" }
    };

    public List<User> GetUsersList()
    {
       return resultList;
    }
}