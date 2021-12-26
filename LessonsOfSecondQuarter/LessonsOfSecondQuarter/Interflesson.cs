using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    /// <summary>
    /// Интерфейс урока
    /// </summary>
    interface Interflesson
    {
        /// <summary>
        /// Наименование урока
        /// </summary>
        string NameLesson { get; }
        /// <summary>
        /// Описание урока
        /// </summary>
        string Discription { get; }

        void Demo();
    }
}
