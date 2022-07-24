﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Municipal : Impuesto
    {
        // Atributos
        public string Partida { get; set; }

        // Constructores
        public Municipal(double importe, string partida):base(importe)
        {
            Partida = partida;
        }
    }
}
