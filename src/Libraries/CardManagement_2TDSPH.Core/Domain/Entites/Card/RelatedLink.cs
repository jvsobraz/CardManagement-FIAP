using CardManagement_2TDSPH.Core.Domain.Entites.Enums;

namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class RelatedLink
{
    public string name { get; set; }
    public string Uri { get; set; }
    public LinkCategory Category { get; set; }
    public virtual Card Card { get; set; }
}