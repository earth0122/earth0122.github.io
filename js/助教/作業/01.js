//1.產生亂數1~100
let answer = getAnswerNumber();
//2.輸入數字
let inputDom = document.getElementById("num-input");
//3.抓到按鈕
let btn = document.querySelector(".btn-guess");
console.log(btn);
//4.輸入數字變數
let inputNumberValue;
//5.猜的數字
let guessNumber;
//6.宣告p
let p = document.querySelector("p");

//產生1~100的隨機數字
function getAnswerNumber(min, max) {
  min = Math.ceil(1);
  max = Math.floor(100);
  return Math.floor(Math.random() * (max - min)) + min;
}
console.log(answer);

//鍵盤選擇到的按鈕 並監聽按按鈕的時候輸入的數字 並把輸入的值放入
let btnNum = document.querySelectorAll(".btn-num");
console.log(btnNum);
btnNum.forEach((item) => {
  item.addEventListener("click", function () {
    inputDom.value += item.innerHTML;
  });
});
//看答案 選到看答案的按鈕 並利用監聽的點擊事件
let getAnswer = document.querySelector(".btn-answer");
getAnswer.addEventListener("click", function () {
  answer = getAnswerNumber();
  alert(answer);
  min = 1;
  max = 100;
  p.innerText = `${min} ~ ${max}`;
  console.log(answer);
});
//監聽按按鈕
btn.addEventListener("click", function () {
  //取得輸入的值
  let inputValue = inputDom.value;
  //判斷輸入的值是不是數字
  guessNumber = parseInt(inputValue, 10);
  if (isNaN(guessNumber)) {
    alert("請輸入數字");
    inputDom.value = "";
  }
  //判斷是不是答案
  if (guessNumber === answer) {
    alert("恭喜猜對");
    inputDom.value = "";
    min = 1;
    max = 100;
    p.innerText = `${min} ~ ${max}`;
    answer = getAnswerNumber();
    inputDom.value = "";
  } else {
    //是否超過範圍
    if (guessNumber < min || guessNumber > max) {
      alert("根據範圍在輸入一次");
      inputDom.value = "";
    } else {
      //替換數字
      if (guessNumber < answer) {
        min = guessNumber;
      } else if (guessNumber > answer) {
        max = guessNumber;
      }
      //顯示範圍
      p.innerText = `${min} ~ ${max}`;
      inputDom.value = "";
    }
  }
});
//reset
let reset = document.querySelector(".btn-reset");
reset.addEventListener("click", function () {
  min = 1;
  max = 100;
  p.innerText = `${min} ~ ${max}`;
  answer = getAnswerNumber();
  inputDom.value = "";
});
