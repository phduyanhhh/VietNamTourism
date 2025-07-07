using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace VietNamTourism.Services.ProvincesAppService.Dto
{
	public class GetAllProvincesInput : PagedAndSortedResultRequestDto
	{
		public string? Search { get; set; }
	}
}
