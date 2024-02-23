using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golary.Application.Sport.Commands.WorkoutExerciseCommands.DeleteWorkoutExerciseCommand
{
    public class DeleteWorkoutExerciseCommandHandler 
        : IRequestHandler<DeleteWorkoutExerciseCommand>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;

        // Передаем контекст в конструкторе
        public DeleteWorkoutExerciseCommandHandler(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;

        public async Task Handle(DeleteWorkoutExerciseCommand request,
            CancellationToken cancellationToken)
        {
            var entity =
                await _golaryDbContext.WorkoutsExercises
                .FindAsync(new object[] { request.Id }, cancellationToken);
            
            // Если не нашли упражнение по Id или Id пользователя в запросе и в БД
            // найденной заметки не совпадает
            if (entity == null || request.UserId != entity.UserId)
            {
                throw new NotFoundException(nameof(TypeOfExercise), request.Id);
            }

            _golaryDbContext.WorkoutsExercises.Remove(entity);
            await _golaryDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
