using Golary.Domain.Sport;
using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutExerciseCommands.CreateWorkoutExerciseCommand
{
    // Команда создания нового тренировочного блока
    public class CreateWorkoutExerciseCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }        // Id пользователя
        public double Weight { get; set; }      // Вес снаряда
        public int Repetitions { get; set; }    // Колличество повторений
        public int Approaches { get; set; }     // Колличество подходов
        public double Rest { get; set; }        // Интервал между подходами (в миллисекундах)
        public TypeOfExercise TypeOfExercise { get; set; } // Тип упражнения  
        public WorkoutForTheDay WorkoutForTheDay { get; set; } // тренировочный день

    }
}
