using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using VietNamTourism.Entities;

namespace VietNamTourism.Services.ProvincesAppService.Dto
{
	public class ProvincesListDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string DisplayName { get; set; }
		public string? Description { get; set; }
		public string? Code { get; set; }
		public RegionEnum? Region { get; set; }
		public string RegionValue =>	Region?.ToString() ?? string.Empty;
	}
}
