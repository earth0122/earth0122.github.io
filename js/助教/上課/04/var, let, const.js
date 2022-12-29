// var, let, const
// 作用域不同
// 資料可不可以改
// 長不太一樣

// 懶人包: const > let > var
// 嚴謹程度: let, const >>>> var

// hosting & function scope
var foo = "Foo";
function Bar() {
  var foo; // hosting
  console.log(foo); // A: 'Foo', B: 'Foo2', C: undefined
  if (true) {
    var foo = "Foo2";
  }
}

Bar();

for (var i = 0; i < 4; i++) {
  // block scope
  // console.log(i)
}

console.log(i); // A: 4, B: undefined, C: 5

// block scope: {  }, if , for, while
// function scope: function () {}

{
  //block scope
  let bar = "Bar";
}
// console.log(bar) // A: true, B: false

// ES6 -> ECMAScript 2015
// var <- ES6 -> let, const

// 作用域: global -> function scope -> block scope
// var function scope
// let const block scope

// hosting (宣告)提升
// var, let ,const , function 提升
// let, const: TDZ(暫時性死區)

// var a
console.log(a);
var a = "213";

console.log(add());
function add() {
  return 1 + 2;
}

console.log(b);
// TDZ
let b = "123";
