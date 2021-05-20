using BlazorCRUD_EF_CODEFIRST.Context;
using BlazorCRUD_EF_CODEFIRST.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Data
{
    public class ClienteService : IClienteService
    {
        //Para usar entity agregamos por inyeccion de dependencias el contexto de la base de datos

        private readonly CotizacionDbContext _context;

        public ClienteService(CotizacionDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteCliente(int ClienteId)
        {
            var cliente = await _context.Clientes.FindAsync(ClienteId);

            _context.Clientes.Remove(cliente);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Cliente>> GetAllCliente()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetClienteDetails(int clienteId)
        {
            return await _context.Clientes.FindAsync(clienteId);
        }

        public async Task<bool> InsertCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);

            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> SaveCliente(Cliente cliente)
        {
            if (cliente.ClienteId > 0)
            {
                return await UpdateCliente(cliente);
            }
            else
            {
                return await InsertCliente(cliente);
            }
        }

        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
