using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace VietNamTourism.Entities
{
	[Table("Categories", Schema = VietNamTourismConsts.DefaultSchema)]
	public class Categories : FullAuditedEntity<int>
	{
		[Required]
		[StringLength(VietNamTourismConsts.MaxNameLength, MinimumLength = VietNamTourismConsts.MinNameLength)]
		public string Name { get; set; }
		public string? Description { get; set; }
	}
}
