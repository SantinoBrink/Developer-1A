int Tafel = 9;
int Antwoord;
int Ywaarde = 30;
size(300,350);
background(255);
fill(0);
textSize(20);

for(int i = 0;i < 11; i++){
  Antwoord = Tafel*i;
  String Som = i+" x "+Tafel+" = "+Antwoord;
  text(Som, 10,Ywaarde);
  Ywaarde +=20;
}
