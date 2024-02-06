using System.Collections;

namespace FirstObjects_2024;

///<summary>///
/// Making a standard deck of playing cards
/// </summary>
public class deck : IEnumerable<Card>
{
    private List<Card> cards;

    ///<summary>
    /// Are there any cards left in the deck?
    /// </summary>
    public bool IsEmpty => cards.Count == 0;
    
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

    /// <summary>
    /// deal the first card from this Deck
    /// </summary>
    /// <returns>The top card</returns>
    /// <exception cref="InvalidOperationException">When the deck is empty</exception>
    public Card DealOne()
    {
        if (cards.Count == 0)
            throw new InvalidOperationException(message: "deck is empty");
        var card = cards.First();
        cards.RemoveAt(index: 0); // if you don't remove it, you are making a copy
        return Card
    }

    /// <summary>
    /// Insert a single card at the bottom of the deck
    /// </summary>
    /// <param name="card">The card to add.</param>
    public void AddToBottom(Card card) => cards.Add(card);
    
    /// <summary>
    /// Add a collection of cards to the bottom of the deck
    /// </summary>
    /// <param name="cards">Cards to be added to the deck.</param>
    public void AddToBottom(IEnumerable<Card> cards) => cards.AddRange(cards);

    /// <summary>
    /// Using the random number generator,
    /// insert the card randomly into the current list of cards.
    /// </summary>
    /// <param name="card">the card to be inserted.</param>
    public void InsertRandomly(Card card){deck} // <-- where it says deck is where the 3 dots were
                                                // i dont know if it is right
    
    /// <summary>
    /// Using random number generator,
    /// insert EACH card from this collection randomly into the deck.
    /// </summary>
    /// <param name="cards">the card to be inserted.</param>
    public void InsertRandomly(IEnumerable<Card> cards){deck} // <-- where it says deck is where the 3 dots were
                                                // i dont know if it is right
    
    /// <summary>
    /// Shuffle the deck
    /// 
    /// </summary>
    public void Shuffle(){deck} // <-- where it says deck is where the 3 dots were
                                                // i dont know if it is right


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