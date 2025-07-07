using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;

namespace VietNamTourism.Entities
{
	[Table("Provinces", Schema = VietNamTourismConsts.DefaultSchema)]
	public class Provinces : FullAuditedEntity<int>
	{
		[Required]
		[StringLength(VietNamTourismConsts.MaxNameLength, MinimumLength = VietNamTourismConsts.MinNameLength)]
		public string Name { get; set; }
		public string DisplayName { get; set; }
		public string? Description { get; set; }
		public string? Code { get; set; } // Ví dụ: mã tỉnh (VD: 11 - Điện Biên)
		public RegionEnum? Region { get; set; }
	}
	public enum RegionEnum
	{
		NorthernMidlandsAndMountains = 0, // Trung du mien nui phia bac
		RedRiverDelta = 1, // Dong bang song hong
		NorthCentral = 2, // Bac trung bo
		SouthCentralCoast = 3, // Duyen hai nam trung bo
		CentralHighlands = 4, // Tay nguyen
		Southeast = 5, // Dong nam bo
		MekongDelta = 6 // dong bang song cuu long
	}
}
