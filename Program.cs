namespace DefaultImplementOfInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 class1 = new class1();
            IInterface Its;
            Its = class1;
            // Its.select();
            class1.select();
            
        }
        interface IInterface      //In Interface All member are abstract and pure Virtual Function if any class Inpliment interface then It must be override that pure virtual function
        {

            void Insert();
            void Update();
            void Delete();
           void select()
            {
                Console.WriteLine("This is default funcction");
            }


        }
       
        public class class1 : IInterface
        {
            public void Delete()
            {
                Console.WriteLine();
            }

           public void Insert()
            {
                throw new NotImplementedException();
            }

         

            public void Update()
            {
                throw new NotImplementedException();
            }
            public void select()
            {
                Console.WriteLine("This is default funcction write in class");
            }


        }
    }
}

