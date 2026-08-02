using System;
namespace P3_Expense
{
    class Expense
    {
        public string Category;
        public double Budget;
        public double Spent;

        public Expense(string category, double budget)
        {
            Category = category;
            Budget = budget;
            Spent = 0;
        }

        public void RecordExpense(double amount)
        {
            if (Spent + amount > Budget)
            {
                Console.WriteLine("WARNING! Budget Exceeded for " + Category);
            }
            else
            {
                Spent += amount;
                Console.WriteLine("Expense Recorded Successfully.");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine(Category + "\tBudget: " + Budget +
                              "\tSpent: " + Spent +
                              "\tRemaining: " + (Budget - Spent));
        }
    }

    class SpecialExpense : Expense
    {
        public SpecialExpense(string category, double budget) : base(category, budget)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== EXPENSE TRACKER ==========");

            Console.Write("Enter Your Total Pocket Money: ");
            double pocketMoney = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDefine Your Budget");

            Console.Write("Food Budget: ");
            double foodBudget = Convert.ToDouble(Console.ReadLine());

            Console.Write("Travel Budget: ");
            double travelBudget = Convert.ToDouble(Console.ReadLine());

            Console.Write("Shopping Budget: ");
            double shoppingBudget = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entertainment Budget: ");
            double entertainmentBudget = Convert.ToDouble(Console.ReadLine());

            Console.Write("Medical Budget: ");
            double medicalBudget = Convert.ToDouble(Console.ReadLine());

            double totalBudget = foodBudget + travelBudget + shoppingBudget + entertainmentBudget + medicalBudget;

            if (totalBudget > pocketMoney)
            {
                Console.WriteLine("\nEntered Budget is Greater than Pocket Money!");
                return;
            }

            Expense food = new Expense("Food", foodBudget);
            Expense travel = new Expense("Travel", travelBudget);
            Expense shopping = new Expense("Shopping", shoppingBudget);
            Expense entertainment = new Expense("Entertainment", entertainmentBudget);

            SpecialExpense medical = new SpecialExpense("Medical", medicalBudget);

            while (true)
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Add Food Expense");
                Console.WriteLine("2. Add Travel Expense");
                Console.WriteLine("3. Add Shopping Expense");
                Console.WriteLine("4. Add Entertainment Expense");
                Console.WriteLine("5. Add Medical Expense");
                Console.WriteLine("6. View Expense Report");
                Console.WriteLine("7. Exit");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                double amount;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Amount of the Food Expense: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        food.RecordExpense(amount);
                        break;

                    case 2:
                        Console.Write("Enter the Amount of the Travel Expense: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        travel.RecordExpense(amount);
                        break;

                    case 3:
                        Console.Write("Enter the Amount of the Shopping Expense: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        shopping.RecordExpense(amount);
                        break;

                    case 4:
                        Console.Write("Enter the Amount of the Entertainment Expense: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        entertainment.RecordExpense(amount);
                        break;

                    case 5:
                        Console.Write("Enter the Amount of the Medical Expense: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        medical.RecordExpense(amount);
                        break;

                    case 6:
                        Console.WriteLine("\n========== EXPENSE REPORT ==========");

                        food.ShowDetails();
                        travel.ShowDetails();
                        shopping.ShowDetails();
                        entertainment.ShowDetails();
                        medical.ShowDetails();

                        double totalSpent = food.Spent + travel.Spent + shopping.Spent +
                                            entertainment.Spent + medical.Spent;

                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Total Pocket Money : " + pocketMoney);
                        Console.WriteLine("Total Amount Spent : " + totalSpent);
                        Console.WriteLine("Remaining Balance  : " + (pocketMoney - totalSpent));
                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice! Please Try Again.");
                        break;
                }
            }
        }
    }
}
