using FileTracking.Domain.Entities;
using FileTracking.Domain.Interfaces;
using FileTracking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FileTracking.Infrastructure.Repositories;
public class FileRepository : IFileRepository
{
    private readonly AppDbContext _context;

    public FileRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FileRecord>> GetAllAsync()
    {
        return await _context.FileRecorders.ToListAsync();
    }

    public async Task<FileRecord> GetByIdAsync(Guid fileId)
    {
        return await _context.FileRecorders.FindAsync(fileId);
    }
    public async Task AddAsync(FileRecord file)
    {
        await _context.FileRecorders.AddAsync(file);
        await _context.SaveChangesAsync();
    }


    public async Task UpdateAsync(FileRecord file)
    {
        _context.FileRecorders.Update(file);
        await _context.SaveChangesAsync();

    }
    public async Task DeleteAsync(Guid fileId)
    {
        var entity = await _context.FileRecorders.FindAsync(fileId);
        if (entity != null)
        {
            _context.FileRecorders.Remove(entity);
            await _context.SaveChangesAsync();

        }
    }
}
