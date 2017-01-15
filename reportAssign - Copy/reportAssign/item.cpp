#include "item.h"
#include <iostream>
#include <string>
#include <vector>
using namespace std;

Item::Item(){
}
Item::Item(string num, string name, string quant, string whl, string retlPrice, string date){
	pNum = num;
	pName = name;
	qty = quant;
	whlPrice = whl;
	retPrice = retlPrice;
	dateAdd = date;
}
Item::~Item(){
}

string Item::getNum() const{
	return pNum;
}
string Item::getName() const{
	return pName;
} 
string Item::getQty() const{
	return qty;
} 
string Item::getWhlPrice() const{
	return whlPrice;
}
string Item::getRetPrice() const{
	return retPrice;
}
string Item::getDate() const{
	return dateAdd;
}

void Item::setNum(string newNum){
	pNum = newNum;
}
void Item::setName(string newName){
	pName = newName;
} 
void Item::setQty(string newQty){
	qty = newQty;
} 
void Item::setWhlPrice(string newWhl){
	whlPrice = newWhl;
}
void Item::setRetPrice(string newRet){
	retPrice = newRet;
}
void Item::setDate(string date){
	dateAdd = date;
}
/*
void Item::findElems(vector<Item>& inv, string input){
	string num = "";
	string name = ""; 
	string quantity = ""; 
	string whole = ""; 
	string retail = ""; 
	string date = ""; 
	for(unsigned i=0; i<input.length(); i++){
		while(input[i]!='#' || num==""){
			num+=input[i];
			i++;
		}
		if(input[i]=='#'){
			i++;
		}
		while(input[i]!='#' || name==""){
			name+=input[i];
			i++;
		}
		if(input[i]=='#'){
			i++;
		}
		while(input[i]!='#' || quantity==""){
			quantity+=input[i];
			i++;
		}
		if(input[i]=='#'){
			i++;
		}
		while(input[i]!='#' || whole==""){
			whole+=input[i];
			i++;
		}
		if(input[i]=='#'){
			i++;
		}
		while(input[i]!='#' || retail==""){
			retail+=input[i];
			i++;
		}
		if(input[i]=='#'){
			i++;
		}
		while(input[i]!='#' || date==""){
			date+=input[i];
			if((i+1) <= input.length()){
				i++;
			}
			if(i==input.length()){
				break;
			}
		}
	}
	Item item(num, name, quantity, whole, retail, date);
	inv.push_back(item);
}
*/