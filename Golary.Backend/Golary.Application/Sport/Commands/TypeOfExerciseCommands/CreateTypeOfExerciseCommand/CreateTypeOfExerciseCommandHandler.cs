using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;

namespace Golary.Application.Sport.Commands.TypeOfExerciseCommands.CreateTypeOfExercise
{
    // Обработчик команды создания упражнения
    // тип запроса CreateTypeOfExerciseCommand
    // тип ответа Guid Id
    public class CreateTypeOfExerciseCommandHandler
        : IRequestHandler<CreateTypeOfExerciseCommand, Guid>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;

        // Передаем контекст в конструкторе
        public CreateTypeOfExerciseCommandHandler(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;
        public async Task<Guid> Handle(CreateTypeOfExerciseCommand request,
            CancellationToken cancellationToken)
        {


            // Обработчик создает TypeOfExercise по DTO команды
            var typeOfExercise = new TypeOfExercise
            {
                UserId = request.UserId,
                NameOfType = request.NameOfType,
                Id = Guid.NewGuid()
            };

            // Добавляем упражнение в БД
            await _golaryDbContext.TypeOfExercises.AddAsync(typeOfExercise, cancellationToken);

            // Сохраняем изменения в БД
            await _golaryDbContext.SaveChangesAsync(cancellationToken);

            return typeOfExercise.Id;
        }
    }
}
