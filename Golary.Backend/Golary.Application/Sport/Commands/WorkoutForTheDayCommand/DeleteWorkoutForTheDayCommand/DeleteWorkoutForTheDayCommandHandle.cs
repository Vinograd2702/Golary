using Golary.Application.Common.Exceptions;
using Golary.Application.Interfaces;
using Golary.Domain.Sport;
using MediatR;

namespace Golary.Application.Sport.Commands.WorkoutForTheDayCommand.DeleteWorkoutForTheDayCommand
{
    public class DeleteWorkoutForTheDayCommandHandle 
        :IRequestHandler<DeleteWorkoutForTheDayCommand>
    {
        private readonly IGolaryDbContext _golaryDbContext;

        public DeleteWorkoutForTheDayCommandHandle(IGolaryDbContext golaryDbContext) =>
            _golaryDbContext = golaryDbContext;

        public async Task Handle(DeleteWorkoutForTheDayCommand request,
            CancellationToken cancellationToken)
        {
            var entity = 
                await _golaryDbContext.WorkoutsForTheDay
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null || request.UserId != entity.UserId) 
            {
                throw new NotFoundException(nameof(WorkoutForTheDay), request.Id);
            }

            _golaryDbContext.WorkoutsForTheDay.Remove(entity);
            await _golaryDbContext.SaveChangesAsync(cancellationToken);
        }

    }
}
