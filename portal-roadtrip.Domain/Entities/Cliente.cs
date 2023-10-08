using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Domain.Entities;

public sealed class Cliente
{
    public int ClienteId { get; set; }
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? CPF { get; set; }
    public string? RG { get; set; }
    public string? OrgaoEmissor { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? RegiaoOndeMora { get; set; }
    public string? EstadoCivil { get; set; }
    public string? DataNascimento { get; set; }
    public string? Alergia { get; set; }
    public string? Medicamento { get; set; }
    public string? Doença { get; set; }
    public string? ContatoEmergencia { get; set; }
    public bool FezCadastro { get; set; }

}
