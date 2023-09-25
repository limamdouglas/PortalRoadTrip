using portal_roadtrip.Domain.Entities;
using portal_roadtrip.Persistence.Context;
using portal_roadtrip.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_roadtrip.Persistence.Repositorys
{
    public class EventoFuncionarioRepository : BaseRepository<EventoFuncionario>, IEventoFuncionarioRepository
    {
        private readonly DataContext _context;
        public EventoFuncionarioRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
