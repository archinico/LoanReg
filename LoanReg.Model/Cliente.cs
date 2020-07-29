using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string Telefono { get; set; }
        public int Salario { get; set; }
        public string Correo { get; set; }

        public List<Solicitud> Solicitudes { get; set; }
    }
}
