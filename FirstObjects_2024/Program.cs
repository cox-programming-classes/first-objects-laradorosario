using FirstObjects_2024;

Console.WriteLine("Let's Play Cards/Blackjack!");
// create a new deck
Deck deck = new();
deck.Shuffle();

Player dealer = new(), player = new();
//deal 2 cards to each player
dealer.Hit(deck.DealOne());
player.Hit(deck.DealOne());
dealer.Hit(deck.DealOne());
player.Hit(deck.DealOne());

//show the Player their Hand
Console.WriteLine($"Player: {player}");
while (!player.DidStand)
{
    if (dealer.Score < 18)
        dealer.Hit(deck.DealOne());
    else dealer.Stand();
    
    Console.WriteLine("[H]it or [S]tand");
    var response = Console.ReadLine()!.ToUpperInvariant();
    
    //Check what to do depending on the player's choice
    if(response.StartsWith("H"))
        player.Hit(deck.DealOne());
    else if (response.StartsWith("S"))
        player.Stand();
    else
        Console.WriteLine("???");
   
        
}

//Give the dealer a chance to continue
while (!dealer.DidStand)
{
    if (dealer.Score < 18)
        dealer.Hit(deck.DealOne());
    else dealer.Stand();
    
}    

Console.WriteLine($"Player: {player}");

Console.WriteLine($"Dealer: {dealer}");

//Todo: decide who wins?

//Card card = new (Suit.Spades, Value.AceHigh);
//Console.WriteLine($"Check out that {card}!");

//var cards = deck.Deal(6).ToList(); //debug - step over, step into -> it came over into that method (look for n = 6) 

//Console.WriteLine("I dealt some cards"); 
//foreach (var card in deck)
//{
//    Console.WriteLine(card);
//}

//Deck deck;
//private Hand deck = deck.Deal(<Card>): 2;
//while(players.Any(players=>!players.IsStand);

//Player[] players

//_______________________
// Methods with Cards slideshow
//________________________

//Card InitializeDeck(int aceHigh = 1)
//{
//    var deck = new Card[52];
//    for(int i = 0; i < 4; i++) //four suits
//}

   