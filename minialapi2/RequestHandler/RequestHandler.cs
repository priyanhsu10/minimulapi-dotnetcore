using System;
using MediatR;
using minialapi2.Requests;

namespace minialapi2.Requests
{
    public class TestRequestHandler : IRequestHandler<TestRequest, IResult>
    {
        public async Task<IResult> Handle(TestRequest request, CancellationToken cancellationToken)
        {
            return Results.Ok(request);
        }
    }
}

