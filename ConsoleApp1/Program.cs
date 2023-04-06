using MasterDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        internal class Bacon { }
        internal class Coffee { }
        internal class Egg { }
        internal class Juice { }
        internal class Toast { }

        static async Task Main(string[] args)
        {

            List<AnswerDetail> answersList = new List<AnswerDetail>();
            answersList.Add(new AnswerDetail()
            {
                Id = 1,
                Answer = "Delhi",
                QuestionId = 1
            });
            answersList.Add(new AnswerDetail()
            {
                Id = 2,
                Answer = "Gandhinagar",
                QuestionId = 1
            });
            answersList.Add(new AnswerDetail()
            {
                Id = 3,
                Answer = "Amrutsar",
                QuestionId = 1
            });
            answersList.Add(new AnswerDetail()
            {
                Id = 4,
                Answer = "Benguluru",
                QuestionId = 1
            });
            answersList.Add(new AnswerDetail()
            {
                Id = 5,
                Answer = "Tiger",
                QuestionId = 2
            });
            answersList.Add(new AnswerDetail()
            {
                Id = 6,
                Answer = "Lion",
                QuestionId = 2
            });
            answersList.Add(new AnswerDetail()
            {
                Id = 7,
                Answer = "Elephant",
                QuestionId = 2
            });
            answersList.Add(new AnswerDetail()
            {
                Id = 8,
                Answer = "Deer",
                QuestionId = 2
            });


            List<QuestionDetail> questionList = new List<QuestionDetail>();
            QuestionDetail Que1 = new QuestionDetail()
            {
                Id = 1,
                Question = "What Capital of India?",
                CorrectAnswerId = 1
            };
            QuestionDetail Que2 = new QuestionDetail()
            {
                Id = 2,
                Question = "Which of the following is considered the national animal of India?",
                CorrectAnswerId = 5
            };
            questionList.Add(Que1);
            questionList.Add(Que2);


            var testDetail = questionList.FirstOrDefault();
            testDetail.Answers = answersList.Where(x=> x.QuestionId == testDetail.Id).ToList();

            Console.WriteLine($"Question:{testDetail.Question}");
            int count = 1;
            foreach (var item in testDetail.Answers)
            {
                Console.WriteLine($"{count}. {item.Answer}");
                count++;
            }

            Console.WriteLine("Please enter the correct answer name:");

            string enteredAnswer = Convert.ToString(Console.ReadLine());

            string correctAnswer = answersList.FirstOrDefault(x => x.Id == testDetail.CorrectAnswerId).Answer;
            if (enteredAnswer.ToLowerInvariant() == correctAnswer.ToLowerInvariant())
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine($"Wrong ! Correct answer is {correctAnswer}");
            }

            //Console.WriteLine("Hello World!");

            //Coffee cup = PourCoffee();
            //Console.WriteLine("coffee is ready");

            //Egg eggs = await FryEggsAsync(2);
            //Console.WriteLine("eggs are ready");

            //Bacon bacon = await FryBaconAsync(3);
            //Console.WriteLine("bacon is ready");

            //Toast toast = await ToastBreadAsync(2);
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("toast is ready");

            //Juice oj = PourOJ();
            //Console.WriteLine("oj is ready");
            //Console.WriteLine("Breakfast is ready!");


        }


        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

    }
}
