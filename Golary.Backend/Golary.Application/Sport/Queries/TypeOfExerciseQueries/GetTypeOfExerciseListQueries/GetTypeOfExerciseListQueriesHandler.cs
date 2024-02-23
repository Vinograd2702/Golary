using AutoMapper;
using AutoMapper.QueryableExtensions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseListQueries
{
    public class GetTypeOfExerciseListQueriesHandler : IRequest<GetTypeOfExerciseListQueries, TypeOfExerciseListVm>
    {
        private readonly IGolaryDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetTypeOfExerciseListQueriesHandler(IGolaryDbContext context, 
            IMapper mapper) =>
            (_dbContext, _mapper) = (context, mapper);
       
        public async Task<TypeOfExerciseListVm> Handle(GetTypeOfExerciseListQueries request,
            CancellationToken cancellationToken)
        {
            var typeOfExercisesQuery = await _dbContext.TypeOfExercises
                .Where(typeOfExercise => typeOfExercise.UserId == request.UserId)
                .ProjectTo<TypeOfExerciseLookupDto>(_mapper.ConfigurationProvider)  // Метод автомаппера для формаирования списка моделей
                .ToListAsync();

            // Возврат списка TypeOfExerciseListVm с типами тренировок
            return new TypeOfExerciseListVm { TypeOfExercises = typeOfExercisesQuery };
        }
    }
}
