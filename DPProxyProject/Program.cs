namespace DPProxyProject
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }

    interface IGroupUser
    {
        User UserGetById(int id);
        void Close();
    }
    class Departament : IGroupUser
    {
        UserContext userContext;

        public void Close()
        {
            UserContext.
        }

        public User UserGetById(int id)
        {
            return new User();
        }
    }

    class DepartamentProxy : IGroupUser
    {
        List<User> users;
        Departament departament;

        public void Close()
        {
            // copy data to Departament
            //Close().
        }

        public User UserGetById(int id)
        {
            return new User();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}