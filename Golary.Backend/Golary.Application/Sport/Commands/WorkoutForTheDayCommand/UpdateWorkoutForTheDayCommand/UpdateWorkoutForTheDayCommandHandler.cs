using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.UpdateWorkoutForTheDayCommand
{
    public class UpdateWorkoutForTheDayCommandHandler
        : IRequestHandler<UpdateWorkoutForTheDayCommand>
    {
        private readonly IGolaryDbContext _golaryDbContext;

        public UpdateWorkoutForTheDayCommandHandler(IGolaryDbContext golaryDbContext) => 
            _golaryDbContext = golaryDbContext;

        public async Task Handle(UpdateWorkoutForTheDayCommand request, CancellationToken cancellationToken)
        {
            var entity =
                await _golaryDbContext.WorkoutsForTheDay.FirstOrDefaultAsync(workoutForTheDay => 
                workoutForTheDay.Id == request.Id, cancellationToken);

            if (entity == null || request.UserId != entity.UserId)
            {
                throw new NotFoundException(nameof(WorkoutForTheDay), request.Id);
            }

            entity.TrainingTitle = request.TrainingTitle;
            entity.TrainingDescription = request.TrainingDescription;

            await _golaryDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
