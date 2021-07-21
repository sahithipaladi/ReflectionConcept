using System;
using System.Reflection;

namespace ReflectionConcept
{
   
        public class MainClass
        {
              private static void Main()
              {
                 Customer C1 = new Customer();
                 C1.GetType();

                 Type T = Type.GetType(" ReflectionConcept.Customer");
                 Console.WriteLine("Full Name = {0}", T.FullName);
                 Console.WriteLine("Just the Name= {0}", T.Name);
                 Console.WriteLine("Just the Namespace = {0}", T.Namespace);
                 Console.WriteLine();

                 Console.WriteLine("Properties in Customer class");
                 PropertyInfo[] properties = T.GetProperties();
                 foreach (PropertyInfo property in properties)
                 {
                    Console.WriteLine(property.PropertyType.Name + " " + property.Name) ;
                 }
                 
                 Console.WriteLine();
                 Console.WriteLine("Methods in Customer class");
                 MethodInfo[] methods = T.GetMethods();
                 foreach (MethodInfo method in methods)
                {
                     Console.WriteLine(method.ReturnType.Name + " " + method.Name);
                }

                 Console.WriteLine();
                 Console.WriteLine("Constructors in Customer class");
                 ConstructorInfo[] constructors = T.GetConstructors();
                 foreach (ConstructorInfo constructor in constructors)
                 {
                    Console.WriteLine(constructor.ToString());
                 }


            Console.WriteLine();
            Console.WriteLine("Fields in Customer class");
            FieldInfo[] fields = T.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.ReflectedType.Name + " " + field.Name);
            
            }








        }


    }
}
