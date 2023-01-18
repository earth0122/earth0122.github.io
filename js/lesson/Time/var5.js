function loop1() {
  for (var i = 0; i < 3; i++) {
    console.log(i);
  }
  console.log(i);
}
function loop2() {
  for (let i = 0; i < 3; i++) {
    console.log(i);
  }
  console.log(i);
}
loop1();
loop2();
