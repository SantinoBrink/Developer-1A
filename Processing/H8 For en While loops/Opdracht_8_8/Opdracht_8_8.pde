int nummerNieuw = 1;
int nummerOud = 0;
int resultaat;



for(int i=0; i <10; i++){
resultaat = nummerOud + nummerNieuw;

println(resultaat);

nummerOud = nummerNieuw;
nummerNieuw = resultaat;
}
