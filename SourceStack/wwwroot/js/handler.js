//////回调函数handler能对number进行运算，并返回bool值的，比如has6()
////function has6(number) {
////    var age = 6;
////    if (number(age) == true) {
////        console.log(true);
////    } else {
////        console.log(false);
////    }
////}

////has6(handler);

////function handler(age) {
////    return age > 5;
////}

function handler(number) {
    var age = 25;
    if (number(age) == true) {
        console.log(true);
    } else {
        console.log(false);
    }
}
handler(function (age) {
    return age > 60;
});