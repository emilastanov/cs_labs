using System;

namespace lab4
{
    /// <summary>
    /// Фигура
    /// </summary>
    abstract class Figure : IComparable
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string Type { get; protected set; }
        string _Type;
        /// <summary>
        /// Вычисление плозщади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
        /// <summary>
        /// Приведение к строке, переопределение метода Object.
        /// </summary>
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1;
        }
    }
}
