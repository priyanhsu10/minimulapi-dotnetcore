using System;
using MediatR;
using minialapi2.Interfaces;
using minialapi2.Requests;
using minialapi2.Todos.Requests;

namespace minialapi2.Todos.Requests
{
    public class CreateTodoRequestHandler:IRequestHandler<CreateTodoRequest,IResult>
    {
        private readonly IRepository<Todo, int> repository;

        public CreateTodoRequestHandler(IRepository<Todo,int> repository)
        {
            this.repository = repository;
        }

        public async Task<IResult> Handle(CreateTodoRequest request, CancellationToken cancellationToken)
        {
            Todo todo = new()
            {

                Decrption = request.Decrption,
                Minutes = request.Minutes,
                title = request.title

            };
            var result = await repository.Create(todo);
            return Results.Ok(result);

        }
    }
}
