using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            // Добавляем обработчики события
            account.Added += Show_Message;
            account.Withdrawn += Show_Message;

            account.Withdraw(100);
            // Удаляем обработчик события
            account.Withdrawn -= Show_Message;

            account.Withdraw(50);
            account.Put(150);

            Console.ReadLine();
        }
        private static void Show_Message(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
    }
}
