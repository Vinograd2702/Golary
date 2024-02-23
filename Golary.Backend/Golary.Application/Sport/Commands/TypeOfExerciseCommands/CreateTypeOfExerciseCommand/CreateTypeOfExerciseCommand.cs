using MediatR;

namespace Golary.Application.Sport.Commands.TypeOfExerciseCommands.CreateTypeOfExercise
{
    // Команда добавления типа упражнения
    // тип запроса CreateTypeOfExerciseCommand
    // тип ответа Guid Id
    public class CreateTypeOfExerciseCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string NameOfType { get; set; }
    }
}
