using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LarreaPaulEval2P.Modelo;

namespace LarreaPaulEval2P.Interfaz
{
    public interface ILarrea
    {
        Larrea GetRecarga(string numero);
        bool CreateRecarga(Larrea recarga);
        bool UpdateRecarga(Larrea recarga);
        bool DeleteRecarga(string numero);
    }
}

