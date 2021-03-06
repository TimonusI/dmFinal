﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Умножение целых чисел
    /// Хаханов Тимофей
    /// </summary>
    public static class Z_8
    {
        /// <summary>
        /// Умножение целых чисел
        /// </summary>
        /// <param name="A">Первый множитель</param>
        /// <param name="B">Второй мнжитель</param>
        /// <returns>Перемноженные числа</returns>
        public static Digit Run(Digit A, Digit B)
        {
            return new Digit(A.Sign == B.Sign, N_8.Run(A.Value, B.Value));
        } 

    }
}
