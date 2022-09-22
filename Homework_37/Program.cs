using System;

internal class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("forofonof", 15, 125, 50);

        player.ShowInfo();
    }
}

class Player
{
    public string Nickname;
    public int Level;
    public int Health;
    public int Damage;

    public Player(string nickname, int level, int health, int damage)
    {
        Nickname = nickname;
        Level = level;
        Health = health;
        Damage = damage;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Никнейм: {Nickname}.\nУровень: {Level}.\nЗдоровье: {Health}.\nУрон: {Damage}.");
    }
}