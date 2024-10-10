String Namenlijst[] = {"Mark","William","Sophia","Ashley","Steve","Jan","Jaap"};
void setup(){
  naamChecker("Jan");
}

void draw(){
  
}

void naamChecker(String naam){
for(int i = 0;i < Namenlijst.length;i++){
  if(Namenlijst[i] == naam){
    println("dat naam staat op de lijst");
    }
    break;
  }
}
