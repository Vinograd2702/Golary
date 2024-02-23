
using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Golary.Application.Sport.Commands.TypeOfExerciseCommands.DeleteTypeOfExerciseCommand
{
    public class DeleteTypeOfExerciseCommandHandler
        : IRequestHandler<DeleteTypeOfExerciseCommand>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;

        // Передаем контекст в конструкторе
        public DeleteTypeOfExerciseCommandHandler(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;

        public async Task Handle(DeleteTypeOfExerciseCommand request, 
            CancellationToken cancellationToken)
        {
            // Поиск типа упражнения в БД
            var entity =
                await _golaryDbContext.TypeOfExercises
                .FindAsync(new object[] { request.Id}, cancellationToken);
                

            // Если не нашли упражнение по Id или Id пользователя в запросе и в БД
            // найденной заметки не совпадает
            if (entity == null || request.UserId != entity.UserId)
            {
                throw new NotFoundException(nameof(TypeOfExercise), request.Id);
            }

            _golaryDbContext.TypeOfExercises.Remove(entity);
            await _golaryDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
