using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Domain.Entities;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string DataAdmissao { get; set; }
    public string? DataDemissao { get; set; }
    public string CPF { get; set; }
    public string? RG { get; set; }
    public string? OrgaoEmissor { get; set; }
    public string Instagram { get; set; }
    public int CargoId { get; set; }
    public virtual Cargo Cargo { get; set; }
}