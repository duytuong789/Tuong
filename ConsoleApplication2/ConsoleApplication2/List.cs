using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class List<T>
    {
        Element<T> head1;

        internal Element<T> Head
        {
            get { return head1; }
            set { head1 = value; }
        }
        public List()
        {}
        public void addfirst(Element<T> e)
        {
            e.Next = head1;
            this.head1 = e;
        }
    }
}
