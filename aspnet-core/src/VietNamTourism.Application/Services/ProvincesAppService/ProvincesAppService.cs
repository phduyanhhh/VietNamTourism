using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
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

		public async Task<PagedResultDto<ProvincesListDto>> GetAllProvinces(GetAllProvincesInput input)
		{
			var query = _repositoryProvices.GetAll()
				.WhereIf(!input.Search.IsNullOrWhiteSpace(),
					x => input.Search.ToLower().Contains(x.Name) || input.Search.ToLower().Contains(x.DisplayName))
					.OrderByDescending(x => x.CreationTime);

			var Count = query.Count();

			if (input.Sorting.IsNullOrWhiteSpace())
			{
				input.Sorting = "Code ASC";
			}

			var getAllProvinces = await query.PageBy(input).OrderBy(input.Sorting)
				.Select(x => new ProvincesListDto
				{
					Id = x.Id,
					Name = x.Name,
					DisplayName = x.DisplayName,
					Description = x.Description,
					Code = x.Code,
					Region = x.Region,
				})
				.ToListAsync();
			return new PagedResultDto<ProvincesListDto>(Count, getAllProvinces);
		}

		public async Task<ProvincesListDto> GetAnProvince(int id)
		{
			var query = await _repositoryProvices.FirstOrDefaultAsync(p => p.Id == id);
			if (query == null)
			{
				throw new UserFriendlyException("Province does not exist or has been deleted");
			}
			var getAnProvince = new ProvincesListDto
			{
				Id = id,
				Name = query.Name,
				DisplayName = query.DisplayName,
				Description = query.Description,
				Code = query.Code,
				Region = query.Region,
			};
			return getAnProvince;
		}

		public async Task EditProvince(EditProvinceDto input)
		{
			var existingProvince = await _repositoryProvices.FirstOrDefaultAsync(x => x.Id == input.Id);
			if (existingProvince == null)
			{
				throw new UserFriendlyException("Province does not exist or has been deleted");
			}
			existingProvince.Name = input.Name;
			existingProvince.DisplayName = input.DisplayName;
			existingProvince.Description = input.Description;
			existingProvince.Code = input.Code;
			existingProvince.Region = input.Region;

			await _repositoryProvices.UpdateAsync(existingProvince);
		}

		public async Task DeleteProvince(int id)
		{
			await _repositoryProvices.DeleteAsync(id);
		}
	}
}
