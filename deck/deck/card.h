#ifndef CARD_H
#define CARD_H
#include <iostream>
#include <string>
using namespace std;

class Card{

public:
	
	Card();
	Card(string, string);
	~Card();
	string getRank() const;
	string getSuit() const;

private:
	string newSuit;
	string newRank;
};
#endif