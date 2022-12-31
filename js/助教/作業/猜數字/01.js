1; //取得DOM元素和需要用到的變數
//抓到DOM input-num
let inputNum = document.querySelector("#input-num");
console.log(inputNum);
//抓到DOM btn-num
let allBtn = document.querySelectorAll(".btn-num");
console.log(allBtn);
//抓到DOM btn-reset
let resetBtn = document.querySelector(".btn-reset");
console.log(resetBtn);
//抓到DOM btn-answer
let answerBtn = document.querySelector(".btn-answer");
console.log(answerBtn);
//抓到DOM btn-guess
let guessBtn = document.querySelector(".btn-guess");
console.log(guessBtn);
//抓到DOM btn-start
let startBtn = document.querySelector(".btn-start");
//輸入數字變數
let inputNumValue;
//猜的數字
let guessNum;
//按鈕輸入的數字 存進inputNum
allBtn.forEach((item) => {
  item.addEventListener("click", function () {
    inputNum.value += item.innerHTML;
  });
});
//重新開始遊戲
// resetBtn.addEventListener("click", function () {
//   inputNum.value("");
// });

//鎖住按鈕

//猜數字

//1.產生一組4位數 而且不重複的數字

//2.將輸入的數字判斷是否正確&位置是否正確

//
