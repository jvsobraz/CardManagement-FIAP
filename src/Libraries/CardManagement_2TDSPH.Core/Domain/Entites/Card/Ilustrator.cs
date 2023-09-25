namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class Ilustrator
{
    public string Name { get; set; }
    public virtual ICollection<Print> Prints { get; set; } = new List<Print>();
}