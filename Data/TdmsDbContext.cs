using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace syncfusionTest.Data
{
    public class TdmsDataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public TdmsDataContext(IConfiguration configuration, DbContextOptions<TdmsDataContext> options) : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<TdmsFileData> TdmsFiles { get; set; }

        public class TdmsFileData
        {
            public int? Id { get; set; } // Auto-increment ID
            public string? FileName { get; set; }
            public byte[]? Data { get; set; } // BLOB data
        }
    }
}
