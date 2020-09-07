using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Additional Namespaces
using System.Data.Entity;
using ChinookSystem.ENTITIES;

namespace ChinookSystem.DAL
{
    internal class ChinookContext : DbContext
    {
        public ChinookContext() : base("name=ChinookDB")
        {
        }
        public DbSet<EArtist> Artists { get; set; }
        public DbSet<EAlbum> Albums { get; set; }
        public DbSet<ETrack> Tracks { get; set; }
    }
}
