
using Data.Context;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Data.Entities;
using User = Data.Entities.User;
using Telegram.Bot.Types;
using Xarajat.Bot.Services;
using Telegram.Bot.Types.Enums;
namespace Xarajat.Bot.Controllers;

public class WebhookController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromServices] HandleUpdateService handleUpdateService,
                                          [FromBody] Update update)
    {
        await handleUpdateService.EchoAsync(update);
        return Ok();
    }

}