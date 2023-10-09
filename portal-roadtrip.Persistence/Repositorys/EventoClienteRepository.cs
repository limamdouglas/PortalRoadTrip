using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Context;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.Repositorys;

public class EventoClienteRepository : BaseRepository<EventoCliente>, IEventoClienteRepository
{
    private readonly DataContext _dataContext;
    public EventoClienteRepository(DataContext context) : base(context)
    {
        _dataContext = context;
    }
}
