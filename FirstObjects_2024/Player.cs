using System.Data.SqlTypes;

namespace FirstObjects_2024;

public class Player
{
    ///<summary>
    /// private player's hand ~ only the player can see it
    /// </summary>
    private Hand _hand = new();

    Card DealOneFrom(List<Card> cards)
    {
        var card = cards[0];
        cards.RemoveAt(0);
        return card;

    }
    /// The player takes one more card from the Deck.
    public void Hit(Card card) => _hand.Add(card);


    /// Sets the Flag for 'DidStand' to True so that
    /// you know this Player is done.


    public void Stand() => DidStand = true;


    /// reset the player for a new round
    /// All cards in current hand are discarded, and DidStand
    /// is reset to false
    

    /// This is a "property"
    /// It can be read from outside og the Player class, however its
    /// 'set' method is Private, so it can only be modified within
    /// this class.

    public bool DidStand { get; private set; } = false;


    /// This is a calculated field, we create this property
    /// with /only/ a function. This property is secretly a method
    /// But, since it is representing a piece of data
    /// that describes this object (An Attribute, not a Behavior)
    /// it gets a noun name and no () after it
    public int Score
    {
        get
        {
            //calculate score
            var total = 0;
            foreach (var card in _hand)
                total += card.Value;
            // Todo: what happens it theres an Ace, and you want to value it at 11?
            // -> collect input from the user on whether the ace is 1 or 11
            //depending on user's input count add either 1 or 11 pts to total
            //if ace is set as 1 right now, you can count it as 1 and then add on 10 pts
            // or, temp remove the aces from the hand, calculate the total, then run the
            // posibilities with ace as 11, if it goes over the value 21, keep ace as 1

            return total;

        }
    }

        ///<summary>
        /// Get the Player's Hand and computed score
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{_hand} => {Score}";

}
