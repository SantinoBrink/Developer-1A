void setup()
{
  size(500,300);
  background(255);
}
void draw()
{
  tekenBoom(100,100,40,100);
}
void tekenBoom(int x,int y,int w,int h)
{
  fill(#964B00);
  rect(x,y,w,h);
  stroke(0,150,0);
  fill(0,200,0);
  ellipse(x+w/2,y,w*2,w*2);
}
