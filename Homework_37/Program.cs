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
    private string _nickname;
    private int _level;
    private int _health;
    private int _damage;

    public Player(string nickname, int level, int health, int damage)
    {
        _nickname = nickname;
        _level = level;
        _health = health;
        _damage = damage;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Никнейм: {_nickname}.\nУровень: {_level}.\nЗдоровье: {_health}.\nУрон: {_damage}.");
    }
}