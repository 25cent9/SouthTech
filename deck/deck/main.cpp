/*
	Innocent Niyibizi
	11/2/15
	Create program to simulate a card deck
*/
#include "deck.h"
#include <iostream>
#include <string>
using namespace std;

void printDeck(Deck);
int main(){
	Deck card1("Eight", "Spades");
	printDeck(card1);

	system("pause");
	return 0;
}
void printDeck(Deck card){
	cout<<card.getRank()<<" of "<<card.getSuit()<<endl;
}