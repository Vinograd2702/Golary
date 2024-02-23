using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.UpdateWorkoutForTheDayCommand
{
    public class UpdateWorkoutForTheDayCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string TrainingTitle { get; set; }   //  Название тренировки
        public string? TrainingDescription { get; set; }   //  Описание тренировки (необязательное поле)
    }
}
