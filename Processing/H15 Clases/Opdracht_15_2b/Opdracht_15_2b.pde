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
      println(naam+" is "+leeftijd+" oud en is een "+geslacht);
    }
}

void setup(){
  Person Jente = new Person("Jente","18","vrouw");
  Person Ahmet = new Person("Ahmet","20","goede vriend");
  Jente.display();
  Ahmet.display();
}
