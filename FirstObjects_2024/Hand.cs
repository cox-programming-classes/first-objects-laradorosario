using System.Collections;
using System.Net.Sockets;

namespace FirstObjects_2024;

public class Hand : IEnumerable<Card>
{
    private static readonly Random RNG = new();
    private readonly List<Card> _cards;
    
    // ^ "this is a hand of cards"
    // next, we need to initialize the hand -- need a constructor method 
    //start out empty

    /// <summary>
    /// initialize hand of cards - start out empty
    /// </summary>

    public Hand() => _cards = new();

    public Hand(IEnumerable<Card> cards);
    
    /// <summary>
    /// add a card
    /// </summary>
    /// <param name="a"></param>

    public void Add(Card a) { _cards.Add(a); } //add a card

    /// <summary>
    ///  take method
    /// </summary>
    /// <returns></returns>
    public Card Take() //Method: take 
            ///  the method below is what to do with 1 card 
        {
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

    /// <summary>
    /// take RANDOM card
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public Card TakeRandomly()
        {
            var n = Random.Next(_cards.Count);
            Card Take(n);
            _cards.Add(n);
            return _cards;
            
        }

    public bool Has(Suit);
      bool ifHearts = new('\u2661');

    
    
        // public IEnumerable<Card> Deal(int n) //a collection that can be iterated over
    
        //for (var i = 0; i < n; i++) //for loop: only executes a number of times
            // i=0 -> counter / i<n -> end condition / i++ -> increment

         //   yield return DealOne();
    
    //Console.WriteLine("A hand of cards!");
    // create a new deck
    //Hand deck = new();
        //foreach (var card in Hand)
    //var cards = deck.Deal(6).ToList();

    public IEnumerator<Card> GetEnumerator()
        {
            return _cards.GetEnumerator();
        }

    /// <summary>
    /// Set a string representaion of this Hand of Cards.
    ///Gets each card as a string
    /// Then combines then into a comma separated list
    /// </summary>
    /// <returns></returns>

    public override string ToString() =>
        _cards
            .Select(card => $"{card}")
            .Aggregate((a, b) => $"{a}, {b}"); //what is a and b here

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_cards).GetEnumerator();
    }
}