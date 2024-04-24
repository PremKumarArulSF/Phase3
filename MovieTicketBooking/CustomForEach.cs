using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public partial class CustomList<Type> :IEnumerable ,IEnumerator
    {
         int position;
         public IEnumerator GetEnumerator()
         {
            position=_count;
            return (IEnumerator) this;
         }
         public bool MoveNext()
         {
            if(position>0)
            {
                position--;
                return true;
            }
            Reset();
            return false;
         }
         public void Reset()
         {
            position=_count;
         }
         public Object Current{get{return _arr[position];}}

    }
}