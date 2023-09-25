using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Domain.Entities;

public class ConexaoUsuario
{
    public int Id { get; set; }
    public int UsuarioId1 { get; set; }
    public int UsuarioId2 { get; set; }
    public virtual Usuario Usuario1 { get; }
    public virtual Usuario Usuario2 { get; }
}