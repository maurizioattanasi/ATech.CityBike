namespace ns;

public interface IFileRepository : IRepository<FileItem, uint>
{
    Task<FileItem?> GetByUriOrPathAsync(string uriOrPath, CancellationToken cancellationToken = default);
}