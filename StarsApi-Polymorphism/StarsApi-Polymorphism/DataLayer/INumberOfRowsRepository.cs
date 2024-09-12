using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsApi_Polymorphism.DataLayer
{
    public interface INumberOfRowsRepository
    {
        public bool IsRowNumberValid(int input);

        public int[] GetRowNumbers();
    }
}
