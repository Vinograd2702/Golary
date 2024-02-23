using Golary.Domain.Sport;
using Microsoft.EntityFrameworkCore;

namespace Golary.Application.Interfaces
{
    // Интерфейс подключения к базе данных
    // Реализация в используемых слоях выше (Persistence)
    public interface IGolaryDbContext
    {
        // Таблицы в базе данных
        DbSet<TypeOfExercise> TypeOfExercises { get; set; } 
        DbSet<WorkoutExercise> WorkoutsExercises { get; set; }
        DbSet<WorkoutForTheDay> WorkoutsForTheDay { get; set; }

        // Метод сохранения изменений в базе данных
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
