/*
	Object properties header
*/
#ifndef ITEM_H
#define ITEM_H
#include <iostream>
#include <string>
#include <vector>
using namespace std;
class Item{

public:
	Item();
	Item(string, string, string, string, string, string);
	~Item();

	string getNum() const;
	string getName() const;
	string getQty() const;
	string getWhlPrice() const;
	string getRetPrice() const;
	string getDate() const;

	static Item findElements(string);

	void setNum(string);
	void setName(string);
	void setQty(string);
	void setWhlPrice(string);
	void setRetPrice(string);
	void setDate(string);

private:
	string pNum;
	string pName;
	string qty;
	string whlPrice;
	string retPrice;
	string dateAdd;
};

#endif