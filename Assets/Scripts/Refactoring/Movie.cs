using System;

namespace Refactoring
{
    public enum MovieEnum
    {
        REGULAR = 0,
        NEW_RELEASE = 1,
        CHILDRENS = 2
    }

    public interface IMovie
    {
        MovieEnum PriceCode
        {
            get;
            set;
        }

        string Title
        {
            get;
        }
    }

    // 2/2 = 1 unstable

    /// <summary>
    /// Класс, который предоставляет данные о фильме.
    /// </summary>
    public class Movie: IMovie
    {
        // Поля
        private string title = null;
        private MovieEnum priceCode = MovieEnum.REGULAR;

        // Методы

        public Movie(string title, MovieEnum priceCode)
        {
            this.title = title;
            this.priceCode = priceCode;
        }

        // Свойства

        public MovieEnum PriceCode
        {
            get { return this.priceCode; }
            set { this.priceCode = value; }
        }

        public string Title
        {
            get { return this.title; }
        }
    }
}
