var x = 1; //global
let y = 2; //global
const z = 3; //global
{
  var x = "JavaScript"; //No block scope, global
  let y = "CSS"; //block scope, local
  const z = "HTML"; //block scope, local
  console.log(x);
  console.log(y);
  console.log(z);
  console.log(".".repeat(60));
}
console.log(x);
console.log(y);
console.log(z);
