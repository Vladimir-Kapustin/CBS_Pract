using System;           //--Это упражнение - Автор говорит в последнем примере к Nested-классам поиграться: какие стереотипы могуть быть внешними и внутренними. Делаю.

namespace _000_Exercise                 //--задание в видео: поиграться: какие стереотипы могуть быть внешними и внутренними.
{
    //--Проверка вложения в обычный класс
    public class Exercise                                   
    {
        public struct NestedStruct                                  //--Вложенная структура - ОК
        {
            public void SomeMeth()
            {
                Console.WriteLine("Some method from struct");
            }
        }

        enum NestedEnum                                             //--Вложенное перечисление - ОК
        {
            intel = 1,
            cytryx = 2,
            amd = 3
        }

        public interface INestedInterface                           //--Вложенный интерфейс - ОК
        {
            int SomeMethod();
            string SomeMethod1();
        }

        public static class Nested                                  //--Вложенный статический класс - ОК
        {
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("Статический метод Nested класса.");
            }
        }

        public abstract class NestedAbstractClass                   //--Вложенный абстрактный класс - ОК
        {
            public void Method()
            {
                Console.WriteLine("Some method from abstract class");
            }
        }
    }

    //--Проверка вложенности в структуру
    public struct SomeStruct                                
    {
        public static class NestedIntoStruct                        //--Вложенный статический класс в структуре - ОК
        {
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("Статический метод Статического Nested-класса, вложенного в структуру.");
            }
        }

        enum NestedEnum                                             //--Вложенное перечисление - ОК
        {
            intel = 1,
            cytryx = 2,
            amd = 3
        }

        public interface INestedInterface                           //--Вложенный интерфейс - ОК
        {
            int SomeMethod();
            string SomeMethod1();
        }

        public abstract class NestedAbstractClass                   //--Вложенный абстрактный класс - ОК
        {
            public void Method()
            {
                Console.WriteLine("Some method from abstract class");
            }
        }
    }

    //--Проверка вложенности в интерфейс (звучит глупо)
    public interface ISomeInterface                           //--Вложенный интерфейс - ОК
    {
        int SomeMethod();
        string SomeMethod1();

        //public abstract class NestedAbstractClass                   //--Вложенный абстрактный класс - НЕ ОК
        //{
        //    public void Method()
        //    {
        //        Console.WriteLine("Some method from abstract class");
        //    }
        //}

        //public interface INestedInterface                           //--Вложенный интерфейс и другие - НЕ ОК
        //{
        //    int SomeMethod();
        //    string SomeMethod();
        //}
    }

    //--Проверка вложения в абстрактный класс
    public abstract class AbstractExercise
    {
        public struct NestedStruct                                  //--Вложенная структура - ОК
        {
            public void SomeMeth()
            {
                Console.WriteLine("Some method from struct");
            }
        }

        enum NestedEnum                                             //--Вложенное перечисление - ОК
        {
            intel = 1,
            cytryx = 2,
            amd = 3
        }

        public interface INestedInterface                           //--Вложенный интерфейс - ОК
        {
            int SomeMethod();
            string SomeMethod1();
        }

        public static class Nested                                  //--Вложенный статический класс - ОК
        {
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("Статический метод Nested класса.");
            }
        }

        public abstract class NestedAbstractClass                   //--Вложенный абстрактный класс - ОК
        {
            public void Method()
            {
                Console.WriteLine("Some method from abstract class");
            }
        }
    }

    // проверка вложенности в перечисление (что тоже глупо)
    enum SomeEnum                                             
    {
         //public class NestedStruct                                  //--Вложенный класс и всё остальное - НЕ ОК
         //   {
         //       public void SomeMeth()
         //       {
         //           Console.WriteLine("Some method from struct");
         //       }
         //   }

        intel = 1,
        cytryx = 2,
        amd = 3
    }

    class Program
    {
        static void Main()
        {
            Exercise.Nested.StaticMethodFromNested();
            Console.WriteLine(SomeEnum.cytryx);

            // Delay.
            Console.ReadKey();
        }
    }
}
