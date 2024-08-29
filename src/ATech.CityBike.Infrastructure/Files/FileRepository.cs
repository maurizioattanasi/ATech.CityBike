namespace ns;

public class FileRepository(AppDbContext context)
    : Repository<FileItem, uint>(context), IFileRepository
{ }