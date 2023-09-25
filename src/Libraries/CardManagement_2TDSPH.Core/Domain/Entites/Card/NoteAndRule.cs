namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class NoteAndRule
{
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
    public virtual Card Card { get; set; }
}