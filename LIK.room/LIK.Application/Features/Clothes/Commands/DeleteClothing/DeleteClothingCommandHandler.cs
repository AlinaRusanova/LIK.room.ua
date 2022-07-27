using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LIK.Application.Interfaces;
using MediatR;
using System.Linq;
using LIK.Domain.Models;
using LIK.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace LIK.Application.Features.Clothes.Commands.DeleteClothing
{
    public class DeleteClothingCommandHandler : IRequestHandler<DeleteClothingCommand>
    {
        private readonly IAppDBContent _appDBContent;
        public DeleteClothingCommandHandler(IAppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public async Task<Unit> Handle(DeleteClothingCommand command, CancellationToken cancellationToken)
        {
            var entity =
                await _appDBContent.Clothing.FindAsync(new object[] {command.Id }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Clothing), command.Id);
            }

            _appDBContent.Clothing.Remove(entity);
            await _appDBContent.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
