namespace Practice.Condition
{
    public class Discount
    {
        public void Main()
        {


            double Price = Convert.ToDouble(Console.ReadLine());

            if (Price >= 100)
            {
                Price = Price - (Price * 10 / 100);

            }
            Console.WriteLine($"Your bill is : {Price}");

        }

    }
}
