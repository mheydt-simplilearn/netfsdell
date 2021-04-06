// "counter" is a function that returns an object with properties, which in this case are functions.
var counter = (function () {
    var i = 0;

    return {
        get: function () {
            return i;
        },
        set: function (val) {
            i = val;
        },
        increment: function () {
            return ++i;
        }
    };
})();
console.log(counter.i);
console.log(counter);

// These calls access the function properties returned by "counter".
counter.get();       // 0
counter.set(3);
counter.increment(); // 4
counter.increment(); // 5