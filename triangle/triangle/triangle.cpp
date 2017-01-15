#include "triangle.h"
#include <iostream>	

Triangle::Triangle(){
	newHeight = 0;
}
Triangle::Triangle(int height){
	newHeight = height;
}
int Triangle::getHeight() const{
	return newHeight;
}
void Triangle::setHeight(int height) {
	newHeight = height;
}
Triangle::~Triangle(){
}
double Triangle::getArea(int base) const{
	return (0.5*base*newHeight);
}