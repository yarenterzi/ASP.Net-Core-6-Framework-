using DataAccessLayer.Concrete;
using FlyCoreProje.CQRS.Queries.DestinationQueries;
using FlyCoreProje.CQRS.Results.DestinationResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlyCoreProje.CQRS.Handlers.DestinationHandlers
{
   // [Area("Admin")]
    [AllowAnonymous]
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationID,
                capacity = x.Capacity,
                city = x.City,
                daygun = x.Gun,
                price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
