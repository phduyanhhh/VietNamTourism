﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace VietNamTourism.Services.LanguagesAppService.Dto
{
	public class GetAllLanguagesInput : PagedAndSortedResultRequestDto
	{
		public string? Search {  get; set; }
		public string? LanguageName { get; set; }
		public string? SourceName { get; set; }

	}
}
