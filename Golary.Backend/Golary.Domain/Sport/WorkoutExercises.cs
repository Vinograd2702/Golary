namespace Golary.Domain.Sport
{
    // Сущность тренировочного блока
    // Представляет сущность тренировочного блока
    // на одном снаряде с заданным весом, колличеством повторений,
    // подходов и отдыха между подходами
    public class WorkoutExercises : BaseEntity
    {
        public TypeOfExercise TypeOfExercise { get; set; } // Тип упражнения  
        public WorkoutForTheDay WorkoutForTheDay { get; set; } // тренировочный день
        public double Weight { get; set; }      // Вес снаряда
        public int Repetitions { get; set; }    // Колличество повторений
        public int Approaches { get; set; }     // Колличество подходов
        public double Rest {  get; set; }       // Интервал между подходами (в миллисекундах)

    }
}
