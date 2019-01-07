using System;
using System.Threading;
using System.Security.Principal;

namespace AccessControl {
    class Class1 {
        
        static void Main(string[] args) {
            GenericIdentity identity = new GenericIdentity("MANAGER");
            string[] userRoles = new string[] { "Administrator" };
            GenericPrincipal principal = new GenericPrincipal(identity, userRoles);
            Thread.CurrentPrincipal = principal;

            ValidateUserName();
            ValidateRole();

            Console.ReadKey();
        }
        
        static void ValidateUserName() {
            if (String.Compare(Thread.CurrentPrincipal.Identity.Name, "manager", true) == 0) {
                Console.WriteLine("Добро пожаловать, пользователь Manager");
            } else {
                throw new System.Security.SecurityException("У вас нет прав для выполнения текущей операции");
            }
        }
        
        static void ValidateRole() {
            if (Thread.CurrentPrincipal.IsInRole("Administrator")) {
                Console.WriteLine("Добро пожаловать, пользователь Manager");
            } else {
                throw new System.Security.SecurityException("У вас нет прав для выполнения текущей операции");
            }
        }
    }
}