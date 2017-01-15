// Function Definition 

#include "BMI.h"


BMI::BMI(){
	//String deos not need to be "" becasue C++ does this for you on strings
	newHeight = 0;
	newWeight = 0.0;
}

BMI::BMI(string name, int height, double weight){
	//This is the overloaded consdtructor 
	newName = name;
	newHeight = height;
	newWeight = weight;
}

BMI::~BMI(){

}
string BMI::getName()const{
	return newName;
}
int BMI::getHeight()const{
	return newHeight;
}
double BMI::getWeight()const{
	return newWeight;
}
void BMI::setName(string name){
	newName = name;
}
void BMI::setHeight(int height){
	newHeight = height;
}
void BMI::setWeight(double weight){
	newWeight = weight;
}
double BMI::calcBMI(){

	return ((newWeight*703)/(newHeight*newHeight)); 
}