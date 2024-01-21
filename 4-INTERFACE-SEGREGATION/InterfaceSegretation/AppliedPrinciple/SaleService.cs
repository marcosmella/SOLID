namespace InterfaceSegretation.AppliedPrinciple
{
    public class SaleService : IBasicActions<Sale>
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
    }
}
