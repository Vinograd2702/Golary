using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;


namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.CreateWorkoutForTheDayCommand
{
    public class CreateWorkoutForTheDayCommandHandler 
        : IRequestHandler<CreateWorkoutForTheDayCommand, Guid>
    {
        private readonly IGolaryDbContext _golaryDbContext;

        public CreateWorkoutForTheDayCommandHandler(IGolaryDbContext golaryDbContext)
            => _golaryDbContext = golaryDbContext;

        public async Task<Guid> Handle(CreateWorkoutForTheDayCommand requset,
            CancellationToken cancellationToken)
        {
            var workoutForTheDay = new WorkoutForTheDay
            {
                Id = Guid.NewGuid(),
                UserId = requset.UserId,
                TrainingTitle = requset.TrainingTitle,
                TrainingDescription = requset.TrainingDescription,
            };

            await _golaryDbContext.WorkoutsForTheDay.AddAsync(workoutForTheDay);
            await _golaryDbContext.SaveChangesAsync(cancellationToken);

            return workoutForTheDay.Id;
        }
    }
}
