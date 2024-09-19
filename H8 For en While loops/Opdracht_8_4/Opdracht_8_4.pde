size(700,700);
background(255,255,255);

int x = 20;
int y = 20;

for(int i = 0; i < 2; i++){
  for(int j = 0; j < 5; j++){
    rect(x, y, 40,40);
  y = y + 40;
}
y = 20;
x = x + 40;
}
