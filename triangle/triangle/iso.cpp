#include "iso.h"
#include "triangle.h"

Iso::Iso(){
	base = 0;
}
Iso::Iso(int newBase, int newSideOne, int newHeight):Triangle(newHeight){
	base = newBase;
	sideOne  = newSideOne;
	/*
		height = newHeight
		Happens when height is declared as a protected variable

	*/
}
Iso::~Iso(){

}
int Iso::getBase() const{
	return base;
}
void Iso::setSideOne(int newSideOne){
	Iso::sideOne=newSideOne;
}
void Iso::setBase(int newBase){
	base = newBase;
}
int Iso::getSideOne()const{
	return sideOne;
}
void Iso::perimInfo() const{
	cout<<endl<<"Perimeter: "<<getPerim()<<endl;
	cout<<"Area: "<<getArea(base)<<endl;
} 
int Iso::getPerim() const{
	return ((2*sideOne)+base);
}