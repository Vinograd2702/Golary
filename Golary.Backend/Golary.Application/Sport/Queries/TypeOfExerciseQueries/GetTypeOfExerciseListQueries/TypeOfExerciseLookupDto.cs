using AutoMapper;
using Golary.Application.Common.Mappings;
using Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseDetailsQueries;
using Golary.Domain.Sport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseListQueries
{
    // Упращенная модель типа упражнения для просмотра в списке
    public class TypeOfExerciseLookupDto : IMapWith<TypeOfExercise>
    {        
        public Guid Id { get; set; }
        public string NameOfType { get; set; }

        // Создаем профиль для маппинга
        // Маппим TypeOfExercise в GetTypeOfExerciseDetailsVm
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TypeOfExercise, TypeOfExerciseDetailsVm>()
                .ForMember(typeOfExerciseVm => typeOfExerciseVm.Id,
                opt => opt.MapFrom(typeOfExercise => typeOfExercise.Id))
                .ForMember(typeOfExerciseVm => typeOfExerciseVm.NameOfType,
                opt => opt.MapFrom(typeOfExercise => typeOfExercise.NameOfType));
        }
    }
}
