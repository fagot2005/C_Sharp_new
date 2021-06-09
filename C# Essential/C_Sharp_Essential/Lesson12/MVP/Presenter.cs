using System;

namespace MVP
{
    public class Presenter
    {
        private Model model;
        private Program view;


        public Presenter()
        {
            model = new Model();
            //this.view = view;
            Program.Event += Program_Event;
        }

        private void Program_Event(string str)
        {
            Console.WriteLine(model.Logic(str));
        }
    }
}