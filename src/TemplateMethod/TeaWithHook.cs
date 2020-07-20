using System;

namespace TemplateMethod
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }

            return false;
        }

        private string GetUserInput()
        {
            string answer = null;

            Console.WriteLine("Would you like lemon with your tea (y/n)? ");

            try
            {
                answer = Console.ReadLine() ?? "no";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }

            return answer;
        }
    }
}
