var x = 1; //global
let y = 2; //global
const z = 3; //global
function Calc() {
  var x = "JavaScript"; //block scope, local
  let y = "CSS"; //block scope, local
  const z = "HTML"; //block scope, local
  console.log(x);
  console.log(y);
  console.log(z);
  console.log(".".repeat(60));
}
Calc();
console.log(x);
console.log(y);
console.log(z);
