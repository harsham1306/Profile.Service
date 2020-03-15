using System.Collections.Generic;

public interface IUsersRepository
{
    List<User> GetListofUsers();
}

public class UsersRepository : IUsersRepository
{
    List<User> resultList = new List<User>()
    {
        new User() { Id = "1", FirstName = "Bill", LastName = "Smith" },
        new User() { Id = "2", FirstName = "Bill", LastName = "Smith" },
        new User() { Id = "3", FirstName = "Bill", LastName = "Smith" },
        new User() { Id = "4", FirstName = "Bill", LastName = "Smith" }
    };
    public List<User> GetListofUsers()
    {
        return resultList;
    }
}