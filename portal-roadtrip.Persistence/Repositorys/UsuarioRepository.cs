using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Context;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.Repositorys;

public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
{
    private readonly DataContext _context;
    public UsuarioRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
