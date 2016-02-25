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
        private int posicao;
        private int tamanho;
        private Mochila mochilinha;
        private Mochila mochilona;
        #endregion

        #region Get/Set
        public int Position() { return posicao; }
        public void Position(int i) { posicao = i; }
        public int Index() { return tamanho; }
        public void Index(int i) { tamanho = i; }
        public Mochila Next() { return mochilinha; }
        public void Next(Mochila i) { mochilinha = i; }
        public Mochila Previous() { return mochilona; }
        public void Previous(Mochila i) { mochilona = i; }
        #endregion
    }
}
