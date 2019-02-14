﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ResidenciasCBTa20.Datos
{
    class Componente
    {
        public int id_Componente { get; set; }
        public int Cantidad { get; set; }
        public float Costo { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
    }
}