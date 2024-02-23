using Golary.Domain.Sport;
using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutExerciseCommands.UpdateWorkoutExerciseCommand
{
    // Команда изменения блока тренировки
    public class UpdateWorkoutExerciseCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public double Weight { get; set; }      // Вес снаряда
        public int Repetitions { get; set; }    // Колличество повторений
        public int Approaches { get; set; }     // Колличество подходов
        public double Rest { get; set; }        // Интервал между подходами (в миллисекундах)
        public TypeOfExercise TypeOfExercise { get; set; } // Тип упражнения
    }
}
