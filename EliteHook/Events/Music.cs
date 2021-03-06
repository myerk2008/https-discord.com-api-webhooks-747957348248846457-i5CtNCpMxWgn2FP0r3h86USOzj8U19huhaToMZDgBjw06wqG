﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Events;
using Discord;
using EliteAPI;

namespace EliteHook.Events
{
    internal static class Music
    {
        internal static void EliteAPI_MusicEvent(object sender, MusicInfo e)
        {
            switch(e.MusicTrack.ToLower())
            {
                case "mainmenu":
                    EmbedBuilder embed = new EmbedBuilder();
                    embed.WithTitle("In the main menu");
                    Main.Send(embed);
                    break;

                case "dockingcomputer":
                    EmbedBuilder embed2 = new EmbedBuilder();
                    embed2.WithTitle("Using autopilot");
                    embed2.WithDescription($"To dock at {Main.EliteAPI.Location.Station}\nIn {Main.EliteAPI.Location.StarSystem}");
                    Main.Send(embed2);
                    break;
            }


        }
    }
}
