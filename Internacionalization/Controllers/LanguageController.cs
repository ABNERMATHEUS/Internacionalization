using Internacionalization.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Internacionalization.Controllers;

[ApiController]
[Route("[controller]")]
[TranslateInternacionalization]
public class LanguageController : ControllerBase
{

    [HttpGet]
    public ActionResult<string> GetLanguange()
    {
        return Languages.LanguageInternacionalization.get_language;
    }
}