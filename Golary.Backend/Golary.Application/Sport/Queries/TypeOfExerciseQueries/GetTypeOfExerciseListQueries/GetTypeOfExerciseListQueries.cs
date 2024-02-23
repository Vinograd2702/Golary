using MediatR;

namespace Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseListQueries
{
    // Запрос на все тренировки пользователя
    public class GetTypeOfExerciseListQueries : IRequest<TypeOfExerciseListVm>
    {
        // получить все типы упражнений можно только по одному Id пользователя
        public Guid UserId { get; set; }
    }
}
