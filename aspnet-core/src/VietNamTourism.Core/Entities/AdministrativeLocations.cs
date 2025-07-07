using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using NetTopologySuite.Geometries;

namespace VietNamTourism.Entities
{
	[Table("AdministrativeLocations", Schema = VietNamTourismConsts.DefaultSchema)]
	public class AdministrativeLocations : FullAuditedEntity<int>
	{
		public Point Location { get; set; }
		public Geometry? Boundary { get; set; }
		// Provinces
		public Provinces? Province { get; set; }
		public int ProvinceId { get; set; }
		// Districts
		public Districts? District { get; set; }
		public int DistrictId { get; set; }
		// Communes
		public Communes? Commune { get; set; }
		public int CommuneId { get; set; }
		//
	}
}
