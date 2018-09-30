using System;

namespace CollarzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            Controller controller = new Controller(model);
        }
    }
}
