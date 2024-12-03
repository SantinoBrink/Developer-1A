void setup(){
size(500,500);
background(255);
}

void draw(){
Shell(300,300,250,10);
}

void Shell(int x,int y,int G,int ringen){
  for(int i = 0; i < ringen;i++)
  {ellipse(x - G/2,y,G,G);
  G -=20;
  }
}
