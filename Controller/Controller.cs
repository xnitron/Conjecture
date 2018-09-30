using System;

namespace CollarzConjecture
{
    public class Controller
    {
        private Model model;
        private View view;
        private int number;

        public Controller(Model model)
        {
            this.model = model;
            view = new View(model, this);

            view.EnterNumber();
            view.ShowCounter();
        }

        public int CheckingNum(string num)
        {
            try
            {
                bool isNumerical = int.TryParse(num, out number);
                if (isNumerical)
                {
                    number = Convert.ToInt32(num);
                }
                else
                {
                    view.ShowError("\tError, only an even number");
                    view.EnterNumber();
                }

                if (number < 1)
                {
                    view.ShowError("\tEnter an even number");
                    view.EnterNumber();
                }
            }
            catch (Exception)
            {
                view.ShowError("Error Controller");
            }
            return number;
        }

        public void GetCounter()
        {
            try
            {
                model.GetCounter(number);     
            }
            catch (Exception)
            {
                view.ShowError("Error counter");
            }
        }
    }
}
