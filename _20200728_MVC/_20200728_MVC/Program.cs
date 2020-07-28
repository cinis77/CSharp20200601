using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200728_MVC
{
    interface IViewController
    {
        object M(object model);
    }

    interface IModelController
    {
        void V();
    }

    interface IView
    {
        void V();

        void SetAdapter(IViewController controller);
    }

    interface IModel
    {
        object M(object model);

        void SetAdapter(IModelController controller);
    }

    //Implementacija factory design pattern

    delegate IView ViewFactory();
    delegate IModel ModelFactory();

    class View : IView
    {
        private IViewController _Controller;

        public void SetAdapter(IViewController controller)
        {
            _Controller = controller;
        }

        public void V()
        {
            Console.WriteLine("Iveskite duomenis");
            string duomenys = Console.ReadLine();
            Console.WriteLine((string)_Controller.M(duomenys));
        }
    }

    class Model : IModel
    {
        private IModelController _Controller;

        public void SetAdapter(IModelController controller)
        {
            _Controller = controller;
        }

        public object M(object model)
        {
            return "$" + (string)model + "$";
        }
    }

    class Controller : IViewController, IModelController
    {
        private IModel _Modelis;
        private IView _View;

        public Controller(ModelFactory m, ViewFactory v)
        {
            _Modelis = m();
            _View = v();

            _Modelis.SetAdapter(this);
            _View.SetAdapter(this);
        }

        public object M(object model)
        {
            return _Modelis.M(model);
        }

        public void V()
        {
            _View.V();
        }
    }

    class ModelSuZvaigzdute : IModel
    {
        private IModelController _Controller;

        public void SetAdapter(IModelController controller)
        {
            _Controller = controller;
        }

        public object M(object model)
        {
            return "*" + (string)model + "*";
        }
    }

    class AngluView : IView
    {
        private IViewController _Controller;

        public void SetAdapter(IViewController controller)
        {
            _Controller = controller;
        }

        public void V()
        {
            Console.WriteLine("Please enter the data");
            string duomenys = Console.ReadLine();
            Console.WriteLine((string)_Controller.M(duomenys));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller(ZvaigzdesModel, EnglishViewFactory);
            c.V();
        }

        private static IView ViewFactory()
        {
            return new View();
        }

        private static IView EnglishViewFactory()
        {
            return new AngluView();
        }

        private static IModel ZvaigzdesModel()
        {
            return new ModelSuZvaigzdute();
        }

        private static IModel ModelFactory()
        {
            return new Model();
        }

    }
}
