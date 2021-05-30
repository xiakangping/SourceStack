var numb = 1;
while (numb < 10) {
    setTimeout(function () {
        console.log("第" + numb + "周，源栈同学" + Math.floor(Math.random() * 100));
        console.log(new Date());
        numb += 1;
    },
        1000
    );
};