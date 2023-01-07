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

namespace TravelMate.Application.Features.Queries.Commons.GetAll
{
    public abstract class GetAllQueryHandler<T> : IRequestHandler<GetAllQuery<T>, ResponseViewModelBase<IReadOnlyList<T>>>
        where T : class
    {
        protected readonly IMapper _mapper;
        protected IReadOnlyList<EntityBase> _baseEntities { get; set; }
        protected readonly ILanguageResourceService _languageResourceService;

        public GetAllQueryHandler(IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }

        public virtual async Task<ResponseViewModelBase<IReadOnlyList<T>>> Handle(GetAllQuery<T> request, CancellationToken cancellationToken)
        {
            if (_baseEntities.Count==0)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<IReadOnlyList<T>>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            return ResponseViewModelBase<IReadOnlyList<T>>.Success(_mapper.Map<IReadOnlyList<T>>(_baseEntities), ResultTypeEnum.Success);
        }
    }
}
