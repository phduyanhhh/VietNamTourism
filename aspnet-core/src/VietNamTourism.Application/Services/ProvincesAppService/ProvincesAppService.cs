using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.UI;
using VietNamTourism.Entities;
using VietNamTourism.Services.ProvincesAppService.Dto;

namespace VietNamTourism.Services.ProvincesAppService
{
	public class ProvincesAppService : VietNamTourismAppServiceBase, IProvincesAppService
	{
		private IRepository<Provinces> _repositoryProvices;
		public ProvincesAppService(
			IRepository<Provinces> repositoryProvices
			)
		{
			_repositoryProvices = repositoryProvices;
		}

		public async Task Create(CreateProvinceDto input)
		{
			var existing = await _repositoryProvices.FirstOrDefaultAsync(x => x.Name == input.Name);
			if (existing != null)
			{
				throw new UserFriendlyException("The province already exists");
			}
			var newProvince = new Provinces();
			newProvince.Name = input.Name;
			newProvince.DisplayName = input.DisplayName;
			newProvince.Description = input.Description;
			newProvince.Code = input.Code;
			newProvince.Region = input.Region;

			await _repositoryProvices.InsertAsync(newProvince);
		}
	}
}
