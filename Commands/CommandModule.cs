using System;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DiscordBotCSharp.Commands
{
    public class CommandModule : BaseCommandModule
    {
        [Command("tapotente")]
        public async Task GreetCommand(CommandContext ctx)
        {
            await ctx.RespondAsync("https://scontent.fmgf11-1.fna.fbcdn.net/v/t1.6435-9/131320070_431516578211689_1243111196655748668_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=8bfeb9&_nc_ohc=bBgVHBJQaGwAX85hQJR&_nc_ht=scontent.fmgf11-1.fna&oh=00_AfC-oXPx1b0wj7aC--KAM9aQ5g7D2iCwLbU3iVktFNvhoA&oe=65414777");
        }

        [Command("myname")]
        public async Task MyNameCommand(CommandContext ctx, [RemainingText] String name)
        {
            await ctx.RespondAsync($"Your name is: {name}.");
        }

        [Command("random")]
        public async Task RandomCommand(CommandContext ctx, int min, int max)
        {
            var random = new Random();
            await ctx.RespondAsync($"Your number is: {random.Next(min, max)}");
        }
    }
}
