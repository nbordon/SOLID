﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    public class DocumentoContable
    {
        // Atributos
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public TipoDocumentoContable Tipo { get; set; }

        // Constructores
        public DocumentoContable(TipoDocumentoContable tipo, int numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        public string Descripcion()
        {
            switch (Tipo)
            {
                case TipoDocumentoContable.Factura:
                    return $"FC-{Numero}";
                case TipoDocumentoContable.NotaDeCredito:
                    return $"NC-{Numero}";
                default:
                    return $"N/D";
            }
        }
    }
}
