let friends = []

let person1 = {
    id : 1,
    name :"Kevin",
    email : "Kevin@gmail.com"
}

let person2 = {
    id : 2,
    name :"David",
    email : "David@gmail.com"
}


friends.push(person1);
friends.push(person2);

console.log(friends)


friends.forEach(function(item, index){
    console.log(`${index}. 姓名:${item.name}, 電郵:${item.email}`)
})
console.log("-----------")
friends.forEach(function(person, index){
    console.log(`${index}. 姓名:${person.name}, 電郵:${person.email}`)
})
