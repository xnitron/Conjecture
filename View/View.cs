using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollarzConjecture;
using CollarzConjecture.Core.Interfaces;

namespace CollarzConjecture
{
    public class View : IObserver
    {
        private Model model;
        private Controller controller;

        public View(Model model, Controller controller)
        {
            this.model = model;
            this.controller = controller;

            this.model.RegisterObserver(this);
        }

        public void Update()
        {
            Console.WriteLine(model.Counter);
        }

        public void EnterNumber()
        {
            try
            {
                Console.Write("Enter an even number: ");
                string num = Console.ReadLine();
                controller.CheckingNum(num);
            }
            catch (Exception)
            {
                Console.WriteLine("ErrorView");
            }
        }

        public void ShowCounter()
        {
            Console.Write("Couter: ");
            controller.GetCounter();

            Console.ReadKey();
        }

        public void ShowError(string err)
        {
            Console.WriteLine(err);
        }
    }
}
