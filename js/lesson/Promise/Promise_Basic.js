const promise1 = new Promise(function (resolve, reject) {
  setTimeout(() => {
    //.....
    //.....
    // .....
    // resolve("程式執行成功!");
    // resolve(["Kevin","Mary","John"])
    resolve({ name: "Kevin", email: "kevun@gmail.com" });
    // reject("使用未宣告變數!")
  }, 3000);
});
promise1
  .then((result) => {
    console.log(result);
  })
  .catch((ex) => {
    console.log("失敗的原因" + ex);
  })
  .finally(() => {
    console.log("Promise Finally完成!");
  });
