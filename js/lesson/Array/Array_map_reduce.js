var Cars = ["BMW", "Benz", "Audi", "Lexus"];
var Prices = [280, 320, 250, 210];

//1.
//map()⽅法是對每⼀個陣列元素作運算，並將結果回傳⾄新陣列
// var PricesWithTax = Prices.map(p => p * 1.05);
// console.log(PricesWithTax);
let totalPrice = Prices.reduce(function (total, current) {
  return total + current * 1.05;
});

//2.    reduce 加總
let totalPrice2 = Prices.reduce((total, current) => {
  return total + current * 1.05;
});

//3.
var Prices = [280, 320, 250, 210];
const reducer = (total, current) => total + current;

console.log(Prices.reduce(reducer));

const log = console.log;

log("Hello");
