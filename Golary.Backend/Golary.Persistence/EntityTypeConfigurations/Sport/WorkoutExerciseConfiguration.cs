using Golary.Domain.Sport;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Golary.Persistence.EntityTypeConfigurations.Sport
{
    // Конфигурация сущностей тренировочного блока
    internal class WorkoutExerciseConfiguration : BaseEntityConfiguration<WorkoutExercise>
    {
        public override void Configure(EntityTypeBuilder<WorkoutExercise> builder)
        {
            base.Configure(builder);

            builder.Property(entity => entity.Weight).HasPrecision(3);  // Точность веса 3 знака после запятой
        }

    }
}
