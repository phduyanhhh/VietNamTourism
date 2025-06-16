using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using VietNamTourism.Services.ProvincesAppService.Dto;

namespace VietNamTourism.Services.ProvincesAppService
{
	public interface IProvincesAppService : IApplicationService
	{
		Task Create(CreateProvinceDto input);
	}
}
