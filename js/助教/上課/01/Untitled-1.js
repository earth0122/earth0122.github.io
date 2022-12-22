var foo ="Foo" /*單引號 雙引號都可以 頭尾一樣就好*/
 
let bar ='Bar'
const PI= 3.14

//primitive實質
let myNumber = 123
let myString = "build school"
let myBoolean = false
let myNull= null
let myUndefined = undefined

//object 參考
let myArr = ["build","school"]
let myObject ={
    name : "cALVIN",
    age:24
}

console.log(typeof myString)

console.log(Array.isArray(myArr))
//myArr[0]取陣列內地0比
//myArr.length取長度

//myObject.name 取道 name 屬性的 value
//myObject["name"]取道 name 屬性的 value
console.log(
    myArr.length
)
console.log(
    myObject["name"]
)
//or
console.log(
    myObject.name
)

//對 myObject 新增height 屬性 value 為174
myObject.height = 174

//對 myObject 新增weight 屬性 value 為60
myObject["weight"] = 60

console.log(
    myObject
)

let condition = true
console.log(condition)? "condition is true" : "condition is false"
if (condition == true) 
{
    console.log(`condition is ${condition}`)    
}
 else{
    //console.log(`condition is ${condition}`)
    console.log(`condition is ` + condition)
}
let arr = ['build', 'school']
for (let index = 0; index < arr.length; index++)
 {
    const element = arr[index];    
    console.log(element)
}
let index=0
while (index<arr.length)
{   
console.log( arr[index] )
index++    
}

//arr.forEach((el, idx , tmpArr)=>{}
arr.forEach((el)=>
{ 
    console.log(el)    
    // console.log(idx)
    // console.log(tmpArr)
})


function LogHelloWorld(str,foo){
    console.log(str)
    console.log(foo)
}
LogHelloWorld('hello buildschool',123)

function add(x,y)
 {
    return x + y
}

let tmp = add(1,2)
console.log(tmp)



    

    
