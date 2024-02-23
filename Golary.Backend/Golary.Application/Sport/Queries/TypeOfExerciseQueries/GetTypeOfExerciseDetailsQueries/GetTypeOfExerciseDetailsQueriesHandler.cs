using AutoMapper;
using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseDetailsQueries
{
    // Обработчик принимает два типа - запрос и тип возвращаемой сущности
    public class GetTypeOfExerciseDetailsQueriesHandler
        : IRequestHandler<GetTypeOfExerciseDetailsQueries, TypeOfExerciseDetailsVm>
    {
        // Поле контекста
        private readonly IGolaryDbContext _golaryDbContext;
        // Поле маппера
        private readonly IMapper _mapper;

        // Передаем контекст и маппер в конструкторе
        public GetTypeOfExerciseDetailsQueriesHandler(IGolaryDbContext golaryDbContext, IMapper mapper) =>
            (_golaryDbContext, _mapper) = (golaryDbContext, mapper);

        public async Task<TypeOfExerciseDetailsVm> Handle(GetTypeOfExerciseDetailsQueries request, CancellationToken cancellationToken)
        {
            var entity = await _golaryDbContext.TypeOfExercises
                .FirstOrDefaultAsync(typeOfExercise => 
                typeOfExercise.Id == request.Id, cancellationToken);

            if (entity == null || entity.UserId != request.UserId) 
            {
                throw new NotFoundException(nameof(TypeOfExercise), request.Id);
            }

            // Если нашли упражнение - смапили его и вернули пользователю
            // как TypeOfExerciseDetailsVm
            return _mapper.Map<TypeOfExerciseDetailsVm>(entity);
        }
    }
}
