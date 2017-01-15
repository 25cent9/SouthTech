#ifndef DECK_H
#define DECK_H
#include <iostream>
#include "card.h"

using namespace std;

class Deck : public Card{

public:
	Deck();
	Deck(string, string);
	~Deck();
private:
	string newsuit;
	string newrank;

};
#endif