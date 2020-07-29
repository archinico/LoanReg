using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Model
{
    public class Solicitud
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
