using SnakesLadders.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTest.Mock
{
    public class DieFactory : IDieFactory
    {
        private IEnumerator<int> _values;

        public DieFactory(IEnumerable<int> values)
        {
            _values = values.GetEnumerator();
        }

        public IDie CreateDie()
        {
            _values.MoveNext();
            return new Die(_values.Current);
        }
    }
}
