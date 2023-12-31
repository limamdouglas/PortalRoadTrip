﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Application.DTO;

public class ClienteDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }
    public string OrgaoEmissor { get; set; }
    public string DataNascimento { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Regiao { get; set; }
}
