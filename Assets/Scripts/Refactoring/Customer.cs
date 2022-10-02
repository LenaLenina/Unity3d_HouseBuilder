using System;
using System.Collections.Generic;
using System.Linq;


namespace Refactoring
{
    // 1 1 1 
    // 1 1

    // 2/5 = 0.4 stable

    public interface ICustomer
    {
        string Statement();

        string Name { get; }

        IRental AddRental { set; }

        IEnumerable<IRental> GetRentals();
    }

    // 1 1 1
    // 0
    // 3/3 = 1 unstable

    /// <summary>
    /// Класс, представляющий клиента магазина.
    /// </summary>
    public class Customer: ICustomer
    {
        // Поля

        private string name = null;
        private List<IRental> rentals;
        private ReportAbstract _report;

        // Методы

        public Customer(string name)
        {
            this.name = name;
            rentals = new List<IRental>();
            _report = new HTMLReport(this);
        }

        //  TODO: Метод Statement() - слишком громоздкий.

        /// <summary>
        /// Метод создающий отчет.
        /// </summary>
        /// <returns></returns>
        public string Statement()
        {
            return _report.GetReport();
        }

        public IEnumerable<IRental> GetRentals()
        {
            return rentals;
        }

        // Свойства

        public IRental AddRental
        {
            set { rentals.Add(value); }
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
