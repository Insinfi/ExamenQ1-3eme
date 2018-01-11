using System;


Delegate bool Compare(object x, object y);

namespace ExamenCSHARPtest
{

    class Program
    {
        //__________________________________________________________________________
        //static bool CompClient(object x, object y)
        //{
        //    Client tmp1 = (Client)x;
        //    Client tmp2 = (Client)y;
        //    return (tmp1.Dettes < tmp2.Dettes);
        //}


        class BaseClass
        {
            public void Method1()//etape 4 virtual
            {
                Console.WriteLine("Base - Method1");
            }
            public void Method2()//seconde etape //etape3 → new
            {
                Console.WriteLine("Base - Method2");
            }
        }

        class DerivedClass : BaseClass
        {
            //public override void Method1()// etape 4
            //{
            //    Console.WriteLine("Derived - Method1");
            //}
            public new void Method2()
            {
                Console.WriteLine("Derived - Method2");
            }
        }

        


        //__________________________________________________________________________
        static void Main(string[] args)
        {
            TestSurchageOperateur a = new TestSurchageOperateur { a = 10, b = 20 };
            TestSurchageOperateur b = new TestSurchageOperateur { a = 30, b = 40 };


            //BaseClass bc = new BaseClass();
            //DerivedClass dc = new DerivedClass();
            //BaseClass bcdc = new DerivedClass();

            ////bc.Method1();
            ////dc.Method1();
            ////dc.Method2();
            ////bcdc.Method1();
            ////Console.ReadKey();

            //// Output1:  
            //// Base - Method1  
            //// Base - Method1  
            //// Derived - Method2  
            //// Base - Method1  

            //bc.Method1();
            //bc.Method2();
            //dc.Method1();
            //dc.Method2();
            //bcdc.Method1();
            //bcdc.Method2();
            //Console.ReadKey();

            //// Output2:  
            //// Base - Method1  
            //// Base - Method2  
            //// Base - Method1  
            //// Derived - Method2  
            //// Base - Method1  
            //// Base - Method2 
            //Console.WriteLine(a.ToString());

            //a += b;
            //Console.WriteLine(a.ToString());
            //Console.ReadKey();

            Compare comp = delegate (object x, object y)
            {
                Client tmp1 = (Client)x;
                Client tmp2 = (Client)y;
                return (tmp1.Dettes < tmp2.Dettes);
            };
            Client[] tab = { new Client("Dupond", 50.45), new Client("Dubois", 10.0), new Client("Dupont", 15.50) };
            tri(tab, comp);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Le client {0} a {1} euros de dettes", tab[i].Nom, tab[i].Dettes);
            }


        }

        

        static void tri(object[] tab, Compare comp)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (comp(tab[j], tab[i]))
                    {
                        object temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }


    }
}




