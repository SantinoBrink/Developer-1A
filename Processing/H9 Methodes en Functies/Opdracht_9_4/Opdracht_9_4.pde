

void setup(){
  size(500,500);
newVierkant(20,20,250,200);
}

void draw(){

}

void newVierkant(int X,int Y,int W,int H){
line(X,Y,X+W,Y);
line(X,Y+H,X+W,Y+H);
line(X,Y,X,Y+H);
line(X+W,Y,X+W,Y+H);
}
