namespace InterfaceSegretation
{
    public interface ICrud<T>
    {
        public T Get(int id);
        public List<T> GetAll();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Sale
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }

    public class UserService : ICrud<User>
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

    //Not implement All methods. It's not scalable.
    public class SaleService : ICrud<Sale>
    {
        public void Add(Sale entity)
        {
            Console.WriteLine("Add Sale");
        }

        public Sale Get(int id)
        {
            Console.WriteLine("Get Sale");
            return new Sale();
        }

        public List<Sale> GetAll()
        {
            Console.WriteLine("Get All Sales");
            return new List<Sale>();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Sale entity)
        {
            throw new NotImplementedException();
        }
    }
}


