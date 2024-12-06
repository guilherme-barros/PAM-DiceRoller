using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller_Correcao
{
    public class Dice
    {
        int lados;
        int numeracao;
        int numeroSorteado;

        public Dice(int quantidadeDeLados) { 
            lados = quantidadeDeLados;
        }
        public int Rolar()
        {
            numeroSorteado = new Random().Next(1, lados + 1);
            return numeroSorteado;
        }
    }
}
