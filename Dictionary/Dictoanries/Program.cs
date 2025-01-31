using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    static void Main()
    {
        Run();
    }

    static void Run()
    {
        // Kamer toevoegen
        Room startRoom = new Room(0, 0, "Startkamer");
        rooms.Add(startRoom.GetRoomLocationKey(), startRoom);

        // Kamers tonen
        ShowRoom(0, 0);
        ShowRoom(1, 1);
    }

    static void ShowRoom(int x, int y)
    {
        string key = Room.GetRoomLocationKey(x, y);
        if (rooms.ContainsKey(key))
        {
            Console.WriteLine("Kamer: " + rooms[key].Description);
        }
        else
        {
            Console.WriteLine("Kamer niet gevonden!");
        }
    }
}

class Room
{
    public int X { get; }
    public int Y { get; }
    public string Description { get; }

    public Room(int x, int y, string description)
    {
        X = x;
        Y = y;
        Description = description;
    }

    internal string GetRoomLocationKey()
    {
        return GetRoomLocationKey(X, Y);
    }

    internal static string GetRoomLocationKey(int x, int y)
    {
        return $"{x},{y}";
    }
}
