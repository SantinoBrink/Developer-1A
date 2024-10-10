String[] tekst = {"H", "o", "i", " ", "i", "k", " ", "b", "e", "n", " ", "P", "i", "e", "t", "."};
void setup() {
  //print(tekst);
  Woordzoeker("i", "k");
}


void draw() {
}

void Woordzoeker(String l1, String l2) {
  for (int i = 0; i < 16; i++) {
    //println(tekst[i]);
    if (tekst[i] == l1) {
      i++;
      if (tekst[i] == l2) {
        println(l1+l2+" is gevonden");
          break;
        }
      }
    }
  }
