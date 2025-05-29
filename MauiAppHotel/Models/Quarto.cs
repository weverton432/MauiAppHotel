using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
public class Quarto
    {
        public required string Descricao { get; set; }
        public double Valor_Diaria_Adulto { get; set; }
        public double Valor_Diaria_Crianca { get; set; }

    }
}
