using Golary.Domain.Sport;
using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.AddExerciseToWorkoutDay
{
    // Команда добавления тренировочного блока в тренировку на день
    public class AddExerciseToWorkoutDayCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid workoutForTheDayId { get; set; }
        public WorkoutExercise workoutExercise { get; set; }
    }
}
