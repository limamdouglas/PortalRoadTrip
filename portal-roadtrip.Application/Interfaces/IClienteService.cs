using portal_roadtrip.Application.DTO;

namespace portal_roadtrip.Application.Interfaces;

public interface IClienteService
{
    Task<ClienteDTO> SalvarCliente(ClienteCadastroDTO dto);
    Task<List<ClienteDTO>> ListarClientes();
}
