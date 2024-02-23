namespace Golary.Persistence.EntityTypeConfigurations
{
    // Инициализация БД
    public class DbInitializer
    {
        // Проверка надичия созданной БД и её создание в случае отсутствия
        public static void Initialize(GolaryDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
