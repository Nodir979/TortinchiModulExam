using System;
using Telegram.Bot;
using Telegram.Bot.Args;

public class BotService
{
    private readonly TelegramBotClient _bot;

    public BotService()
    {
        _bot = new TelegramBotClient("YOUR_BOT_TOKEN_HERE");
    }

    public void Start()
    {
        _bot.OnMessage += Bot_OnMessage;
        _bot.StartReceiving();
        Console.WriteLine("Bot ishga tushdi.");
    }

    private async void Bot_OnMessage(object sender, MessageEventArgs e)
    {
        if (e.Message.Text != null)
        {
            await _bot.SendTextMessageAsync(e.Message.Chat.Id, "Salom!");
        }
    }
}