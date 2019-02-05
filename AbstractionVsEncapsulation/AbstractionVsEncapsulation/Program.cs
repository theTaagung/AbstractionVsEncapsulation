using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionVsEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteProject(new WaterfallProject());
            ExecuteProject(new AgileProject());

        }
        static void ExecuteProject(IProject project)
        {
            project.PrepareDocuments();
            project.DoProgramming();
        }
    }
    interface IProject
    {
        void PrepareDocuments();
        void DoProgramming();
    }
    class WaterfallProject : IProject
    {
        public void DoProgramming()
        {
            PrepareHLD();
            PrepareLLD();
        }

        private void PrepareHLD()
        {
            Console.WriteLine("High Level Design Doc based on requirement.");
        }
        private void PrepareLLD()
        {
            Console.WriteLine("Low Level Design Doc based on HLD.");
        }
        public void PrepareDocuments()
        {
            Console.WriteLine("Program as per DLD.");
        }
    }

    class AgileProject : IProject
    {
        public void PrepareDocuments()
        {
            BasicDocuments();
        }
        private void BasicDocuments()
        {
            Console.WriteLine("Basic document for user story.");
        }

        public void DoProgramming()
        {
            Console.WriteLine("Code the User Story.");
        }
    }
}
