using AutoMapper;
using Golary.Application.Common.Mappings;
using Golary.Domain.Sport;

namespace Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseDetailsQueries
{
    // Vm для представления пользоваелю деталей упражнения
    // Маппинг модели деталей упражнения с упражнением в Домене
    public class TypeOfExerciseDetailsVm : IMapWith<TypeOfExercise>
    {
        // в UserId нет необходимости
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
