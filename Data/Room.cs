using Data.Entities;

namespace Data.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public RoomStatus RoomStatus { get; set; }
        
        public List<Outlay>? Outlays { get; set; }
        public List<User>? Users { get; set; }

    }
}