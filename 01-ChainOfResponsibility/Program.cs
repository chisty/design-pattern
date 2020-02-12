using System;

namespace _01_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();

            Method2();

            Console.ReadKey();
        }


        private static void Method1()
        {
            var msWordHandler = new MSWordHandler();
            var jsonHandler = new JSONHandler();
            var xmlHandler = new XmlHandler();
            var handlerChain = new Handlers();
            handlerChain.SetNext(xmlHandler).SetNext(jsonHandler).SetNext(msWordHandler);
            handlerChain.Handle("Chisty");
        }


        private static void Method2()
        {
            var msWordHandler = new MSWordHandler();
            var jsonHandler = new JSONHandler();
            var xmlHandler = new XmlHandler();
            var handlerChain = new Handlers().SetNext(xmlHandler.SetNext(jsonHandler.SetNext(msWordHandler)));
            handlerChain.Handle("Chisty");
        }
    }
}
