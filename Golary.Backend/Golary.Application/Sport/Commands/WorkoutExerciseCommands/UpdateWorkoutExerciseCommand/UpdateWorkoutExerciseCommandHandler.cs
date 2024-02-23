using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Golary.Application.Sport.Commands.WorkoutExerciseCommands.UpdateWorkoutExerciseCommand
{
    public class UpdateWorkoutExerciseCommandHandler 
        : IRequestHandler<UpdateWorkoutExerciseCommand>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;

        // Передаем контекст в конструкторе
        public UpdateWorkoutExerciseCommandHandler(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;

        public async Task Handle(UpdateWorkoutExerciseCommand request, 
            CancellationToken cancellationToken)
        {
            var entity =
                await _golaryDbContext.WorkoutsExercises.FirstOrDefaultAsync(workoutExercise =>
                workoutExercise.Id == request.Id, cancellationToken);

            if (entity == null || request.UserId != entity.UserId) 
            {
                throw new NotFoundException(nameof(WorkoutExercise), request.Id);
            }

            entity.TypeOfExercise = request.TypeOfExercise;
            entity.Weight = request.Weight;
            entity.Repetitions = request.Repetitions;
            entity.Approaches = request.Approaches;
            entity.Rest = request.Rest;

            await _golaryDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
