using Domain;
using MediatR;

namespace Application.UseCases.CreateCategory;

public class CreateCategoryCommand : IRequest
{
    public string Name { get; set; }
}

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
{
    public Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category(request.Name);
        
        return Task.CompletedTask;
    }
}