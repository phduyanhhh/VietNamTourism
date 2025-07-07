using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietNamTourism.Entities;

namespace VietNamTourism.Services.ProvincesAppService.Dto
{
	public class EditProvinceDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string DisplayName { get; set; }
		public string? Description { get; set; }
		public string? Code { get; set; } // Ví dụ: mã tỉnh (VD: 11 - Điện Biên)
		public RegionEnum? Region { get; set; }
	}
}
