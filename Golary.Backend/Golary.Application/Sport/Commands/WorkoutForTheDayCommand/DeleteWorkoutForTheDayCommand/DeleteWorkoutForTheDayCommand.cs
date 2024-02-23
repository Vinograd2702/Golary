using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.DeleteWorkoutForTheDayCommand
{
    public class DeleteWorkoutForTheDayCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
