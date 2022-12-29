var person = {
    name: "Kevin",
    age: 32,
    height: 175,
    weight: 64,
    bmi: function(){
        //object literal語法需要用this才能存取到本身屬性
        return this.weight/((this.height/100)**2);
    }
}
console.log(person);
console.log(person.bmi());

console.log("The Object is " + person );
console.log("This Object is %o" , person);


let keys = Object.keys(person);
let values = Object.values(person);

// console.log(typeof keys);
// console.log(typeof values);

// console.log(Array.isArray(keys));
// console.log(Array.isArray(values));

let keysArray = Object.keys(person);
let valuesArray = Object.values(person);

keysArray .forEach(function(key, index){
    console.log(person[key]);
})