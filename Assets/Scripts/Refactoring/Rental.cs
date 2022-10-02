
using System;

namespace Refactoring
{
    public interface IRental
    {
        IMovie Movie
        {
            get;
        }

        int DaysRented
        {
            get;
        }

        double GetThisAmount();
        int GetFrequentRenterPoints();
    }


    // unstable
    /// <summary>
    /// Класс, представляющий данные о прокате фильма.
    /// </summary>
    public class Rental: IRental
    {
        // Поля

        private IMovie movie = null;
        private int daysRented = 0;

        // Методы

        public Rental(IMovie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        // Свойства

        public IMovie Movie
        {
            get { return this.movie; }
        }

        public int DaysRented
        {
            get { return this.daysRented; }
        }

        public int GetFrequentRenterPoints()
        {
            // Добавить очки для активного арендатора.
            var frequentRenterPoints = 1;

            // Бонус за аренду новинки на два дня.
            if ((Movie.PriceCode == MovieEnum.NEW_RELEASE) && DaysRented > 1)
                frequentRenterPoints++;

            return frequentRenterPoints;
        }

        public double GetThisAmount()
        {
            double thisAmount = 0;

            // Определить сумму для каждой строки.
            switch (Movie.PriceCode)
            {
                case MovieEnum.REGULAR:
                    thisAmount += 2;
                    if (DaysRented > 2)
                        thisAmount += (DaysRented - 2) * 1.5;
                    break;
                case MovieEnum.NEW_RELEASE:
                    thisAmount += DaysRented * 3;
                    break;
                case MovieEnum.CHILDRENS:
                    thisAmount += 1.5;
                    if (DaysRented > 3)
                        thisAmount += (DaysRented - 3) * 1.5;
                    break;
            }

            return thisAmount;
        }
    }
}
