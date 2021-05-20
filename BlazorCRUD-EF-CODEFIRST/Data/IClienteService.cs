using BlazorCRUD_EF_CODEFIRST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Data
{
    interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllCliente();

        Task<Cliente> GetClienteDetails(int clienteId);

        Task<bool> InsertCliente(Cliente cliente);

        Task<bool> UpdateCliente(Cliente cliente);

        Task<bool> DeleteCliente(int ClienteId);

        Task<bool> SaveCliente(Cliente cliente);

    }
}
