#include "deck.h"
#include <iostream>
#include <string>
using namespace std;

Deck::Deck(){

}
Deck::Deck(string rank, string suit) : Card(rank, suit){
	newrank = rank;
	newsuit = suit;
}
Deck::~Deck(){


}