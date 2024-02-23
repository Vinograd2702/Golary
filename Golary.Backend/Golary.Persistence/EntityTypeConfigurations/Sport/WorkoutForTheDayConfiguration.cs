using Golary.Domain.Sport;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Golary.Persistence.EntityTypeConfigurations.Sport
{
    // Конфигурация сущностей тренировки на день
    internal class WorkoutForTheDayConfiguration : BaseEntityConfiguration<WorkoutForTheDay>
    {
        public override void Configure(EntityTypeBuilder<WorkoutForTheDay> builder)
        {
            base.Configure(builder);

            builder.Property(entity => entity.TrainingTitle).HasMaxLength(20); // Ограничение длинны названия тренировки на день
            builder.Property(entity => entity.TrainingDescription).HasMaxLength(250); // Ограничение длинны описания тренировки на день
        }
    }
    
}
