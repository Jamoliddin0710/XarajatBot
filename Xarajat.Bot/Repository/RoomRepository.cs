using Data.Context;
using Data.Entities;

namespace Xarajat.Bot.Repository;
    public class RoomRepository
    {
    private readonly XarajatDbContext _context;
    public RoomRepository(XarajatDbContext context)
    {
        _context = context;
    }

    public async Task<Room> GetRoomById(long chatId)
    {
        return await _context.Rooms.FindAsync(chatId);
    }
    public async Task AddRoomAsync(Room room)
    {
        await _context.AddAsync(room);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRoom(Room room)
    {
        _context.Update(room);
        await _context.SaveChangesAsync();
    }
}

