using System.Collections.Generic;

public class User
{
    public string Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public class UsersList
    {
        public List<User> ListofUsers { get; set; }
    }
}