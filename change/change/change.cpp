#include "change.h"

change::change(){
	changeAmt = 0.0;
}
change::change(double change){
	changeAmt = change;
}
int change::clacQuaters(){
	double quater = (changeAmt-dollars);
	int quat = 0;
	for(int i=0; i<3; i++){
		if((quater/0.25)>=1){
			quat++;
		}
		quater=quater-0.25;
		if(quat==0){
			i=4;
		}
	}
	change::quaters=quat;
	return quat;
}
int change::calcDollars(){
	int dollar = 0;
	while((int(changeAmt)%1)==0){
		dollar++;
		if(int(dollar) == int(changeAmt)){
			break;
		}
	}
	change::dollars = dollar;
	return dollar;
}
int change::calcDimes(){
	double dime = changeAmt-(dollars+quaters*0.25);
	int dimeCount = 0;
	for(int i=0; i<10; i++){
		if((dime/0.10)>=1){
			dimeCount++;
		}
		dime=dime-0.10;
		if(dime==0){
			i=10;
		}
	}
	change::dimes=dimeCount;
	return dimeCount;
}
int change::calcPennies(){
	int penCount = 0;
	double penn = changeAmt-((dollars+quaters*0.25)+(0.10*dimes)+0.05*nick);
	for(int i=0; i<100; i++){
		if((penn/0.009)>=1){
			penCount++;
		}
		penn=penn-0.01;
		if(penn==0.0){
			i=100;
		}
	}
	change::pennies=penCount;
	return penCount;
}
int change::calcNick(){
	int nicCount = 0;
	double nic = changeAmt-((dollars+quaters*0.25)+(0.10*dimes));
	for(int i=0; i<20; i++){
		if((nic/0.049)>=1){
			nicCount++;
		}
		nic=nic-0.05;
		if(nic==0){
			i=20;
		}
	}
	change::nick=nicCount;
	return nicCount;
}

change::~change(){
}
int change::getDollar() const{
	return dollars;
}
int change::getDime() const{
	return change::dimes;
}
int change::getPennies() const{
	return change::pennies;
}
int change::getNick() const{
	return change::nick;
}
int change::getQuaters() const{
	return change::quaters;
}