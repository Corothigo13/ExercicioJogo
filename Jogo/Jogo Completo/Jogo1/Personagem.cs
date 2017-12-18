using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo1
{
    abstract class Personagem
    {
        IArma arma;
        IMagia magia;
        //public virtual void falar() { }
        public void setArma(IArma a)
        {
            arma = a;
        }
        public void setMagia(IMagia m)
        {
            magia = m;
        }
        public string Magia()
        {
            string textomagia;
            return textomagia=magia.usarMagia();
        }
        public string Arma()
        {
            string textoarma;
           return textoarma= arma.usarArma();
        }
    }
}
