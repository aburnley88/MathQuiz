using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ISTA_421MathQuiz
{
    class Test
    {
     
       public void Welcome()
        {
            try
            {
                Console.WriteLine(
                        "--------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(
                        "-----------------------------------------Welcome to My Math Game----------------------------------------");
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Select which version you would like to play\n");
                    Console.WriteLine("Enter 1 for Addition\n");
                    Console.WriteLine("Enter 2 for subtraction\n");
                    Console.WriteLine("Enter 3 for multiplication\n");
                    Console.WriteLine("Enter 4 for division\n\n\n");
                    Console.WriteLine(
                        "--------------------------------------------------------------------------------------------------------");

                    string response = Console.ReadLine();
                    int reply = int.Parse(response);
                    if (reply < 1 || reply > 4)
                    { 
                        throw new FormatException();
                        
                    }
                    if (reply == 1)
                        AdditionDifficultySelector();
                    if (reply == 2)
                        SubtractionDifficultySelector();
                    if (reply == 3)  
                        MultiplicatonDifficultySelector();
                    if (reply == 4)
                        DivisionDifficultySelector();

            }
            catch (FormatException args)
            {
                Console.WriteLine(args.Message);
                Thread.Sleep(1000);
                Console.Clear();
                Welcome();
            }
        }

        public void Grade(decimal numcorrect, decimal numquestions)
        {
            Console.WriteLine($"You scored {numcorrect} out of {numquestions} correctly!");
            Thread.Sleep(1000);
            decimal percent = (numcorrect / numquestions) * 100;
            Decimal.Round(percent, 2);
            Console.WriteLine($"Great Job! That's a {percent}%");
            Thread.Sleep(1000);
            PlayAgain();

        }

        public void PlayAgain()
        {
            Console.Clear();
            Console.WriteLine("Do you want to play again?" + "\n\nEnter 1 for yes and 2 for no");
            string response = Console.ReadLine();
            if (response == "1")
            {
                Welcome();
            }

            if (response == "2")
            {
                Console.WriteLine("Goodbye");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Please enter a valid response");
                Thread.Sleep(1000);
                PlayAgain();
            }
        }

        public void AdditionDifficultySelector()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Which difficulty do you want to play?\n");
                Console.WriteLine("Enter 1 for Easy\n");
                Console.WriteLine("Enter 2 for Medium\n");
                Console.WriteLine("Enter 3 for Hard\n");

                string response = Console.ReadLine();
                if (response == "1")
                    AdditionTest();
                if (response == "2")
                    AdditionTest(response);
                if (response == "3")
                    AdditionTestHard();
                else
                {
                    throw new FormatException();
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                AdditionDifficultySelector();
            }
        }

        public void SubtractionDifficultySelector()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Which difficulty do you want to play?\n");
                Console.WriteLine("Enter 1 for Easy\n");
                Console.WriteLine("Enter 2 for Medium\n");
                Console.WriteLine("Enter 3 for Hard\n");

                string response = Console.ReadLine();
                if (response == "1")
                    SubtractionTest();
                if (response == "2")
                    SubtractionTest(response);
                if (response == "3")
                    SubtractionTestHard();
                else
                {
                    throw new FormatException();
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                SubtractionDifficultySelector();
            }
        }
        public void MultiplicatonDifficultySelector()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Which difficulty do you want to play?\n");
                Console.WriteLine("Enter 1 for Easy\n");
                Console.WriteLine("Enter 2 for Medium\n");
                Console.WriteLine("Enter 3 for Hard\n");

                string response = Console.ReadLine();
                if (response == "1")
                    MultiplicationTest();
                if (response == "2")
                    MultiplicationTest(response);
                if (response == "3")
                    MultiplicationTestHard();
                else
                {
                    throw new FormatException();
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                MultiplicatonDifficultySelector();
            }
        }
        public void DivisionDifficultySelector()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Which difficulty do you want to play?\n");
                Console.WriteLine("Enter 1 for Easy\n");
                Console.WriteLine("Enter 2 for Medium\n");
                Console.WriteLine("Enter 3 for Hard\n");

                string response = Console.ReadLine();
                if (response == "1")
                    DivisionTest();
                if (response == "2")
                    DivisionTest(response);
                if (response == "3")
                    DivisionTestHard();
                else
                {
                    throw new FormatException();
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                MultiplicatonDifficultySelector();
            }
        }
        public void AdditionTest()
        {
            Random r = new Random();
            int A;
            int B;
            int question = 1;
            decimal numcorrect = 0;
            int count = 0;
            

            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    
                    AdditionTest();
                }

                do
                {
                    A = r.Next(0, 20);
                    B = r.Next(0, 20);
                    int correctans = (A + B);

                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} + {B} = ?");
                    string useranswer = Console.ReadLine();
                    int UserAnswer = int.Parse(useranswer);
                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                      
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                string medium = "medium";
                AdditionTest(medium);
            }
        }
        public void AdditionTest(string medium)
        {
            Random r = new Random();
            int A;
            int B;
            int question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    string x = "medium";
                    AdditionTest(x);
                }

                do
                {
                    A = r.Next(0, 999);
                    B = r.Next(0, 999);
                    int correctans = (A + B);

                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} + {B} = ?");
                    string useranswer = Console.ReadLine();
                    int UserAnswer = int.Parse(useranswer);
                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);

                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                string x = "medium";
                AdditionTest(x);
            }
        }
        public void AdditionTestHard()
        {
            Random r = new Random();
            int A;
            int B;
            int question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    AdditionTestHard();
                }

                do
                {
                    A = r.Next(0, 9999);
                    B = r.Next(0, 9999);
                    int correctans = (A + B);

                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} + {B} = ?");
                    string useranswer = Console.ReadLine();
                    int UserAnswer = int.Parse(useranswer);
                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);

                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                AdditionTest();
            }
        }
        public void SubtractionTest()
        {
            Random r = new Random();
            decimal A;
            decimal B;
            decimal question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    SubtractionTest();
                }

                do
                {
                    A = r.Next(0, 12);
                    B = r.Next(0, 12);

                    if (B > A)
                    {
                        decimal C = A;
                        A = B;
                        B = C;
                    }
                    decimal correctans = A - B;


                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} - {B}  = ?");
                    string useranswer = Console.ReadLine();
                    decimal UserAnswer = System.Convert.ToDecimal(useranswer);


                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                SubtractionTest();
            }
        }

        public void SubtractionTest(string medium)
        {
            Random r = new Random();
            decimal A;
            decimal B;
            decimal question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    string m = "medium";
                    SubtractionTest(m);
                }

                do
                {
                    A = r.Next(0, 500);
                    B = r.Next(0, 500);

                    if (B > A)
                    {
                        decimal C = A;
                        A = B;
                        B = C;
                    }
                    decimal correctans = A - B;


                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} - {B}  = ?");
                    string useranswer = Console.ReadLine();
                    decimal UserAnswer = System.Convert.ToDecimal(useranswer);


                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                string med = "medium";
                SubtractionTest(med);
            }
        }
        public void SubtractionTestHard()
        {
            Random r = new Random();
            decimal A;
            decimal B;
            decimal question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    SubtractionTestHard();
                }

                do
                {
                    A = r.Next(0, 999);
                    B = r.Next(0, 999);

                    if (B > A)
                    {
                        decimal C = A;
                        A = B;
                        B = C;
                    }
                    decimal correctans = A - B;


                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} - {B}  = ?");
                    string useranswer = Console.ReadLine();
                    decimal UserAnswer = System.Convert.ToDecimal(useranswer);


                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                SubtractionTestHard();
            }
        }

        public void MultiplicationTest()
        {
            Random r = new Random();
            int A;
            int B;
            int question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                  MultiplicationTest();  
                }

                do
                {
                    A = r.Next(0, 15);
                    B = r.Next(0, 15);
                    int correctans = (A * B);

                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} * {B} = ?");
                    string useranswer = Console.ReadLine();
                    int UserAnswer = int.Parse(useranswer);
                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                AdditionTest();
            }
        }
        public void MultiplicationTest(string medium)
        {
            Random r = new Random();
            int A;
            int B;
            int question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    MultiplicationTest(num);
                }

                do
                {
                    A = r.Next(0, 30);
                    B = r.Next(0, 30);
                    int correctans = (A * B);

                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} * {B} = ?");
                    string useranswer = Console.ReadLine();
                    int UserAnswer = int.Parse(useranswer);
                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                string m = "medium";
                MultiplicationTest(m);
            }
        }
        public void MultiplicationTestHard()
        {
            Random r = new Random();
            int A;
            int B;
            int question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    MultiplicationTest(num);
                }

                do
                {
                    A = r.Next(0, 100);
                    B = r.Next(0, 100);
                    int correctans = (A * B);

                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} * {B} = ?");
                    string useranswer = Console.ReadLine();
                    int UserAnswer = int.Parse(useranswer);
                    if (UserAnswer == correctans)
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                
                MultiplicationTestHard();
            }
        }
        public void DivisionTest()
        {
            Random r = new Random();
            decimal A;
            decimal B;
            decimal question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    DivisionTest();
                }

                do
                {
                    A = r.Next(0, 12);
                    B = r.Next(1, 12);
                    decimal correctans = Decimal.Round((A / B),2);
                    

                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} / {B} = (Answers 2 decimal places for non whole numbers)");
                    string useranswer = Console.ReadLine();
                    decimal UserAnswer = System.Convert.ToDecimal(useranswer);
                    
                    
                    if (UserAnswer == correctans || UserAnswer == correctans + System.Convert.ToDecimal(.01) || UserAnswer == correctans - System.Convert.ToDecimal(.01))
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                DivisionTest();
            }
        }
        public void DivisionTest(string medium)
        {
            Random r = new Random();
            decimal A;
            decimal B;
            decimal question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    string m = "medium";
;                    DivisionTest(m);
                }

                do
                {
                    A = r.Next(0, 20);
                    B = r.Next(1, 20);
                    decimal correctans = Decimal.Round((A / B), 2);


                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} / {B} = (Answers 2 decimal places for non whole numbers)");
                    string useranswer = Console.ReadLine();
                    decimal UserAnswer = System.Convert.ToDecimal(useranswer);


                    if (UserAnswer == correctans || UserAnswer == correctans + System.Convert.ToDecimal(.01) || UserAnswer == correctans - System.Convert.ToDecimal(.01))
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                string m = "medium";
                DivisionTest(m);
            }
        }
        public void DivisionTestHard()
        {
            Random r = new Random();
            decimal A;
            decimal B;
            decimal question = 1;
            decimal numcorrect = 0;
            int count = 0;


            try
            {
                Console.Clear();
                Console.WriteLine("How many questions would you like to take? (Max 10)");
                string num = Console.ReadLine();
                int numquestions = int.Parse(num);
                if (numquestions > 10)
                {
                    DivisionTestHard();
                }

                do
                {
                    A = r.Next(0, 99);
                    B = r.Next(1, 99);
                    decimal correctans = Decimal.Round((A / B), 2);


                    Console.Clear();
                    Console.WriteLine($"Question {question}) {A} / {B} = (Answers 2 decimal places for non whole numbers)");
                    string useranswer = Console.ReadLine();
                    decimal UserAnswer = System.Convert.ToDecimal(useranswer);


                    if (UserAnswer == correctans || UserAnswer == correctans + System.Convert.ToDecimal(.01) || UserAnswer == correctans - System.Convert.ToDecimal(.01))
                    {
                        Console.WriteLine("You got it right!");
                        Thread.Sleep(1000);
                        numcorrect++;
                        count++;
                        question++;
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine($"The correct answer is {correctans}");
                        Thread.Sleep(1000);
                        count++;
                        question++;
                    }

                    numquestions--;

                    if (numquestions == 0)
                    {
                        Grade(numcorrect, count);
                    }

                } while (numquestions > 0);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                DivisionTestHard();
            }
        }

    }
}
    

