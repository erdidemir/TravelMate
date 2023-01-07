using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Commons;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Commons.GetById
{
    public abstract class GetByIdQueryHandler<T> : IRequestHandler<GetByIdQuery<T>, ResponseViewModelBase<T>> where T : class
    {
        private readonly IMapper _mapper;
        protected EntityBase _baseEntity { get; set; }
        private readonly ILanguageResourceService _languageResourceService;

        public GetByIdQueryHandler(IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }

        public virtual async Task<ResponseViewModelBase<T>> Handle(GetByIdQuery<T> request, CancellationToken cancellationToken)
        {
            if(_baseEntity is null)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<T>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            return ResponseViewModelBase<T>.Success(_mapper.Map<T>(_baseEntity), ResultTypeEnum.Success);
         ;
        }
    }
}
