class BankAccount{
String naam;
int rekeningnummer;
float saldo;

  BankAccount(String naam,int rekeningnummer,float saldo){
   this.naam = naam;
   this.rekeningnummer = rekeningnummer;
   this.saldo = saldo;
   }
  
  void display(){
  println("De rekening:0"+rekeningnummer+" van "+naam+" heeft een saldo van "+saldo);
  }
}

void setup(){
BankAccount jan = new BankAccount("Jan",239012344,1202.50);
jan.display();
}
