using BlaisePascal.EnemyPlayer.Domain;
using System;
using System.Numerics;

Player player = new Player("Paul");

Console.WriteLine($"Name: {player.Name}");
Console.WriteLine($"Level: {player.Level}");
Console.WriteLine($"Experience: {player.Experience}");
Console.WriteLine($"Health: {player.Health}/{player.MaxHealth}");
Console.WriteLine($"Alive: {player.IsAlive}");
Console.WriteLine($"Gold: {player.Gold}");

player.AddExperience(250);
Console.WriteLine($"Level: {player.Level}");       
Console.WriteLine($"Experience: {player.Experience}");

player.AddExperience(-10);
Console.WriteLine($"Experience: {player.Experience}");

player.ResetExperience();
Console.WriteLine($"Experience: {player.Experience}");

player.TakeDamage(30);
Console.WriteLine($"Health: {player.Health}");

player.Heal(20);
Console.WriteLine($"Health: {player.Health}");

player.Heal(100);
Console.WriteLine($"Health: {player.Health}");

player.TakeDamage(100);
Console.WriteLine($"Health: {player.Health}");
Console.WriteLine($"Alive: {player.IsAlive}");

player.Heal(50);
Console.WriteLine($"Health: {player.Health}");

player.ResetHealth();
Console.WriteLine($"Health: {player.Health}");
Console.WriteLine($"Alive: {player.IsAlive}");

player.AddGold(100);
Console.WriteLine($"Gold: {player.Gold}");

player.AddGold(-50);
Console.WriteLine($"Gold: {player.Gold}");
