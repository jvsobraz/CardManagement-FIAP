using CardManagement_2TDSPH.Core.Domain.Entites.Card;
using Microsoft.EntityFrameworkCore;

namespace CardManagement_2TDSPH.Data.Context;

public class CardManagementDbContext : DbContext
{
    public CardManagementDbContext(DbContextOptions<CardManagementDbContext>
        options) : base(options)
    {
    }

    public DbSet<Card> Cards { get; set; }
    public DbSet<Print> Prints { get; set; }
    public DbSet<Set> Sets { get; set; }
    public DbSet<NoteAndRule> NotesAndRules { get; set; }
    public DbSet<RelatedLink> RelatedLinks { get; set; }
    public DbSet<Format> Formats { get; set; }
    public DbSet<Legalty> Legalties { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Print>()
            .HasOne(r => r.Card)
            .WithMany(q => q.Prints)
            .OnDelete(DeleteBehavior.Cascade);
    }

    
}