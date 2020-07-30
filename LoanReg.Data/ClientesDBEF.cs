using LoanReg.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanReg.Data
{
    public class ClientesDBEF : IClientes
    {
        private readonly LoanRegContext db;

        public ClientesDBEF(LoanRegContext db)
        {
            this.db = db;
        }
        public Cliente CreateCliente(Cliente createCliente)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GelAllClients()
        {
            return db.Clientes.OrderBy(c => c.Id).ToList();
        }

        public Cliente GetClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetClienteByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetClientSolId(int id)
        {
            var user = 1;

            return db.Clientes.FromSqlRaw("EXECUTE dbo.GetClientDatafromsolicitudesId {0}", user).ToList();

        }

        public int GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public Cliente UpdateCliente(Cliente updateCliente)
        {
            throw new NotImplementedException();
        }
    }
}
