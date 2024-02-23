using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using Golary.Persistence.EntityTypeConfigurations;
using Golary.Persistence.EntityTypeConfigurations.Sport;
using Microsoft.EntityFrameworkCore;

namespace Golary.Persistence
{
    public class GolaryDbContext : DbContext, IGolaryDbContext
    {
        public DbSet<TypeOfExercise> TypeOfExercises { get; set; }
        public DbSet<WorkoutExercise> WorkoutsExercises { get; set; }
        public DbSet<WorkoutForTheDay> WorkoutsForTheDay { get; set; }

        // Настройка опций контекста
        public GolaryDbContext(DbContextOptions<GolaryDbContext> options)
            : base(options) { }

        // Метод создания модели конфигурации
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Добавление конфигураций таблиц сущностей
            builder.ApplyConfiguration(new TypeOfExerciseConfiguration());
            builder.ApplyConfiguration(new WorkoutExerciseConfiguration());
            builder.ApplyConfiguration(new WorkoutForTheDayConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
