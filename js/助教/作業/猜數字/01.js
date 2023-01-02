//#region
//亂數產生(洗牌方式)
//把陣列中的最後一個元素 和陣列中隨機一個位置互換 然後再把倒數第二個隨機互換(位置有可能選到自己的位置)
let shuffle = function () {
  let arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
  let length = arr.length;
  let lastIndex = length - 1;
  for (let i = 0; i < lastIndex; i++) {
    let random = Math.floor(Math.random() * (lastIndex - i + 1)) + i;
    // console.log(i, random);
    let temp = arr[random];
    arr[random] = arr[i];
    arr[i] = temp;
    // console.log(arr);
  }
  //因為取4位數 所以把索引4以後的都刪除
  arr.splice(4);
  // console.log(arr);
  //把陣列轉為字串
  let arrString = arr.toString();
  // console.log(arrString);
  //把,號拿掉
  let arrSTring = arrString.replace(/,/g, "");
  // console.log(arrSTring);
  // let arrNum = parseInt(arrSTring);
  // console.log(arrNum);
  // console.log(typeof arrNum);

  return arrSTring;
};
//#endregion
//#region
//取得DOM元素和需要用到的變數
let inputNum = document.querySelector("#input-num");
// console.log(inputNum);
// let allBtn = document.querySelectorAll(".btn-num");
// console.log(allBtn);
let resetBtn = document.querySelector(".btn-reset");
// console.log(resetBtn);
let answerBtn = document.querySelector(".btn-answer");
// console.log(answerBtn);
let guessBtn = document.querySelector(".btn-guess");
// console.log(guessBtn);
let startBtn = document.querySelector(".btn-start");
// console.log(startBtn);
let showResult = document.querySelector(".show-result");
let inputNumValue = inputNum.value;
//猜的數字
let guessNum = inputNum.value;
//猜數字的答案
let answer = shuffle();
//A
let A = 0;
//B
let B = 0;
//#endregion
//#region
/*事件*/
//案答案按鈕要彈出答案
answerBtn.addEventListener("click", function () {
  alert(answer);
});
//按鈕輸入的數字 存進inputNum
// allBtn.forEach((item) => {
//   item.addEventListener("click", function () {
//     inputNum.value += item.innerHTML;
//   });
// });
//案開始
startBtn.addEventListener("click", function () {
  answerBtn.disabled = false;
  guessBtn.disabled = false;
  resetBtn.disabled = false;
});
//案猜TODO:
guessBtn.addEventListener("click", function () {
  //判斷輸入的值是不是數字
  guessNum = parseInt(inputNum.value, 10);
  if (isNaN(guessNum)) {
    alert("請輸入數字");
    inputNum.value = "";
  } else if (guessNum.length < 4 || guessNum.length > 4) {
    alert("請輸入4個數字");
    inputNum.value = "";
  } else if (checkRepeat != 4) {
    alert("請輸入四個不一樣的數字");
    input.value = "";
  } else if (guessNum === answer) {
    alert("恭喜猜對");
    inputNum.value = "";
  }
});
//重新開始遊戲
resetBtn.addEventListener("click", function () {
  answer = shuffle();
  answerBtn.disabled = true;
  guessBtn.disabled = true;
  resetBtn.disabled = true;
  inputNum.value = "";
  showResult.innerHTML = "";

  // allBtn.disabled = true;
});
//#endregion

//鎖住按鈕
window.onload = function () {
  // allBtn.disabled = true;
  answerBtn.disabled = true;
  guessBtn.disabled = true;
  resetBtn.disabled = true;
};

//猜數字
//1.產生亂數(最上面)
//2.將輸入的數字和答案去做對比 如果數字有一樣去判對位置一不一樣 一樣的話(A)位置不一樣的話(B)
