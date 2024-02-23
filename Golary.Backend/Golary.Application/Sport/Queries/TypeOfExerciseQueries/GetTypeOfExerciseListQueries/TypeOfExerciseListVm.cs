namespace Golary.Application.Sport.Queries.TypeOfExerciseQueries.GetTypeOfExerciseListQueries
{
    // Модель представления типов тренировок в списке для выбора
    public class TypeOfExerciseListVm
    {
        // Модель содержит список тренировок без деталей 
        public IList<TypeOfExerciseLookupDto> TypeOfExercises { get; set; }
    }

}
