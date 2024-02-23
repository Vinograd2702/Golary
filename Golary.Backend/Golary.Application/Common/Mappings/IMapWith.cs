using AutoMapper;

namespace Golary.Application.Common.Mappings
{
    // Интерфейс создания карты преобразования объекта T к типу GetType()
    public interface IMapWith<T>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());
    }
}
