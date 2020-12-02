using Discord;
using Discord.Commands;
using Discord.WebSocket;

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace SeqqV2
{
    public class ReactionRoles : ModuleBase<SocketCommandContext>
    {
        public Func<Cacheable<IUserMessage, ulong>, ISocketMessageChannel, SocketReaction, Task> RemoveReactionHandeler2 { get; internal set; }

        public async Task<Task> AddReactionHandeler(Cacheable<IUserMessage, ulong> message, ISocketMessageChannel channel, SocketReaction reaction)
        {
            //Console.WriteLine(General.gameReaction);
            if (message.Id == General.gameReaction)
            {
                try
                {
                    if (channel is SocketTextChannel textChannel)
                    {
                        IRole role;
                        var user = textChannel.Guild.GetUser(reaction.UserId);
                        switch (reaction.Emote.Name)
                        {
                            case "R6":
                                role = textChannel.Guild.GetRole(696784476172451863);
                                await user.AddRoleAsync(role);
                                break;
                            case "LOL":
                                role = textChannel.Guild.GetRole(724630435195256924);
                                await user.AddRoleAsync(role);
                                break;
                            case "AmongUS":
                                role = textChannel.Guild.GetRole(749651348584399008);
                                await user.AddRoleAsync(role);
                                break;
                            case "HumanFallFlat":
                                role = textChannel.Guild.GetRole(703006182020874270);
                                await user.AddRoleAsync(role);
                                break;
                            case "unnamed":
                                role = textChannel.Guild.GetRole(456454238801887232);
                                await user.AddRoleAsync(role);
                                break;
                            case "WOT":
                                role = textChannel.Guild.GetRole(456454276890230784);
                                await user.AddRoleAsync(role);
                                break;
                            case "GTAV":
                                role = textChannel.Guild.GetRole(456454320007938059);
                                await user.AddRoleAsync(role);
                                break;
                            case "PUBG":
                                role = textChannel.Guild.GetRole(456454619346763797);
                                await user.AddRoleAsync(role);
                                break;
                            case "Minecraft":
                                role = textChannel.Guild.GetRole(456454657410203649);
                                await user.AddRoleAsync(role);
                                break;
                            case "CS":
                                role = textChannel.Guild.GetRole(456454915104047116);
                                await user.AddRoleAsync(role);
                                break;
                            case "Forza":
                                role = textChannel.Guild.GetRole(698235330540863509);
                                await user.AddRoleAsync(role);
                                break;
                            case "Valorant":
                                role = textChannel.Guild.GetRole(728330936285921341);
                                await user.AddRoleAsync(role);
                                break;
                            case "Roblox":
                                role = textChannel.Guild.GetRole(728334339607101562);
                                await user.AddRoleAsync(role);
                                break;
                            case "Diablo":
                                role = textChannel.Guild.GetRole(728952822137225247);
                                await user.AddRoleAsync(role);
                                break;
                            default:
                                break;
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                //var guild = client.GetGuild(Convert.ToUInt64(message.Value.Id));
                //IGuildUser guildUser = guild.GetUser(Convert.ToUInt64(reaction.UserId));
                //IGuildUser guild = (IGuildUser)client.GetGuild(Convert.ToUInt64(reaction.UserId));// var user = guild.GetUser(Convert.ToUInt64(message));
            }


            return Task.CompletedTask;
        }


        public async Task<Task> RemoveReactionHandeler(Cacheable<IUserMessage, ulong> message, ISocketMessageChannel channel, SocketReaction reaction)
        {
            if (message.Id == General.gameReaction)
            {
                try
                {
                    if (channel is SocketTextChannel textChannel)
                    {
                        IRole role;
                        var user = textChannel.Guild.GetUser(reaction.UserId);
                        switch (reaction.Emote.Name)
                        {
                            case "R6":
                                role = textChannel.Guild.GetRole(696784476172451863);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "LOL":
                                role = textChannel.Guild.GetRole(724630435195256924);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "AmongUS":
                                role = textChannel.Guild.GetRole(749651348584399008);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "HumanFallFlat":
                                role = textChannel.Guild.GetRole(703006182020874270);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "unnamed":
                                role = textChannel.Guild.GetRole(456454238801887232);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "WOT":
                                role = textChannel.Guild.GetRole(456454276890230784);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "GTAV":
                                role = textChannel.Guild.GetRole(456454320007938059);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "PUBG":
                                role = textChannel.Guild.GetRole(456454619346763797);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "Minecraft":
                                role = textChannel.Guild.GetRole(456454657410203649);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "CS":
                                role = textChannel.Guild.GetRole(456454915104047116);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "Forza":
                                role = textChannel.Guild.GetRole(698235330540863509);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "Valorant":
                                role = textChannel.Guild.GetRole(728330936285921341);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "Roblox":
                                role = textChannel.Guild.GetRole(728334339607101562);
                                await user.RemoveRoleAsync(role);
                                break;
                            case "Diablo":
                                role = textChannel.Guild.GetRole(728952822137225247);
                                await user.RemoveRoleAsync(role);
                                break;
                            default:
                                break;
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return Task.CompletedTask;
        }
    }


}