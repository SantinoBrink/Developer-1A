int x = 100;
int y = 100;
int girth = 20;
int Hspeed = 5;
int Yspeed = 2;

void setup(){
size(1000,500);
}

void draw(){
x += Hspeed;//x++;x = x + 1;
background(255);
ellipse(x,y,girth,girth);
if(x > 1000-(girth/2)){
Hspeed = -5;
fill(#8B008B);
}
if(x < girth/2){
Hspeed = 5;
fill(#FF00FF);
}
y += Yspeed;//y++;y = y + 1;
if(y > 500-(girth/2)){
Yspeed = -6;
fill(#CC00CC);
}
if(y < girth/2){
Yspeed = 10;
fill(#990F4B);
}
}
