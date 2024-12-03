
String input = "";
//String teskt[] = new String[3];
String TesktIN[] = {"Welkom tot [stad naam], een plek van waar dromen uit komen en waar helden komen om te trainen.", "Termiste dat is wat je heb gehoord. jij komt hier van een dorpje Noord van de stad, jij komt hier om een avonturier te worden."
  , "Zodra je ben  waar ga je eerst toe? de winkel, de stambeeld of ga je meteen naar de guild voor intescrijven?"};
String TesktA1[] = {"je besluit om naar de stambeeld tegaan","bij de stambeeld vindt een kat zitten op de rand, je kan niet weerstaan om niet deze kat te aaien","jammer dat toen je naar de kat toe liep dat die weg sprong en verdwijn intot de gemeentigte, benieuwd waar die naar toe ging volg je hem.","je volg de kat en eindig in een steegje waar je hem verliest. zodra je rond kijk merk je dat een paar mensen je nadert.","je staat klaar om over vallen te worden maar ze kijken naar je en zijn 'wat doe jij hier? je weet dat het gevaarlijk is om alleen in een steegje te gaan'.","toon je vertelde over de kat dat je zag werden ze benieuwd maar ze zagen der uit dat ze een andere antwoord verwachte dan dat jij de kat wou aaien."," na dat merk je dat het al donker wordt, best naar de guild kan gaan vordat het donker wordt of voordat mensen denken dat je gek ben."};
String TesktB1[] = {"toen je de stad in kwam merkte je een winkel die handige leek te verkopen.","waneer je voor de deur sta waait de deur plots open en stormt een person uit en bost intot jouw.","voordat je de person kon aanspreken zegt de persoon: 'sorry, heb geen tijd. moet gaan!' en rent weg.... dat was iets...","WAS DAT EEN DIEF?!","je ga naar binnen en kijk rond, je zie een paar dingen dat van belang kan zijn maar ze zijn wel prijzig je besluit dat je een goedkope zwaard zal halen","of zal sparen voor een betere en je eerste missie on bewapend doen?"};
String TesktC1[] = {"je besluit dat het best is om je te registeren, zo je ga naar de guild toe","je kom aan op bij een groot gebouw wat erg net uit zie vergeleken met de rest van de gebouwen. dit moet vast de plak zijn","zodraje naar binnen ga wordt je bijna overweld door de zicht van zo veel avondtuurieren en jagers","niet te zenuwachtig worden je wist dat dit een druke plek zou zijn en idereen zijn toch alleen met elkaar bezig","'Hoi is dit waar ik moet registeren voor een avonturier te worden?' de receptionist draait om om je te groeten 'Mijn exuses had je niet gezien. je zei dat je kom om een avondturier te worden.'","ze blader door haar boek, vast opzoek naar de prosudure 'ah hier- voordat je kan registeren moet je eerste een van de beginer level opdrachten doen. en word daar door gezien wat beste bij je past.'","'was bijna vergeten tevragen, wat is je naam?'","'Will. kan ik zelf kiezen of wordt ik een toegewezen?'","'toegewezen, het moet een opdracht zijn dat je vaardigheden test maar je niet in direct gevaar zet''","de receptionist neemt je naar de bord waar all de verzoeken zijn opgehangen en na een tijdje van kijken en checken als een verdoet aan al de benodigde eisen voor de test","krijgt je een aangegeven om te doen.'dit hoord goed te zijn voor je test. je zal voor kruiden zoeken voor de chemist in de bos vlakbij,"," je zal waarzijnlijk geen gevaarlijke dieren of monster tegen komen, maar we kunnen een gevechtsevaluatie doen zodra je terug ben, ben je er klaar voor?'"};
String TesktA2[] = {"je besluit om naar de bos tegaan","je vindt de ingrienten voor je spuertocht","een beest valt aan","je heb geen wapen zo je probeer je tebeshermen met een tak","dit faald en je gaat dood"};
String TesktB2[] = {"je gaat de stad in","niet zal je toch naar de winkel toe of de stambeeld bezoeken?"};
String TesktC2[] = {"je kijkt om je heen. vaak zullen avonduurieren groepen vormen waarin ze samenwerken","je kijkt rond, michien is der wel iemand hier dat je van kan leren of samen mee kan wekren","je hoor een groep praten over hun laatse missie","tot plots iemand begin tegen je begint tepraten 'Hoi, ben je ook nieuw?'","'ja, maar ik moet nog een opdracht doen voordat ik oficeel een avondturier kan noemen.'vertel ik 'ik ook ik moest de bos in om naar planten te zoeken'zegd de andere","'ik ook!'zeg ik verbaasd 'oh waarom zullen we niet samen dan de missie doen' vroeg ze 'en op andere tijden terug komen zodat ze denken dat we onze opdrachten aprart heb gedaan en vermoedelijk een betere beoordeling krijgen.'zie ik","En zo heb jij je eerste vriend gemaakt hier"};
String TesktD2[] = {"The predator cant differ the prey from the allies"};
String Fear[] = {"je merk nu pas op hoeveel mensen hier zijn","wat als een van hen door heeft wat jij ben","wat als je rechtsteeds in een valt ben gelopen om jouw te doden!","zo veel avondtuurieren bevinden zich hier meest van hen zou zonder twijfel je inleveren voor een belonning","was dit een slecht idee?! telaat nu!"};
String Transform[] = {"Nee! ik moet me vorm behouden, ik kan het niet reskieren om nu ontdekt teworden","je begint zeenuwactige teworden en je voel dat je vleugels beginen tevormen van je midriff","je probeer je best om te calmeren maar elk moment kan je veugels zichbaar te worden en zal je mogelijk ontdekt worden","plots hoor je een geadem het klink alsof iemand erg zwaar is aan het ademen"," je loop naar de geluid toe 'hallo is daar iemand' 'help me, ik zit vast' zegd de stem uit een grote houte boos","je zie een plank dat der uit ziet alsof het kan gebruiken om de krat op te tillen","he lukt je om het krat opte tillen maar je stopt toen je weer dacht aan je veugels maar het ziet deruit dat door de afleiding je calmeert genoeg werdt dat je veugels weer onopmerktbaar werden"};
String TesktYkoop[] = {"je koop de zwaard, beter iets hebben dan niets"};
String TestNkoop[] = {"je besluit om niet de zwaard te halen, je ben toch niet van plan om te starten met een jaagt"};
Boolean Zwaard = false;
boolean vrienden = false;
String Teskt[] = TesktIN;
int zin = 0;
int yT = 20;
void setup() {
  size(1500, 800);
  background(50);
  fill(255);
  textSize(18);
  frameRate = 1;
  stroke(50);
}

