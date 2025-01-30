//de gebruiker mag proberen om het 'te raden' getal te raden.
//Het te raden getal mag gewoon een vast getal zijn dat in de code staat (hardcoded)

//Een regel code is gegeven, hoe nu verder?
alert("Hallo");
let numberGuessed = prompt("Raad het getal (1 tot en met 10)");
const denummer = 6;
let something;
while(numberGuessed != denummer){if(numberGuessed == denummer){alert("goed gedaan!")};
if(numberGuessed < denummer){console.log("beetje te laag")};
if(numberGuessed > denummer){console.log("beetje te hoog")};
console.log(numberGuessed);
numberGuessed = prompt("Raad het getal (1 tot en met 10)");
};