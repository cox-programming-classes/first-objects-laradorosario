using System.Net.Sockets;

namespace FirstObjects_2024;

public class Hand //: IEnumerable<Card>
{
    private List<Card> _cards;
    
    // ^ "this is a hand of cards"
    // next, we need to initialize the hand -- need a constructor method 
    //start out empty

    /// <summary>
    /// initialize hand of cards - start out empty
    /// </summary>

    public Hand()
    {
        _cards = [];
    } //start out empty 
    
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
        _cards.
    }

    public bool Has(Suit)
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
        
    
            
        
}