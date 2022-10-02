using System.Collections.Generic;


namespace Refactoring
{
    // 1/3 = 0.3 stable
    public abstract class ReportAbstract
    {
        protected ICustomer _customer;

        public ReportAbstract(ICustomer customer)
        {
            _customer = customer;
        }

        public abstract string GetReport();

        protected double GetTotalAmount(IEnumerable<IRental> rentals)
        {
            double res = 0;

            foreach (IRental rental in rentals)
            {
                res += rental.GetThisAmount();
            }

            return res;
        }

        protected int GetFPoint(IEnumerable<IRental> rentals)
        {
            var res = 0;

            foreach (IRental rental in rentals)
            {
                res += rental.GetFrequentRenterPoints();
            }

            return res;
        }
    }

    // 2/2 unstable
    public class TXTReport : ReportAbstract
    {
        public TXTReport(ICustomer customer): base(customer) { }

        public override string GetReport()
        {
            string result = string.Format("Учет аренды для {0}: ", _customer.Name);

            // Затем для каждого клиента мы рассчитываем задолженность...
            foreach (IRental rental in _customer.GetRentals())
            {
                result += "\t" + rental.Movie.Title + "\t" + rental.GetThisAmount() + "\n";
            }

            // Добавить нижний колонтитул 
            result += "Сумма задолженности составляет " + GetTotalAmount(_customer.GetRentals()) + "\n";
            result += "Вы заработали " + GetFPoint(_customer.GetRentals()) + " очков за активность";
            return result;
        }
    }

    // 2/2 unstable
    public class HTMLReport : ReportAbstract
    {
        public HTMLReport(ICustomer customer) : base(customer) { }

        public override string GetReport()
        {
            string result = string.Format("HTML\n");
            result += string.Format("Учет аренды для {0}: ", _customer.Name);

            // Затем для каждого клиента мы рассчитываем задолженность...
            foreach (IRental rental in _customer.GetRentals())
            {
                result += "\t" + rental.Movie.Title + "\t" + rental.GetThisAmount() + "\n";
            }

            // Добавить нижний колонтитул 
            result += "Сумма задолженности составляет " + GetTotalAmount(_customer.GetRentals()) + "\n";
            result += "Вы заработали " + GetFPoint(_customer.GetRentals()) + " очков за активность";
            return result;
        }
    }
}
