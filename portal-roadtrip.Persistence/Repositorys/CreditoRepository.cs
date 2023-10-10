using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Context;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.Repositorys;

public class CreditoRepository : BaseRepository<Credito>, ICreditoRepository
{
    private readonly DataContext _context;
    public CreditoRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
