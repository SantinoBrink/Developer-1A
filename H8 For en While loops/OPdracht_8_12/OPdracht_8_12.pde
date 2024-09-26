size(250,250);
background(255,255,255);

int xWaarde = 20;
int yWaarde = 20;

// kleur = wit 
// x = 20
// y = 60
// i = 0
// j = 2
// rect1 tekenen (20,20,20,20) - wit
// rect2 tekenen (20,40,20,20) - zwart

// loops om 10 keer een vierkanttje te maken in de Y as
for(int i = 0; i < 8; i++){
  
  //loops 10 keer om een vierkantje te maken in de X as
  for(int j = 0; j < 8; j++){
        //als het even is zal het de vierkantje zwart maken
        if((i+j) % 2 == 0){
              fill(0);}
        //als het oneven is zal het een witte vierkantje maken
        else{
              fill(255);}
        rect(xWaarde, yWaarde, 20,20);
        yWaarde = yWaarde + 20;
}
yWaarde = 20;
xWaarde = xWaarde + 20;
}
