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
    public class EventoPontoEmbarqueRepository : BaseRepository<EventoPontoEmbarque>, IEventoPontoEmbarqueRepository
    {
        private readonly DataContext _context;
        public EventoPontoEmbarqueRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
