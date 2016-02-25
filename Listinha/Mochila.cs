using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listinha
{
    class Mochila
    {
        #region Property
        private int position;
        private int index;
        private Mochila next;
        private Mochila previous;
        #endregion

        #region Get/Set
        public int Position() { return position; }
        public void Position(int i) { position = i; }
        public int Index() { return index; }
        public void Index(int i) { index = i; }
        public Mochila Next() { return next; }
        public void Next(Mochila i) { next = i; }
        public Mochila Previous() { return previous; }
        public void Previous(Mochila i) { previous = i; }
        #endregion
    }
}
