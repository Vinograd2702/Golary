namespace Golary.Domain.Sport
{
    // Сущность тренировки на день
    // Состоит из неснольких блоков WorkoutExercise
    public class WorkoutForTheDay : BaseEntity
    {
        public string TrainingTitle { get; set; }   //  Название тренировки
        public string? TrainingDescription { get; set; }   //  Описание тренировки (необязательное поле)
        public ICollection<WorkoutExercises>? WorkoutExercises { get; set; } // Тренировочные упражнения на день (необязательное поле)
                                                                            // Колекция с методами CopyTo, Add, Remove, Contains, свойство Count
    }
}
