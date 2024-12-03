class Rectangle{
float x;
float y;
float size;

  //poging om een Constructor te maken
  Rectangle(float x,float y, float size){
  this.x = x;
  this.y = y;
  this.size = size;
  }
  void display() {
  rect(x,y,size,size/2);
  }
}

void setup(){
size(300,300);
Rectangle mijnVierkant = new Rectangle(20,20,200);
mijnVierkant.display();
}
