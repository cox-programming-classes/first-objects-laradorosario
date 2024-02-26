using System.Collections;

namespace FirstObjects_2024;

///<summary>///
/// Making a standard deck of playing cards
/// </summary>
public class Deck : IEnumerable<Card>
{
    private List<Card> _cards;

    ///<summary>
    /// Are there any cards left in the deck?
    /// </summary>
    public bool IsEmpty => _cards.Count == 0;
    
    /// <summary>
    /// Initialize a new deck of cards
    /// </summary>
    public Deck() ///constructor method (constructing objects, generating cards)
    {
        _cards = [];
        foreach(var suit in Suit.AllSuits)
            foreach(var value in Value.AceHighValues)
                _cards.Add(item: new Card(suit, value));
    }

    ///<summary>
    /// deal one card from the deck
    /// </summary>
    /// <returns> a card </returns>

    Card DealOneFrom(List<Card> cards)
    {
        var card = cards[0];
        cards.RemoveAt(0);
        return card;
    }

    /// <summary>
    /// deal the first card from this Deck
    /// </summary>
    /// <returns>The top card</returns>
    /// <exception cref="InvalidOperationException">When the deck is empty</exception>
    public Card DealOne()
    {
        if (_cards.Count == 0)
            throw new InvalidOperationException(message: "deck is empty");
        var card = _cards.First();
        _cards.RemoveAt(index: 0); // if you don't remove it, you are making a copy
        return card;

    }

    /// <summary>
    /// deal n cards from the deck (be sure to cast this as a concrete type immediately, otherwise cards will be deleted
    /// </summary>
    /// <param name="n"> n is number of cards to return</param>
    /// <returns></returns>
    public IEnumerable<Card> Deal(int n) //a collection that can be iterated over
    {
        for (var i = 0; i < n; i++)   //for loop: only executes a number of times
            // i=0 -> counter / i<n -> end condition / i++ -> increment
            
            yield return DealOne();
    }
    
    /// <summary>
    /// Insert a single card at the bottom of the deck
    /// </summary>
    /// <param name="card">The card to add.</param>
    public void AddToBottom(Card card) => _cards.Add(card);
    
    /// <summary>
    /// Add a collection of cards to the bottom of the deck
    /// </summary>
    /// <param name="cards">Cards to be added to the deck.</param>
    public void AddToBottom(IEnumerable<Card> cards) => _cards.AddRange(cards);

    /// <summary>
    /// Using the random number generator,
    /// insert the card randomly into the current list of cards.
    /// </summary>
    /// <param name="card">the card to be inserted.</param>
    public void InsertRandomly(Card card)
    {
        
    } // <-- where it says deck is where the 3 dots were
                                                // i dont know if it is right

                                                /// <summary>
    /// Using random number generator,
    /// insert EACH card from this collection randomly into the deck.
    /// </summary>
    /// <param name="cards">the card to be inserted.</param>
    public void InsertRandomly(IEnumerable<Card> cards)
    {
        
    } // <-- where it says deck is where the 3 dots were
    // i dont know if it is right

    /// <summary>
    /// Shuffle the deck
    /// step 1) split the deck with a method 2) insert pile 1 and 2
    /// 
    /// </summary>
    public void Shuffle(List<Card> cards)
    {
        
    } // <-- where it says deck is where the 3 dots were
    // i dont know if it is right

    /// <summary>
    /// split
    /// </summary>
    /// <returns></returns>
    ///

    private (List<Card>, List<Card>) Split()
    {
        var pile1 = new List<Card>();
        var pile2 = new List<Card>();
        var count = _cards.Count;
        for (int i = 0; i < count; i++)
        {
            if (i % 2 == 0)
            {
             pile1.Add(DealOne());   
            }
            else pile2.Add();
            
        }

        return (pile1, pile2);
    }

    
                                                


    #region Enumerable stuff
    public IEnumerator<Card> GetEnumerator()
    {
        return _cards.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_cards).GetEnumerator();
    }
    #endregion // Enumerable stuff.
    
}