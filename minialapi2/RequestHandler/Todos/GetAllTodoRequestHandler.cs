using System;
using MediatR;
using minialapi2.Interfaces;
using minialapi2.Requests;

namespace minialapi2.Todos.Requests
{
    public class GetAllTodoRequestHandler:IRequestHandler<GetAllTodoRequest,IResult>
    {
        private readonly IRepository<Todo, Guid> repository;

        public GetAllTodoRequestHandler(IRepository<Todo,Guid> repository)
        {
            this.repository = repository;
        }
        public async Task<IResult> Handle(GetAllTodoRequest request, CancellationToken cancellationToken)
            => Results.Ok(await repository.getAll());
    }
}

