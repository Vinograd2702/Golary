using MediatR;

namespace Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseDetailsQueries
{
    // Запрос возвращает TypeOfExerciseDetailsVm
    public class GetTypeOfExerciseDetailsQueries : IRequest<TypeOfExerciseDetailsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
