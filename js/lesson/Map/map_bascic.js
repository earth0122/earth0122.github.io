var Cars = ["BMW", "Benz", "Audi", "Lexus"];
var Prices = [280, 320, 250, 210];
// map()⽅法是對每⼀個陣列元素作運算，並將結果回傳⾄新陣列
var PricesWithTax = Prices.map((p) => p * 1.05);
console.log(PricesWithTax);
