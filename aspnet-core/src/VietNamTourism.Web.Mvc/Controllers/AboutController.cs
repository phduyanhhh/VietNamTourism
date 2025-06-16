using Abp.AspNetCore.Mvc.Authorization;
using VietNamTourism.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace VietNamTourism.Web.Controllers;

[AbpMvcAuthorize]
public class AboutController : VietNamTourismControllerBase
{
    public ActionResult Index()
    {
        return View();
    }
}
