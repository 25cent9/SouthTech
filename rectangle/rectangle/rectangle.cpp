#include "rectangle.h"

RECTANGLE::RECTANGLE(){
	newHeight= 0.0;
	newLength = 0.0;

}

RECTANGLE::RECTANGLE(double height, double length){
	newHeight = height;
	newLength= length;
}

RECTANGLE::~RECTANGLE(){

}

double RECTANGLE:: getHeight()const{
	return newHeight;
}
double RECTANGLE:: getLength()const{
	return newLength;
}
double RECTANGLE::calcArea(){
	return (newLength*newHeight);
}
double RECTANGLE::clacPerm(){
	return ((newLength*2)+(newHeight*2));
}