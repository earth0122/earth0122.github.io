let Cars = ["BMW","Benz","Audi","Lexus"];

Cars.forEach(function(item, index){
    console.log(index, item, typeof item)
})


//或用Arrow Function
Cars.forEach((item, index) =>{
    console.log(index, item, typeof item)
})