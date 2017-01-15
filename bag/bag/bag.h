

#ifndef BAG_H
#define BAG_H

#include <iostream>
#include <string>
#include <vector>

using namespace std;

typedef string BAG_ELEMENT_TYPE;

class bag{
public:

	bag();

	bag(int intitCapacity);

	~bag();

	void add(BAG_ELEMENT_TYPE newElement);
	bool remove(BAG_ELEMENT_TYPE removalElement);

	//Modifiers
	int capacity() const;
	int size() const;
	bool isEmpty() const; 

	//iterrators
	void first();
	void next();
	bool isDone() const;
	BAG_ELEMENT_TYPE currentItem() const;
 
private:
	vector<BAG_ELEMENT_TYPE> my_item;
	int my_size;
	int my_index;	//Internal pointer to traverse collection

};

#endif

