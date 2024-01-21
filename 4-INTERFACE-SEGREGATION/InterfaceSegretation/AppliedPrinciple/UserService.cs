namespace InterfaceSegretation.AppliedPrinciple
{
    public class UserService : IBasicActions<User>, IEditableActions<User>
    {
        public void Add(User entity)
        {
            Console.WriteLine("Create User");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Delete User");
        }

        public User Get(int id)
        {
            Console.WriteLine("Get User");
            return new User();
        }

        public List<User> GetAll()
        {
            Console.WriteLine("Get All Users");
            return new List<User>();
        }

        public void Update(User entity)
        {
            Console.WriteLine("Update User");
        }
    }
}
