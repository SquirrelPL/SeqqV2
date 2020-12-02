using Discord;
using Discord.Commands;
using Discord.WebSocket;

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace SeqqV2
{
    
    class Program
    {
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();


        private DiscordSocketClient client;
        

        private IRole role;
        public async Task MainAsync()
        {
            ReactionRoles reactionRoles = new ReactionRoles();
 
            client = new DiscordSocketClient();
            client.MessageReceived += CommandHandeler;
            client.ReactionAdded += reactionRoles.AddReactionHandeler;
            client.ReactionRemoved += reactionRoles.RemoveReactionHandeler;
            client.Log += Log;
            

            var token = File.ReadAllText("Token.txt");

            await client.LoginAsync(Discord.TokenType.Bot, token);
            await client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg);
            return Task.CompletedTask;
        }
        //dwadaw
        private async Task<Task> CommandHandeler(SocketMessage message)
        {
            General general = new General();
            string command = "";
            int lenOfCommand = -1;



            if (message.Content.StartsWith("?"))
            {
                //Filtr Komend
                if (message.Content.Contains(' '))
                    lenOfCommand = message.Content.IndexOf(' ');
                else
                    lenOfCommand = message.Content.Length;

                command = message.Content.Substring(1, lenOfCommand - 1);

                //Komendy
                if (message.Author.Id == 345927009886535681)
                {
                    if (command.Equals("Hello"))
                        await message.Channel.SendMessageAsync(message.Author + " YEZZZZ");
                    else if (command.Equals("Age"))
                        await message.Channel.SendMessageAsync("Twoje konto zostało stworzone: " + (message.Author.CreatedAt));
                    else if (command.Equals("Info"))
                        await general.Info(message);
                    else if (command.Equals("GameRoles"))
                        await general.GameReaction(message);
                        await message.DeleteAsync();
                }
            }
            
            return Task.CompletedTask;
        }
    }
    
}
