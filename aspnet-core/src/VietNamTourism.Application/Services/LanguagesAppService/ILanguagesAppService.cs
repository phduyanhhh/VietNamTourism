using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using VietNamTourism.Services.LanguagesAppService.Dto;

namespace VietNamTourism.Services.LanguagesAppService
{
	public interface ILanguagesAppService : IApplicationService
	{
		Task UploadFileJsonLanguage(IFormFile fileJson, string sourceName = VietNamTourismConsts.LocalizationSourceName);
		Task<PagedResultDto<LanguagesListDto>> GetAllLanguages(GetAllLanguagesInput input);
	}
}
