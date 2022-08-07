using System;
using MediatR;
using minialapi2.Requests;
using minialapi2.Todos.Requests;

namespace minialapi2
{
    public static class ApiMediatrExtention
    {

        public static WebApplication DoGet<TRequest>(this WebApplication app,string route)
            where TRequest : IAppRequest
        {
            app.MapGet(route, async (IMediator mediator, [AsParameters] TRequest request) =>
            {
                return await mediator.Send(request);
            });
            return app;
        }
        public static WebApplication DoPost<TRequest>(this WebApplication app, string route)
           where TRequest : IAppRequest
        {
            app.MapPost(route, async (IMediator mediator, [AsParameters] TRequest request) =>
            {
                return await mediator.Send(request);
            });
            return app;
        }

        public static WebApplication DoPut<TRequest>(this WebApplication app, string route)
          where TRequest : IAppRequest
        {
            app.MapPut(route, async (IMediator mediator, [AsParameters] TRequest request) =>
            {
                return await mediator.Send(request);
            });
            return app;
        }
        public static WebApplication DoDelete<TRequest>(this WebApplication app, string route)
         where TRequest : IAppRequest
        {
            app.MapDelete(route, async (IMediator mediator, [AsParameters] TRequest request) =>
            {
                return await mediator.Send(request);
            });
            return app;
        }

        public static WebApplication RegisterTodoRoutes(this WebApplication app)
        {
            DoGet<GetAllTodoRequest>(app,"/todo");
            DoPost<CreateTodoRequest>(app, "/todo");
            //DoPut<TodoRequest>(app, "/todo/:id");
            //DoDelete<TodoRequest>(app, "/todo/:id");
            return app;
        }
    }
}

