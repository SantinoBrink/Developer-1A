/*const word = ["h","e","l","p","y"];
let lettterguessed = prompt("Raad het word");
let optellen = 0;
let correct = false;
let gevonden = ["#","#","#","#","#"];

while(gevonden != word){
for ( const letter of word){
    console.log(letter)
    if (letter == lettterguessed){
        alert("de letter is derin");
        //change letter colour to color: black;
    }
    if(letter >= 5 && optellen == letter){correct = false; optellen = 0}
    if(letter >= 5 && optellen != letter){correct = true; optellen = 0}
    if(letter >= 5){letter = 0; optellen = 0;}
    else{optellen++; console.log(optellen)}
}

if(optellen >= 5 && correct == false){
    alert("geen overeen komst");optellen = 0 ; lettterguessed = prompt("probeer nog eens")
}
if(optellen >= 5 && correct == true){
    lettterguessed = prompt("nog een gokje doen?"); optellen = 0;
}
}
// zag dta een klasgenoot voor deze opdracht getelement heeft gebruikt en dat werkte goed zo mogelijk ook van belang voor mij //