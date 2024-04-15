using System;

namespace ekzamen.Entities;

public class Player
{
    public Player( string playerName, string position, int weight, int height, DateTime birthday, DateTime gameStart, string team)
    {
        PlayerName = playerName;
        Position = position;
        Weight = weight;
        Height = height;
        Birthday = birthday;
        GameStart = gameStart;
        Team = team;
    }
    
    public string PlayerName { get; set; }
    public string Position { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public DateTime Birthday { get; set; }
    public DateTime GameStart { get; set; }
    public string Team { get; set; }
}