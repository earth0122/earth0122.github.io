let promise1 = new Promise((resolve, reject) => {
  console.log("Promise初始化");
  resolve();
});
promise1
  .then(() => {
    console.log("這是第⼀個then區段");
    throw new Error("Fail");
  })
  .catch(() => {
    console.log("這是第⼀個catch區段");
  })
  .then(() => {
    console.log("這是第⼆個then區段");
  });
