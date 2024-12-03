int Bedragen[] = {5,9,4,1,5,6,5,4,9,8,1,5};
int teller = 0;
void setup(){
Herhalingteller(5);
}

void Herhalingteller(int N1){
  for(int i = 0;i < Bedragen.length;i++){
    if(Bedragen[i] == N1){
      teller++;
    }
  }
  println(teller);
}
