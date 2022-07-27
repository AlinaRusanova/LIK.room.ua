using MediatR;
using LIK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LIK.Application.Interfaces;

namespace LIK.Application.Features.Clothes.Commands.CreateClothing
{
    public class CreateClothingCommandHandler : IRequestHandler<CreateClothingCommand, int>
    {
        private readonly IAppDBContent _appDBContent;
        public CreateClothingCommandHandler(IAppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public async Task<int> Handle(CreateClothingCommand command, CancellationToken cancellationToken)
        {
            var clothing = new Clothing
            {
                //Id ??
                Model = command.Model,
                Articul = command.Articul,
                Color = command.Color,
                Description = command.Description,
                Price = command.Price,
                IsFavourite = true,   // delete
                IsAvailable = true,
                Size = command.Size,
                Imagine = command.Imagine,
                Category = command.Category

            };
            await _appDBContent.Clothing.AddAsync(clothing, cancellationToken);
            await _appDBContent.SaveChangesAsync(cancellationToken);

            return clothing.Id;
        }
    }
}
