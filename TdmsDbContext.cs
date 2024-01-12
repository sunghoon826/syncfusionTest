using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class TdmsDataContext : DbContext
{
    public TdmsDataContext(DbContextOptions<TdmsDataContext> options) : base(options)
    {
    }

    public DbSet<TdmsFileData> TdmsFiles { get; set; }

    public class TdmsFileData
    {
        public int Id { get; set; } // Auto-increment ID
        public string FileName { get; set; }
        public byte[] Data { get; set; } // BLOB data
    }
}
