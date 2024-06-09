using System;
using System.Collections.Generic;

// Interfejs obserwatora
public interface IPlayerObserver
{
    void Update(Player[] players);
}

// Klasa podmiotu (subiekta)
public class Game
{
    private List<IPlayerObserver> observers = new List<IPlayerObserver>();
    private Player[] players;

    public void Attach(IPlayerObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IPlayerObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(players);
        }
    }

    public void UpdatePlayerScore(int playerId, int newScore)
    {
        players[playerId].Score = newScore;
        Notify();
    }

    // Metoda symulująca zmianę wyników gry
    public void SimulateGame()
    {
        Random random = new Random();
        for (int i = 0; i < players.Length; i++)
        {
            UpdatePlayerScore(i, random.Next(0, 101));
        }
    }

    public void StartGame(Player[] initialPlayers)
    {
        players = initialPlayers;
        SimulateGame();
    }
}

// Klasa obserwatora (gracza)
public class Player : IPlayerObserver
{
    public int PlayerId { get; private set; }
    public int Score { get; set; }

    public Player(int id)
    {
        PlayerId = id;
        Score = 0;
    }

    public void Update(Player[] players)
    {
        Console.WriteLine($"Player {PlayerId}: Updated scores:");
        foreach (var player in players)
        {
            Console.WriteLine($"Player {player.PlayerId} - Score: {player.Score}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie gry i graczy
        Game game = new Game();
        Player[] players = { new Player(1), new Player(2), new Player(3) };

        // Dodawanie graczy do obserwatorów gry
        foreach (var player in players)
        {
            game.Attach(player);
        }

        // Rozpoczęcie gry i symulacja zmiany wyników
        game.StartGame(players);

        // Symulacja zmiany wyników
        game.UpdatePlayerScore(0, 90);
    }
}
