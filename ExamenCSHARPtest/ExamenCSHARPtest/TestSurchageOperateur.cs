using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenCSHARPtest
{
    class TestSurchageOperateur
    {

        public int a;
        public int b;

        public static TestSurchageOperateur operator +(TestSurchageOperateur c, TestSurchageOperateur d)
        {
            TestSurchageOperateur e = new TestSurchageOperateur();
            e.a=c.a + d.a;
            e.b = c.b + d.b;

            return e;
        }

        public override string ToString()
        {
             return "a: " + a.ToString() + "\nb: " + b.ToString();
        }
    }
}


