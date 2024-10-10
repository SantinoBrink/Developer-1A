class Person{
String naam;
String leeftijd;
String geslacht;

  Person(String naam,String leeftijd,String geslacht){
  this.naam = naam;
  this.leeftijd = leeftijd;
  this.geslacht = geslacht;
  }
  
    void display(){
      textSize(20);
      fill(0);
      text(naam+" is "+leeftijd+" oud en is een "+geslacht,5,50);
    }
}

void setup(){
  size(300,300);
  background(255);
  Person Jente = new Person("Jente","18","vrouw");
  Jente.display();
}
