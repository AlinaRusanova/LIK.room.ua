using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LIK.Application.Interfaces;
using MediatR;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LIK.Application.Common.Exceptions;
using LIK.Domain.Models;

namespace LIK.Application.Features.Clothes.Commands.UpdateClothing
{
   
    class UpdateClothingCommandHandler : IRequestHandler<UpdateClothingCommand, Unit>
    {
        private readonly IAppDBContent _appDBContent;
        public UpdateClothingCommandHandler(IAppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public async Task<Unit> Handle(UpdateClothingCommand command, CancellationToken cancellationToken)
        {
            var entity =
                await _appDBContent.Clothing.FirstOrDefaultAsync(cl => cl.Id == command.Id, cancellationToken);

            if (entity == null )
            {
                throw new NotFoundException(nameof(Clothing),command);
            }
            
            entity.Model = command.Model;
            entity.Articul = command.Articul;
            entity.Color = command.Color;
            entity.Description = command.Description;
            entity.Price = command.Price;
            entity.IsFavourite = true;   // delete
            entity.IsAvailable = true;
            entity.Size = command.Size;
            entity.Imagine = command.Imagine;
            entity.Category = command.Category;

            await _appDBContent.SaveChangesAsync(cancellationToken);
                return Unit.Value;
        }
    }
}
