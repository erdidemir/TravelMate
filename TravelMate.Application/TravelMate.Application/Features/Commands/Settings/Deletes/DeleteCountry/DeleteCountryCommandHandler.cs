using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Features.Commands.Commons.Deletes;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Services.Settings;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Settings.Deletes.DeleteCountry
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly ICountryService _countryService;
        private readonly ILanguageResourceService _languageResourceService;

        public DeleteCountryCommandHandler( ICountryService countryService, ILanguageResourceService languageResourceService)
        {
            _countryService = countryService;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            var countryEntity = await _countryService.GetFirstAsync(x => x.Code == request.Code);
            if (countryEntity is null)
            {
                var responseMessage1 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DataNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage1, ResultTypeEnum.Error);
            }
            countryEntity.IsDeleted = true;
            await _countryService.UpdateAsync(countryEntity);

            var responseMessage2 = await _languageResourceService.GetTranslateAsync(ResponseConstants.DeletingIsSuccessful, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage2, ResultTypeEnum.Success);

        }
    }
}
