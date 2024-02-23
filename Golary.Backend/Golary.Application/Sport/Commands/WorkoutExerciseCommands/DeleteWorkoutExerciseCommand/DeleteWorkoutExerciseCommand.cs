using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutExerciseCommands.DeleteWorkoutExerciseCommand
{
    public class DeleteWorkoutExerciseCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
