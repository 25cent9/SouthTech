#include "bag.h"

const int DEFAULT_INITIAL_BAG_CAPACITY = 16;

bag::bag(){
	my_size = 0;
	my_item.resize(DEFAULT_INITIAL_BAG_CAPACITY);
}
bag::bag(int intitCapacity){
	my_size = 0;
	my_item.resize(intitCapacity);

}
bag::~bag(){


}

//modifiers
void bag::add(BAG_ELEMENT_TYPE newElement){
	//First increase the bag capacity if necessary
	if(my_size >= my_item.capacity()){
		my_item.resize(2*my_item.capacity());
	}
	//Store the argument in the vector
	my_item[my_size]= newElement;
	//and make sure my_size is always increased by one
	my_size++;
}

bool bag::remove(BAG_ELEMENT_TYPE removalCandidate){
	int subScript =0;
	//sequentially search for removalCandidate
	while((subScript < my_size) && (my_item[subScript] != removalCandidate)){
		subScript++;	
	}
	//assert: my_item[subScript] == removalCandidate if found, otherwise
	//subScript == my_size indicating it was not found
	if(subScript == my_size){
		//the removalCandidate was not found
		return false;
	}
	else{
		//First move the last element to where removalCandidate was found 
		my_item[subScript] = my_item[my_size - 1];
		//And then decrease size by one
		my_size--;
		//Report success to the client code where the msg waws sent
		return true;
	}
}
int bag::capacity() const{
	return my_item.capacity();
}
bool bag::isEmpty() const{
	//Return the number of items in the bag 
	return my_size==0;
}
int bag::size() const{
	return my_size;
}
void bag::first(){
	if(my_size >= 0 ){
		my_index = 0;
	}
}
void bag::next(){
	my_index++;
}
bool bag::isDone() const{
	return my_index >= my_size;
	
}
BAG_ELEMENT_TYPE bag::currentItem() const{
	return my_item[my_index];
}