namespace NM101_Basket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basket1 = new Basket();
            var basket2 = new Basket();

            basket1.Name = "Groceries";
            
            var item1 = new Dairy("milk1", 1.20, 1);
            var item2 = new Fruit("apple", 1.40, 0.500);
            var item3 = new Fruit("pineapple", 3, 1);
            var item4 = new Dairy("milk2", 1.30, 2);
            item4.AddFatPercentage(2.5);

            basket1.AddItem(item1);
            basket1.AddItem(item2);
            basket1.AddItem(item3);
            basket1.AddItem(item4);

            var item5 = new Meat("chicken legs", 4.00, 0.800);
            item5.AddCalories(600);
            var item6 = new HouseholdItem("toilet paper", 3.00, 1);
            item5.AddCalories(600);
            var item7 = new Fruit("banana", 2.30, 0.750);
            item7.AddCalories(400);

            basket2.AddItem(item5);
            basket2.AddItem(item6);
            basket2.AddItem(item7);

            
            Console.WriteLine(item1.ShowFatPercentage());
            Console.WriteLine(item4.ShowFatPercentage());
            Console.WriteLine("-------------");
            Console.WriteLine(basket1.ShowItems());
            Console.WriteLine("-------------");
            Console.WriteLine(basket2.ShowItems());
            Console.WriteLine("-------------");
            Console.WriteLine("chicken calories: " + item5.ShowCalories());
            Console.WriteLine("T.paper calories: " + item6.ShowCalories());
            Console.WriteLine("banana calories: " + item7.ShowCalories());
            Console.WriteLine("-------------");
            Console.WriteLine(basket1.CountTotalCalories());
            Console.WriteLine(basket2.CountTotalCalories());
        }

        
    }
}