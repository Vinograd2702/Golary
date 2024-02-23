using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutExerciseCommands.CreateWorkoutExerciseCommand
{
    // Обработчик создания тренировочного блока
    public class CreateWorkoutExerciseCommandHandler
        : IRequestHandler<CreateWorkoutExerciseCommand, Guid>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;

        // Передаем контекст в конструкторе
        public CreateWorkoutExerciseCommandHandler(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;

        public async Task<Guid> Handle(CreateWorkoutExerciseCommand request, 
            CancellationToken cancellationToken)
        {
            var workoutExercise = new WorkoutExercise
            {
                UserId = request.UserId,
                Id = Guid.NewGuid(),
                TypeOfExercise = request.TypeOfExercise,
                WorkoutForTheDay = request.WorkoutForTheDay,
                Weight = request.Weight,
                Repetitions = request.Repetitions,
                Approaches = request.Approaches,
                Rest = request.Rest
            };

            await _golaryDbContext.WorkoutsExercises.AddAsync(workoutExercise, cancellationToken);

            await _golaryDbContext.SaveChangesAsync(cancellationToken);

            return workoutExercise.Id;
        }
    }
}
