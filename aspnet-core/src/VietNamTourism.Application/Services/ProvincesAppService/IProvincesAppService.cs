using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VietNamTourism.Services.ProvincesAppService.Dto;

namespace VietNamTourism.Services.ProvincesAppService
{
	public interface IProvincesAppService : IApplicationService
	{
		Task Create(CreateProvinceDto input);
		Task<PagedResultDto<ProvincesListDto>> GetAllProvinces(GetAllProvincesInput input);
		Task<ProvincesListDto> GetAnProvince(int id);
		Task EditProvince(EditProvinceDto input);
		Task DeleteProvince(int id);
	}
}
