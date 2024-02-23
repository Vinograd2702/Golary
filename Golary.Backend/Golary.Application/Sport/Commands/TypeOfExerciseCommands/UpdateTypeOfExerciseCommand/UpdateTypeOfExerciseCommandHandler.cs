using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Golary.Application.Sport.Commands.TypeOfExerciseCommands.UpdateTypeOfExerciseCommand
{
    public class UpdateTypeOfExerciseCommandHandler
        : IRequestHandler<UpdateTypeOfExerciseCommand>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;

        // Передаем контекст в конструкторе
        public UpdateTypeOfExerciseCommandHandler(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;

        public async Task Handle(UpdateTypeOfExerciseCommand request, 
            CancellationToken cancellationToken)
        {
            // Поиск типа упражнения в БД
            var entity =
                await _golaryDbContext.TypeOfExercises.FirstOrDefaultAsync(typeOfExercise =>
                typeOfExercise.Id == request.Id, cancellationToken);
            
            // Если не нашли упражнение по Id или Id пользователя в запросе и в БД
            // найденной заметки не совпадает
            if (entity == null || request.UserId != entity.UserId) 
            {
                throw new NotFoundException(nameof(TypeOfExercise), request.Id);
            }

            // Если найдена сущность то обновляем название упражнения и сохраняем в контекст
            entity.NameOfType = request.NameOfType;

            await _golaryDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
