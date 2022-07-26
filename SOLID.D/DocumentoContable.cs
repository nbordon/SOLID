﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public abstract class DocumentoContable : IImprimible
    {
        // Atributos
        protected string _sigla;
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        // Constructores
        public DocumentoContable(DateTime fecha, double importe, int numero)
        {
            Fecha = fecha;
            Importe = importe;
            Numero = numero;
        }

        // Métodos
        public abstract double Total();

        public abstract void Imprimir();
    }
}
