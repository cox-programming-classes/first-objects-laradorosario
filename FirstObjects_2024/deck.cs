using System.Collections;

namespace FirstObjects_2024;

///<summary>///
/// Making a standard deck of playing cards
/// </summary>
public class deck : IEnumerable<Card>
{
    private List<Card> cards;
    
    /// <summary>
    /// Initialize a new deck of cards
    /// </summary>
    public deck()
    {
        cards = [];
        foreach(var suit in Suit.AllSuits)
            foreach(var value in Value.AceHighValues)
                cards.Add(item: new Card(suit, value));
    }
    
    #region Enumerable stuff
    public IEnumerator<Card> GetEnumerator()
    {
        return cards.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)cards).GetEnumerator();
    }
    #endregion // Enumerable stuff.
    
}