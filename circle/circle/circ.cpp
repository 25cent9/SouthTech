#include "circ.h"

Circ::Circ(){
	newRadius = 0.0;
	newColor = "Blue";
}

Circ::Circ(double radius, string color){
	newRadius = radius;
	newColor = color;
}
Circ::Circ(double radius){
	newRadius = radius;
	newColor = "Blue";
}
Circ::~Circ(){

}

double Circ::getRadi()const{
	return newRadius;
}
string Circ::getColor()const{
	return newColor;
}
double Circ::calcArea(){
	return (3.14*(newRadius*newRadius));
}