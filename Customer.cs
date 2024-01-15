namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
           var calculator = new RateCalculator();
            var Rating = calculator.Calculate(this);

                Console.WriteLine("Promoted to level 2");
        }

    }
}