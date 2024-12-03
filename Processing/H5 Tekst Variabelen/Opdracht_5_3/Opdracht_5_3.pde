float gewicht = 134;
float lengtecm = 172;
float lengteM = lengtecm/100;
int BMI = Math.round(gewicht/(lengteM*lengteM));
String zin1 = "Met een gewicht van ";
String zin2 = " kg en een lengte van ";
String zin3 = " cm, is jouw BMI ";

println(zin1+gewicht+zin2+lengtecm+zin3+BMI);
