using System;
namespace product
{
    class Program
    {
        static void Main(string[] args)
        {
             string strContinue=null;
             Display objDisplay=new Display();
            while(true)
            {
                try{
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1.Display the contents");
                Console.WriteLine("2.Sort the contents based on basis of Product Name");
                Console.WriteLine("3.Display the contents by searching by our own");
                Console.WriteLine("4.Delete on your own choice and display the contents");
                Console.WriteLine("5.Exit");
                int intFirstSwitch=int.Parse(Console.ReadLine());
               
                switch(intFirstSwitch){
                    case 1: Console.WriteLine("---------------------------------------------------------");
                            objDisplay.DisplayAll();
                            break;
                    case 2: Console.WriteLine("---------------------------------------------------------");
                            objDisplay.displaySortedProducts();
                            break;
                    case 3: Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("enter the product to be searched");
                            string strFind=Console.ReadLine();
                            objDisplay.DisplayFound(strFind);
                            break;
                    case 4: do
                                        {
                                            Console.WriteLine("-------------------------------------------");
                                            Console.WriteLine("Select the following options");
                                            Console.WriteLine("1.Delete at a particular index");
                                            Console.WriteLine("2.Delete items with certain inbuilt condition");
                                            Console.WriteLine("3.Delete item in particular range");
                                            Console.WriteLine("4.Delete item with particular product name");
                                            int intSecondSwitch=int.Parse(Console.ReadLine());
                                            switch (intSecondSwitch)
                                            {
                                                case 1:
                                                        objDisplay.DisplayProduct();
                                                        Console.WriteLine("enter the index where the element should be deleted");
                                                        int intIndex=int.Parse(Console.ReadLine());
                                                        objDisplay.DisplayAfterDeletion(intIndex);
                                                        break;
                                                case 2:Console.WriteLine("delete the products having rate>90");
                                                        objDisplay.DisplayAfterDeletion();
                                                        break;
                                                case 3: objDisplay.DisplayProduct();
                                                        Console.WriteLine("enter the start index");
                                                        int intStart=int.Parse(Console.ReadLine());
                                                        Console.WriteLine("enter the end index");
                                                        int intEnd=int.Parse(Console.ReadLine());
                                                        objDisplay.DisplayAfterDeletion(intStart,intEnd);
                                                        break;
                                                case 4: objDisplay.DisplayProduct();
                                                        Console.WriteLine("enter the product name to be deleted");
                                                        string strDelete=Console.ReadLine();
                                                        objDisplay.DisplayAfterDeletion(strDelete);
                                                        break;
                                                default:Console.WriteLine("please enter correct input");
                                                        break;
                                            }
                                        Console.WriteLine("do you want to still delete (enter yes to continue) any other inputs it doesnt continue");
                                         strContinue=Console.ReadLine();
                                        }while(strContinue.ToUpper()=="YES");
                                        break;
                    case 5: Environment.Exit(0);
                            break;

                }
                }catch(Exception ex)
                {
                        Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
