using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.CreateWorkoutForTheDayCommand
{
    // Создать тренировку на день
    public class CreateWorkoutForTheDayCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string TrainingTitle { get; set; }   //  Название тренировки
        public string? TrainingDescription { get; set; }   //  Описание тренировки (необязательное поле)
    }
}
