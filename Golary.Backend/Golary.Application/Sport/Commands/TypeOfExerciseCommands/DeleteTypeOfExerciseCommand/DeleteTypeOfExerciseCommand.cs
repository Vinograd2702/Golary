using MediatR;

namespace Golary.Application.Sport.Commands.TypeOfExerciseCommands.DeleteTypeOfExerciseCommand
{
    // Команда удаления типа упражнения
    // тип запроса CreateTypeOfExerciseCommand
    // тип ответа нет
    public class DeleteTypeOfExerciseCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
