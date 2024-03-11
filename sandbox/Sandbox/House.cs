using System;

class House
{
    private List<Room> _rooms;

    public House(List<Room> rooms)
    {
        _rooms = rooms;
    }

    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }

}