using _002_EF;

User newUser = new()
{
    Fname = "Emily",
    Lname = "Davis",
    Age = 28
};
UserRepasitory.AddUserToDatabase(newUser);
Console.WriteLine("User added to the database.");

Console.WriteLine("All users in the database:");
UserRepasitory.GetUsersFromDatabase();

User updatedUser = new()
{
    Fname = "Michael",
    Lname = "Johnson",
    Age = 50
};

UserRepasitory.UpdateUserInDatabase(updatedUser);
Console.WriteLine("User updated in the database.");