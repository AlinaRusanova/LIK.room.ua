using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using LIK.Application.Interfaces;
using MediatR;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LIK.Application.Features.Clothes.Queries.GetClothingList
{
    class GetClothingListQueryHandler : IRequestHandler<GetClothingListQuery, ClothingListVm>
    {
        private readonly IAppDBContent _appDBContent;
        private readonly IMapper _mapper;
        public GetClothingListQueryHandler(IAppDBContent appDBContent, IMapper mapper)
        => (_appDBContent, _mapper) = (appDBContent, mapper);
        public async Task<ClothingListVm> Handle(GetClothingListQuery command, CancellationToken cancellationToken)
        {
            var clothesQuery = await _appDBContent.Clothing
                .Where(cl => cl.CategoryID == command.CategoryID)
                .ProjectTo<ClothingLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ClothingListVm { Clothes = clothesQuery };
        }
    }
}
