using FileTracking.Domain.Entities;

namespace FileTracking.Domain.Interfaces;
public interface IFileRepository
{
    Task<IEnumerable<FileRecord>> GetAllAsync();
    Task<FileRecord> GetByIdAsync(Guid fileId);
    Task AddAsync(FileRecord file);
    Task UpdateAsync(FileRecord file);
    Task DeleteAsync(Guid fileId);
}
