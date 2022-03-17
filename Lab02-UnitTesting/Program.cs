using System;

namespace Lab02_UnitTesting
{
    public class Program
    {



        public static decimal ViewBalance(decimal balance)
        {
          
            decimal d = balance;

                
            

            return d;
        }

        public static decimal Withdraw(decimal balance , decimal amount) {


            balance -= amount;

            return balance;
        }

        public static decimal Deposit(decimal balance, decimal amount)
        {


            balance += amount;

            return balance;

        }


        public static int SearchForAccount(string userInput) {

            string[] acounts = { "ahmad", "omar", "fuad" };

            int accountIndex = -1;

            for (int i = 0; i < acounts.Length; i++)
            {
                if (userInput == acounts[i])
                {

                    return i;
                }

            }

            return accountIndex;
        }
      

        

        public static void UserInterface() {



            decimal[] balanceAllAccount = { 100, 50, 30 };


            Console.WriteLine("Hello enter your  acount name: ( \" ahmad \" or \" omar \" of \" fuad \")");


            ////// check user Account 
            int accountIndex = -1;
            do
            {

                Console.WriteLine("This id is NOT correct, please enter correct id acount");
                string userAccount = Console.ReadLine();
                accountIndex = SearchForAccount(userAccount.ToLower());
            } while (accountIndex == -1);






            Console.WriteLine("How we can help you today");

            string userChose = null;


            /// the first do while for chose to keep the user in the account 
            /// ( to let the user do a deposit or withdraw of ViewBalance as many as user want until he enters 0 and makes the condition = false so the loop is brake)
            do
            {

                Console.WriteLine("for Deposit mouny to your acount press:- 1 \n for Withdraw mouny from your acount press:- 2 \n for view balance in your acount press:- 3 \n" +
                                    "for logout from your acount press:- 0 \n ");

                userChose = Console.ReadLine();
                //// this if do the interface work that separates what we want to use from function depending on the number that shows for the user in the previous  "Console.WriteLine "
                ///(if user input 1 for Deposit Function /2 for withdraw Function/3 for viewbalance Function /0 for getout the do-while and end the project/and the else statement if 
                ///the user input an anything else )
                if (userChose == "1" || userChose == "2")
                {
                    string userInputAmount = null;
                    bool checkNumber = true;
                    decimal monyAmount = 0;

                    ////this do-while and nested if work to gather to check the user validation (do-while to check if the user input decimal or not)
                    ////if he input a decimal value then the turn for Second if statement that checks the validation if the user enters a number within the account balance (0< and less than balance)
                    ///the first if is for choosing the function is withdraw (0 < and less than all money in his account ) or Deposit (0 <) just no need to know the amount in the account
                    do
                    {
                        Console.WriteLine("input money amount :-");
                        userInputAmount = Console.ReadLine();

                        bool numTest = decimal.TryParse(userInputAmount, out monyAmount);
                        // first if 
                        if (numTest)
                        {

                            //// Second if 
                            if (userChose == "1")
                            {
                                if (0 < monyAmount)
                                {

                                    checkNumber = false;
                                }
                                else
                                {
                                    Console.WriteLine("out of range try anther amount");
                                }
                            }
                            //// Second if 
                            else if (userChose == "2")
                            {
                                if (0 < monyAmount && monyAmount <= balanceAllAccount[accountIndex])
                                {

                                    checkNumber = false;
                                }
                                else
                                {
                                    Console.WriteLine("out of range try anther amount");
                                }

                            }






                        }
                        else
                        {
                            Console.WriteLine("your input is not a number try again");
                        }

                    } while (checkNumber);



                    /// this if for calling the function after all the check validation in the previous do-while 
                    if (userChose == "1")
                    {

                        balanceAllAccount[accountIndex] = Deposit(balanceAllAccount[accountIndex], monyAmount);
                        Console.WriteLine("Transaction Done");
                    }
                    else if (userChose == "2")
                    {

                        balanceAllAccount[accountIndex] = Withdraw(balanceAllAccount[accountIndex], monyAmount);
                        Console.WriteLine("Transaction Done");
                    }


                }

                else if (userChose == "3")
                {
                    Console.WriteLine("your balance :-" + ViewBalance(balanceAllAccount[accountIndex]) + "$");


                }else if (userChose == "0") {

                    Console.WriteLine("Have a good day , your bank with you everywhere");

                }
                else{


                    Console.WriteLine("invalid input .... try again");

                }
                    

                

            } while (userChose != "0");


        



        }

        static void Main(string[] args)
        {





            UserInterface();


            Console.ReadKey();

        }
    }
}
