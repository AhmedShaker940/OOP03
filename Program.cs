namespace Assignment03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Question01
            //Q1  Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?
            /*
             Method Overloading Allow the class to have multible Methods with the same name but with different parameters (One Method with multible tasks)
             Method Overriding the method is already exists in the base class (Parent) but with different implementation in the derived class (Child) (same Method with different implementation)
             */

            //b)  What is the difference between Static Binding and Dynamic Binding?
            /*
             Static Binding is a technique that happens in the compile time by compiler , Faster than Dynamic Binding , Referance always wins , (Method overloading , static methods , method hiding)
             Dynamic Binding is a technique that happens in run time by CLR , Slower than Static Binding , The object wins , (Method Overriding, Abstract Methods) )
             */
            #endregion

            #region Question02
            //Q2  Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            /*
             Sealed keyword when applied to a class makes the class can not be inherited we use it mainly to protect senstive data (there is no inheritance chain)
             */
            //b)  What is the difference between a sealed class and a sealed method? 
            /*
             sealed class can not be inherited at all , sealed method prevent the further override of a specific method 
             */
            //c)  Can a sealed method be overridden? Why?
            /*
             No , A Sealed Method can't be overridden After using sealed keyword because it means that this method override is final and can not be overridden further 
             */
            #endregion

            #endregion
        }
    }
}
