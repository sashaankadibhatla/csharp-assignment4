using System;
using display;
namespace csharp_assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
             string ch1=null;
             Display obj=new Display();
            while(true){
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1.Display the contents");
                Console.WriteLine("2.Sort the contents based on basis of Product Name");
                Console.WriteLine("3.Display the contents by searching by our own");
                Console.WriteLine("4.Delete on your own choice and display the contents");
                Console.WriteLine("5.Exit");
                int choice=int.Parse(Console.ReadLine());
               
                switch(choice){
                    case 1: Console.WriteLine("---------------------------------------------------------");
                            obj.DisplayAll();
                            break;
                    case 2: Console.WriteLine("---------------------------------------------------------");
                            obj.displaySortedProducts();
                            break;
                    case 3: Console.WriteLine("---------------------------------------------------------");
                            string str=Console.ReadLine();
                            obj.DisplayFound(str);
                            break;
                    case 4: do
                                        {
                                            Console.WriteLine("-------------------------------------------");
                                            Console.WriteLine("Select the following options");
                                            Console.WriteLine("1.Delete at a particular index");
                                            Console.WriteLine("2.Delete items with certain inbuilt condition");
                                            Console.WriteLine("3.Delete item in particular range");
                                            int choice1=int.Parse(Console.ReadLine());
                                            switch (choice1)
                                            {
                                                case 1:
                                                        Console.WriteLine("enter the index where the element should be deleted");
                                                        int num=int.Parse(Console.ReadLine());
                                                        obj.DisplayAfterDeletion(num);
                                                        break;
                                                case 2:Console.WriteLine("delete the products having rate>100");
                                                        obj.DisplayAfterDeletion();
                                                        break;
                                                case 3: Console.WriteLine("enter the start and end index in the range to delete");
                                                        int start=int.Parse(Console.ReadLine());
                                                        int end=int.Parse(Console.ReadLine());
                                                        obj.DisplayAfterDeletion(start,end);
                                                        break;
                                                default:Console.WriteLine("please enter correct input");
                                                        break;
                                            }
                                        Console.WriteLine("do you want to still delete yes/no");
                                         ch1=Console.ReadLine();

                                        }while(ch1.ToUpper()=="YES");
                                        break;
                    case 5: Environment.Exit(0);
                            break;

                }
            }
        }
    }
}
