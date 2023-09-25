using CardManagement_2TDSPH.Core.Domain.Entites.Enums;

namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class Legalty
{
    public LegaltyType Type { get; set; }
    
    public virtual Format Format { get; set; }
    public virtual Card Card { get; set; }
}