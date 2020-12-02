using Discord;
using Discord.Commands;
using Discord.Rest;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeqqV2
{
    public class General : ModuleBase<SocketCommandContext>
    {
        Program program = new Program();
        internal static ulong gameReaction;

        [Command("Info")]
        public async Task Info(SocketMessage message)
        {
            var embed = new EmbedBuilder()
            .AddField("Role", $"{ String.Join(separator: "\n" ,values:((SocketGuildUser)message.Author).Roles) }", inline: true)
            .AddField("Data Założenia konta", message.Author.CreatedAt.ToString("dd/MM/yyyy").ToString(), inline: true)
            .AddField("Joined at", (message.Author as SocketGuildUser).JoinedAt.Value.ToString("dd/MM/yyyy"), inline: true)
            .AddField("*","*" , inline: false)
            .WithAuthor(message.Author)
            .WithFooter(footer => footer.Text = (message.Author.Id).ToString())
            .WithColor(Color.Red)
            .WithCurrentTimestamp()
            .Build();
            await message.Channel.SendMessageAsync(null, false, embed);
                
        }

        [Command("GamesReactionRolesEmbed")]
        public async Task GameReaction(SocketMessage message)
        {
            var embed = new EmbedBuilder()
            .WithTitle("Get Game Roles!")
            .WithDescription("Zareaguj na odpowiednie emoji by dostać związaną z nimi role gry!")
            .WithColor(Color.DarkGreen)
            .Build();
            var embed2 = (RestUserMessage) await message.Channel.SendMessageAsync(null, false, embed);
            gameReaction = embed2.Id;
            //SocketGuild guild = ((SocketGuildChannel)message.Channel).Guild;
            //IEmote emote = guild.Emotes.First(e => e.Name == "<GreenSkullx2:702259923916161054>"); 
            //new Emoji("<:GreenSkullx2:702259923916161054>")
            string[] emoji = {
                ":R6:782595003419590676",
                ":LOL:782598251638423602",
                ":AmongUS:782597899712200724" ,
                ":HumanFallFlat:782595415996235796",
                ":unnamed:782598005068398592",
                ":WOT:782595447780409405",
                ":GTAV:782594917700599858",
                ":PUBG:782594976219398144",
                ":Minecraft:782595339533942794",
                ":CS:782595231005802507",
                ":Forza:782594893159202816",
                ":Valorant:782595021466763284",
                ":Roblox:782594956065243146",
                ":Diablo:782595315710165012"}; 
            foreach(string emoji2 in emoji)
                await embed2.AddReactionAsync(new Emoji(unicode: emoji2));
            

        }
       
    }
}


