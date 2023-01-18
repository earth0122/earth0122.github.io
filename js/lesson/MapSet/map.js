//宣告陳列
var taiwanArray = ["台灣", 41, 1, 12];
var chinaArray = ["中國", 80134, 2914, 44595];
var americaArray = ["美國", 9665, 146, 694];
var map = new Map(); //初始化Map物件
//Ex1 - 加入key-value pairs資料到Map物件
map.set("taiwan", taiwanArray);
map.set("china", chinaArray);
map.set("america", americaArray);

console.log(map);

let taiwan = map.get("taiwan");
console.log(taiwan);
console.log(Array.isArray(taiwan));
