var pics= new Array("pics/dogecoin.png","pics/dogecoin1.png","pics/dogecoin2.png","pics/dogecoin3.png","pics/dogecoin4.png","pics/dogecoin5.png");

var row1=0;
var row2=0;
var row3=0;

var counter=0;

var coin1x1=document.getElementById('coin1X1');
var coin2x1=document.getElementById('coin2X1');
var coin3x1=document.getElementById('coin3X1');

var coin1x2=document.getElementById('coin1X2');
var coin2x2=document.getElementById('coin2X2');
var coin3x2=document.getElementById('coin3X2');

var coin1x3=document.getElementById('coin1X3');
var coin2x3=document.getElementById('coin2X3');
var coin3x3=document.getElementById('coin3X3');

var slots = new Array(coin1x1, coin1x2, coin1x3, coin2x1, coin2x2, coin2x3, coin3x1, coin3x2, coin3x3);
var random;
var randomSlot;
function getRandomSpace(){
	random=Math.floor(Math.random()*slots.length-1-0+1)+0;
	randomSlot=slots[random];
	randomSlot.src="pics/free.png";
	freeSpaceScore();
	spinCount=0;
}

function spinCol1(){

	document.getElementById('start').disabled=true;
	document.getElementById('stop').disabled=false;
	var slot1=Math.floor(Math.random()*pics.length-1-0+1)+0;
	var slot2=Math.floor(Math.random()*pics.length-1-0+1)+0;
	var slot3=Math.floor(Math.random()*pics.length-1-0+1)+0;
	
	counter++;
	
	coin1x1.src=pics[slot1];
	coin2x1.src=pics[slot2];
	coin3x1.src=pics[slot3];
	
	if(counter==6){
		counter=0;
	}
}
function spinCol2(){

	var slot4=Math.floor(Math.random()*pics.length-1-0+1)+0;
	var slot5=Math.floor(Math.random()*pics.length-1-0+1)+0;
	var slot6=Math.floor(Math.random()*pics.length-1-0+1)+0;

	counter++;
	
	coin1x2.src=pics[slot4];
	coin2x2.src=pics[slot5];
	coin3x2.src=pics[slot6];
	
	if(counter==6){
		counter=0;
	}
}
function spinCol3(){
	var slot7=Math.floor(Math.random()*pics.length-1-0+1)+0;
	var slot8=Math.floor(Math.random()*pics.length-1-0+1)+0;
	var slot9=Math.floor(Math.random()*pics.length-1-0+1)+0;
	counter++;
	
	coin1x3.src=pics[slot7];
	coin2x3.src=pics[slot8];
	coin3x3.src=pics[slot9];
	
	if(counter==6){
		counter=0;
	}
}

function startSpin(){
row1=setInterval('spinCol1();',150);
row2=setInterval('spinCol2();',150);
row3=setInterval('spinCol3();',150);

}

var spinCount=0;
var cnt=1;
function stopSpin(){
	switch(cnt){
		case 1:
			clearInterval(row1);
			row1=0;
			cnt++;
			break;
		case 2:
			clearInterval(row2);
			row2=0;
			cnt++;
			break;
		case 3:
			clearInterval(row3);
			row3=0;
			cnt=1;
			document.getElementById('start').disabled=false;
			document.getElementById('stop').disabled=true;
			spinCount++;
			if(spinCount==4){
				getRandomSpace();
			}
			getScore();
			break;
	}
	
}

var score=0;
document.getElementById('score').value=score;

function getScore(){

	if(coin1x1.src==coin1x2.src && coin1x2.src==coin1x3.src){
		score=score+10;

	}
	if(coin2x1.src==coin2x2.src && coin2x2.src==coin2x3.src){
		score=score+10;

	}
	if(coin3x1.src==coin3x2.src && coin3x2.src==coin3x3.src){
		score=score+10;

	}
	if(coin1x3.src==coin2x2.src && coin2x2.src==coin3x1.src){
		score=score+20;

	}
	if(coin1x1.src==coin2x2.src && coin2x2.src==coin3x3.src){
		score=score+20;

	}
	else if(coin3x3.src==coin2x2.src && coin2x2.src==coin1x1.src){
		score=score+20;
	
	}
	document.getElementById('score').value=score;
	
}

function freeSpaceScore(){
		switch (randomSlot){
			case coin1x1:
				if(coin1x2.src==coin1x3.src){

					score=score+10;
				}
				if(coin2x2.src==coin3x3.src){

					score=score+20;
				}
				break;
			case coin1x2:
				if(coin1x1.src==coin1x3.src){

					score=score+10;
				}
				break;
			case coin1x3:
				if(coin1x1.src==coin1x2.src){

					score=score+10;
				}
				if(coin3x1.src==coin2x2.src){

					score=score+20;
				}
				break;
			case coin2x1:
				if(coin2x2.src==coin2x3.src){

					score=score+10;
				}
				break;
			case coin2x2:
				if(coin2x1.src==coin2x3.src){

					score=score+10;
				}
				if(coin1x3.src==coin3x1.src){

					score=score+20;
				}
				if(coin1x1.src==coin3x3.src){

					score=score+20;
				}
				break;
			case coin2x3:
				if(coin2x2.src==coin2x1.src){

					score=score+10;
				}
				break;
			case coin3x1:
				if(coin3x2.src==coin3x3.src){

					score=score+10;
				}
				if(coin1x3.src==coin2x2.src){	

					score=score+20;
				}
				break;
			case coin3x2:
				if(coin3x1.src==coin3x3.src){
	
					score=score+10;
				}
				break;
			case coin3x3:
				if(coin3x2.src==coin3x1.src){	
	
					score=score+10;
				}
				if(coin1x1.src==coin2x2.src){
			
					score=score+20;
				}
				break;
		}
		document.getElementById('score').value=score;
		
}
