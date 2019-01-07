using System;
//Подключаем пространства имен Threading и Principal
using System.Threading;
using System.Security.Principal;

namespace WindowsIdentityandPrincipal {

    class Class1 {
        
        static void Main(string[] args) {
            // Создаем и инициализируем объекты
            // WindowsPrincipal и WindowsIdentity
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            // Выводим информацию, содержащуюся в объекте класса WindowsPrincipal
            Output("Name", principal.Identity.Name);
            Output("Type", principal.Identity.AuthenticationType);
            Output("Authenticated", principal.Identity.IsAuthenticated.ToString());
            // Выводим информацию, содержащуюся в объекте класса WindowsIdentity
            Output("IdentName", identity.Name);
            Output("IdentType", identity.AuthenticationType);
            Output("IdentIsAuthenticated", identity.IsAuthenticated.ToString());
            Output("IsAnonymous", identity.IsAnonymous.ToString());
            Output("IsGuest", identity.IsGuest.ToString());
            Output("IsSystem", identity.IsSystem.ToString());
            Output("Token", identity.Token.ToString());

            Console.ReadKey();
        }

        //Метод Output выводит информацию на экран, причем myName — это название
        //параметра, а myValue — его значение.
        public static void Output(string myName, string myValue) {
            Console.WriteLine(myName + "= {0}", myValue);
        }
    }
}