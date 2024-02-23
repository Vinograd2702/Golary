namespace Golary.Domain.Sport
{
    // Сущность типа упражнения
    // Добавляется пользователем в название упражнения,
    // Из которого строиться блок тренировка упражнения
    // WorkoutExercise
    public class TypeOfExercise : BaseEntity
    {
        public string NameOfType { get; set; }      // Тип упражнения  
    }
}
