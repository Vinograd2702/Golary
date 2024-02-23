using Golary.Domain.Sport;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Golary.Persistence.EntityTypeConfigurations.Sport
{
    // Конфигурация сущностей типа упражнения
    internal class TypeOfExerciseConfiguration : BaseEntityConfiguration<TypeOfExercise>
    {
        // переопределение виртуального метода конфигурации BaseEntityConfiguration
        public override void Configure(EntityTypeBuilder<TypeOfExercise> builder)
        {
            base.Configure(builder);

            // дополнение конфигурации BaseEntityConfiguration
            builder.Property(entity => entity.NameOfType).HasMaxLength(20); // Ограничение длинны названия упражнения
        }
    }
}
