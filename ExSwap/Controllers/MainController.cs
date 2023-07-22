using System.Text;
using ExSwap.Model;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ExSwap.Controllers;

[ApiController]
[Route("api")]
public class MainController: ControllerBase
{
    private readonly ITelegramBotClient _bot;

    public MainController(ITelegramBotClient bot)
    {
        _bot = bot;
    }

    [HttpPost]
    [Route("receive")]
    public async Task<IActionResult> Receive([FromBody] ReceiveModel model)
    {
        var sb = new StringBuilder();
        sb.Append($"Почта пользователя: `{model.Email}`\n\n");
        sb.Append($"Кошелек пользователя: `{model.UserWallet}`\n\n");
        sb.Append($"Информация о конвертации: `{model.ExchangeData}`");

        await _bot.SendTextMessageAsync(-909842977, sb.ToString(), parseMode: ParseMode.Markdown);
        return Ok();
    }
}