void draw() {
  //background(50);
 while (zin <= (Teskt.length-1)) {text(Teskt[zin],20,yT); zin++; yT+=30;}
 
  if (zin == (Teskt.length)) {
    text("> " + input, 50, yT+30);
  }
}
/*void mouseClicked() {
  if (zin < (Teskt.length-1)) {
    zin++;
    yT +=30;
  }
}*/

void keyPressed() {
  // om mijn ongelukeen te verwijderen
  if (keyCode == BACKSPACE) {
    if (input.length() > 0) {
      input = input.substring(0, input.length() - 1);
      fill(50); rect(50, yT+10, 900, 100);
      fill(255);
    }
  } else {
    // om je toets visual te maken en om de overgnag te maken(dit zorg ook dat het maar een keer check per toets)
    fill(50);
    rect(50, yT+10, 900, 100);
    fill(255);
    input += key;
    overgang(input);
  }
  
}

void overgang(String check) {
  println(check);
  switch(check){
  case "stambeeld": Teskt = TesktA1; zin = 0; input = ""; yT = 20; background(50) ;break;
  case "winkel": Teskt = TesktB1; zin = 0; yT = 20; input = "";background(50) ;break;
  case "guild":Teskt = TesktC1; zin = 0; yT = 20; input = "";background(50) ;break;
  case "debos":Teskt = TesktA2; zin = 0; yT = 20; input = ""; background(50);break;
  case "stadin":Teskt = TesktB2; zin = 0; input = ""; yT = 20;background(50) ;break;
  case "praten":Teskt = TesktC2; zin = 0; input = ""; yT = 20; background(50); vrienden = true; break;
  case "goedkoop":Teskt = TesktYkoop; zin = 0; input = ""; yT = 20; background(50);break;
  case "geenkoop":Teskt = TestNkoop; zin = 0; input = ""; yT = 20; background(50);break;
  case "fear":Teskt = Fear; zin = 0; input = "D"; yT = 20; background(50);break;
  case "Dragon":Teskt = Transform; zin = 0; input = ""; yT = 20; background(50);break;
  case "thehunger":Teskt = TesktD2; zin = 0; yT = 20; ;break;
  default:println("sorry, what?");break;
  }
}
