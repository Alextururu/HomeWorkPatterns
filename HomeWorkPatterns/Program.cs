
namespace HomeWorkPatterns
{
    public static class Program
    {
        public static void Main()
        {
            Account acc = new Account(new SalaryeType(), 10, 500);
            acc.Calculate();
            Account acc1 = new Account(new SimpleType(),10,500);
            acc1.Calculate();
        }
    }
}
