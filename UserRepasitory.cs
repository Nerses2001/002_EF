namespace _002_EF
{
    internal class UserRepasitory
    {
        public static void AddUserToDatabase(User user)
        {
            using EfContext dbContext = new();
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        public static void GetUsersFromDatabase()
        {
            using EfContext dbContext = new();
            var users = dbContext.Users.ToList();
            Console.WriteLine("Getting all users........");

            foreach (var user in users)
            {
                Console.WriteLine($"UserId = {user.Id}, UserName = {user.Fname}, Last Name = {user.Lname}, Age = {user.Age}");
            }
        }
        public static void UpdateUserInDatabase(User updatedUser)
        {
            using EfContext dbContext = new();
            var existingUser = dbContext.Users.FirstOrDefault();

            if (existingUser != null && existingUser.Id == 1)
            {

                existingUser.Lname = updatedUser.Lname;
                existingUser.Fname = updatedUser.Fname;
                existingUser.Age = updatedUser.Age;
                dbContext.Users.Update(existingUser);
                dbContext.SaveChanges();

                Console.WriteLine("User updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
 
    }
}
