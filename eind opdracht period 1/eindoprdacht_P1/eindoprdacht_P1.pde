
String input = "";
//String teskt[] = new String[3];
String TesktIN[] = {"Welkom tot [stad naam], een plek van waar dromen uit komen en waar helden komen om te trainen.", "Termiste dat is wat je heb gehoord. jij komt hier van een dorpje Noord van de stad, jij komt hier om een avonturier te worden."
  , "Zodra je ben  waar ga je eerst toe? de winkel, de stambeeld of ga je meteen naar de guild voor intescrijven?"};
String TesktA1[] = {"A1"};
String TesktB1[] = {"B1"};
String TesktC1[] = {"C1"};
String Teskt[] = TesktIN;
int zin = 0;
int yT = 20;
void setup() {
  size(1000, 800);
  background(50);
  fill(255);
  textSize(18);
  frameRate = 1;
}

void draw() {
  background(50);
  //text("how did i come here?",20,20);
  text(Teskt[zin], 20, yT);
  //println(input);
  //overgang(input);
  if (zin == (TesktIN.length-1)) {
    text("> " + input, 50, yT+30);
  }
}
void mouseClicked() {
  if (zin < (TesktIN.length-1)) {
    zin++;
    yT +=30;
  }
}

void keyPressed() {
  // om mijn ongelukeen te verwijderen
  if (keyCode == BACKSPACE) {
    if (input.length() > 0) {
      input = input.substring(0, input.length() - 1);
    }
  } else {
    // om je toets visual te maken(maar werkt niet voor input??)
    input += key;
    overgang(input);
  }
  
}

void overgang(String check) {
  println(check);
  switch(check){
  case "stambeeld": Teskt = TesktA1; zin = 0; yT = 20; ;break;
  case "winkel": Teskt = TesktB1; zin = 0; yT = 20; ;break;
  case "guild":Teskt = TesktC1; zin = 0; yT = 20; ;break;
  /*case "guild":Teskt = TesktC1; zin = 0; yT = 20; ;break;
  case "guild":Teskt = TesktC1; zin = 0; yT = 20; ;break;
  case "guild":Teskt = TesktC1; zin = 0; yT = 20; ;break;*/
  default:println("sorry, what?");break;
  }
}
