using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Commons;
using TravelMate.Domain.Enums.Commons;
using TravelMate.Domain.Enums.Languages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Languages.GetLanguage.GetEnumLanguage
{
    public class GetEnumLanguageQueryHandler : IRequestHandler<GetEnumLanguageQuery, ResponseViewModelBase<IReadOnlyList<BaseEnumViewModel>>>
    {
        private readonly IMapper _mapper;

        public GetEnumLanguageQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<BaseEnumViewModel>>> Handle(GetEnumLanguageQuery request, CancellationToken cancellationToken)
        {
            var languageList = EnumHelper<LanguageEnum>.GetDisplayValues();
            var returnList = _mapper.Map<IReadOnlyList<BaseEnumViewModel>>(languageList);

            return ResponseViewModelBase<IReadOnlyList<BaseEnumViewModel>>.Success(returnList, ResultTypeEnum.Success);
        }
    }
}
