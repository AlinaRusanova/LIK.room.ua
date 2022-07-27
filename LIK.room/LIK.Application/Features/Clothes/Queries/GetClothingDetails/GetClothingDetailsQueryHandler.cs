using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LIK.Application.Common.Exceptions;
using LIK.Application.Interfaces;
using LIK.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LIK.Application.Features.Clothes.Queries.GetClothingDetails
{
    public class GetClothingDetailsQueryHandler : IRequestHandler<GetClothingDetailsQuery, ClothingDetailsVm>
    {
        private readonly IAppDBContent _appDBContent;
        private readonly IMapper _mapper;
        public GetClothingDetailsQueryHandler(IAppDBContent appDBContent, IMapper mapper)
        => (_appDBContent, _mapper) = (appDBContent, mapper);

        public async Task<ClothingDetailsVm> Handle(GetClothingDetailsQuery command, CancellationToken cancellationToken)
        {
            var entity = await _appDBContent.Clothing
                .FirstOrDefaultAsync(cl => cl.Id == command.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Clothing), command);
            }

            return _mapper.Map<ClothingDetailsVm>(entity);
        }
    }
}
