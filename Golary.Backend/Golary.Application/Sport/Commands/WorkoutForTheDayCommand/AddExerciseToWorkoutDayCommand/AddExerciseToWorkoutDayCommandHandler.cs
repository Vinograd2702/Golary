using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.AddExerciseToWorkoutDay
{
    public class AddExerciseToWorkoutDayCommandHandler : IRequestHandler<AddExerciseToWorkoutDayCommand>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;

        // Передаем контекст в конструкторе
        public AddExerciseToWorkoutDayCommandHandler(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;

        public async Task Handle(AddExerciseToWorkoutDayCommand request, 
            CancellationToken cancellationToken)
        {
            // Поиск тренировочного дня пр Id
            var entity =
                await _golaryDbContext.WorkoutsForTheDay.FirstOrDefaultAsync(workoutForDay =>
                workoutForDay.Id == request.workoutForTheDayId, cancellationToken);
            // Если объекта нет в бд или он не принадлежит пользователю
            if (entity == null || request.UserId != entity.UserId) 
            {
                throw new NotFoundException(nameof(WorkoutForTheDay), request.workoutForTheDayId);
            }

            // Если сущность найдена, добавляем ей новый тренировочный блок в список
            
            entity.WorkoutExercises.Add(request.workoutExercise);

            await _golaryDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
