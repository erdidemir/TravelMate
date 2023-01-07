using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Commons;
using TravelMate.Domain.Entities.Commons;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Commons.Deletes
{
    public class DeleteCommandBaseHandler<T> : IRequestHandler<DeleteCommandBase<T>, ResponseViewModelBase<NoContent>> where T : class
    {
        public DeleteCommandBaseHandler()
        {
        }

        public virtual async Task<ResponseViewModelBase<NoContent>> Handle(DeleteCommandBase<T> request, CancellationToken cancellationToken)
        {
            return ResponseViewModelBase<NoContent>.Success(ResultTypeEnum.Success);
        }
    }
}
