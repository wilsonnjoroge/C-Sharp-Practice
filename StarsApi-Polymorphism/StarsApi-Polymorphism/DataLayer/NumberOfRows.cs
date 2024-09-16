using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsApi_Polymorphism.DataLayer
{
    public class NumberOfRows : INumberOfRowsRepository
    {
        private int[] rowNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public bool IsRowNumberValid(int input)
        {
            return rowNumbers.Contains(input);

        }

        public int[] GetRowNumbers()
        {
            return rowNumbers;
        }
    }
}
