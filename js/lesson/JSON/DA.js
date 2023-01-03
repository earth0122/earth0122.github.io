let persons = [
  {
    name: "Mary",
    age: 28,
    email: "mary@gmail.com",
  },
  {
    name: "John",
    age: 35,
    email: "john@gmail.com",
  },
];

let { name, age, email } = persons[0];

let { name: myname, age: myage, email: myemail } = persons[1];

let [Name, Age, Email] = ["Kevin", "36", "kevin@gmail.com"];

console.log(name);
console.log(age);
console.log(email);

console.log(myname);
console.log(myage);
console.log(myemail);

console.log(Name);
console.log(Age);
console.log(Email);
