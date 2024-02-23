using MediatR;


namespace Golary.Application.Sport.Commands.TypeOfExerciseCommands.UpdateTypeOfExerciseCommand
{
    // Команда изменения типа упражнения
    // тип запроса CreateTypeOfExerciseCommand
    // тип ответа нет
    public class UpdateTypeOfExerciseCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string NameOfType { get; set; }
    }
}