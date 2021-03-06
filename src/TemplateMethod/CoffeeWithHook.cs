﻿using System;

namespace TemplateMethod
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
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

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

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
