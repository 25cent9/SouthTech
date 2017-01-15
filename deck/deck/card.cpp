#include "card.h"
#include <iostream>
using namespace std;
Card::Card(){

}
Card::Card(string rank, string suit){
	newRank = rank;
	newSuit = suit;
}
Card::~Card(){
	
}
string Card::getRank() const{
	return newRank;
}
string Card::getSuit() const{
	return newSuit;
}