using Data.Context;
using Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Xarajat.Bot.Repository;
    public class UserRepository
    {
    private readonly XarajatDbContext _context;
    
    public UserRepository(XarajatDbContext xarajatDb)
    {
        _context = xarajatDb;
    }
    public async Task<User> GetUserByChatId(long chatId)
    {
       return  await _context.Users.FirstOrDefaultAsync(field => field.ChatId == chatId);
    }

    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
    
    public async Task UpdateUser(User user)
    {
         _context.Update(user);
         await _context.SaveChangesAsync();
    }
    }

