using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace VietNamTourism.Entities
{
	[Table("Districts", Schema = VietNamTourismConsts.DefaultSchema)]
	public class Districts : FullAuditedEntity<int>
	{
		[Required]
		[StringLength(VietNamTourismConsts.MaxNameLength, MinimumLength = VietNamTourismConsts.MinNameLength)]
		public string Name { get; set; }
		public string DisplayName { get; set; }
		public string? Description { get; set; }
		public string? Code { get; set; } // Ví dụ: mã tỉnh (VD: 11 - Điện Biên)
	}
}
