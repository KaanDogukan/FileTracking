namespace FileTracking.Domain.Entities;
public class FileRecord
{
    public Guid FileId { get; set; }
    public string FileName { get; set; }
    public string? Description { get; set; }
    public DateTime ExpiryDate { get; set; }
    public DateTime UploadDate { get; set; }
    public string FilePath { get; set; }

}
