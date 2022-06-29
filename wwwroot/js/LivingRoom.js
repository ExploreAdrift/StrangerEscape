

// this is for the book shelf 
function openForm() {
    document.getElementById("bookName").style.display = "block";
}

function closeForm() {
    document.getElementById("bookName").style.display = "none";
}

// this is for the bulb form
function openFormBulbs() {
    document.getElementById("form-bulbs").style.display = "block";
}

function closeFormBulbs() {
    document.getElementById("form-bulbs").style.display = "none";
}

// this is for the dragable divs 

const letters = document.querySelector(".letters")

function onDrag({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters);

    // getting left and top values of letters and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters.style.left = `${left + movementX}px`
    letters.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters.addEventListener("mousedown", ()=>{
    letters.classList.add("active");
    letters.addEventListener("mousemove", onDrag)
});

document.addEventListener("mouseup", ()=>{
    letters.classList.remove("active");
    letters.removeEventListener("mousemove", onDrag)
});

const letters2 = document.querySelector(".letters2")

function onDrag2({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters2);

    // getting left and top values of letters2 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters2.style.left = `${left + movementX}px`
    letters2.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters2.addEventListener("mousedown", ()=>{
    letters2.classList.add("active2");
    letters2.addEventListener("mousemove", onDrag2)
});

document.addEventListener("mouseup", ()=>{
    letters2.classList.remove("active2");
    letters2.removeEventListener("mousemove", onDrag2)
});

const letters3 = document.querySelector(".letters3")

function onDrag3({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters3);

    // getting left and top values of letters3 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters3.style.left = `${left + movementX}px`
    letters3.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters3.addEventListener("mousedown", ()=>{
    letters3.classList.add("active3");
    letters3.addEventListener("mousemove", onDrag3)
});

document.addEventListener("mouseup", ()=>{
    letters3.classList.remove("active3");
    letters3.removeEventListener("mousemove", onDrag3)
});

const letters4 = document.querySelector(".letters4")

function onDrag4({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters4);

    // getting left and top values of letters4 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters4.style.left = `${left + movementX}px`
    letters4.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters4.addEventListener("mousedown", ()=>{
    letters4.classList.add("active4");
    letters4.addEventListener("mousemove", onDrag4)
});

document.addEventListener("mouseup", ()=>{
    letters4.classList.remove("active4");
    letters4.removeEventListener("mousemove", onDrag4)
});

const letters5 = document.querySelector(".letters5")

function onDrag5({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters5);

    // getting left and top values of letters5 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters5.style.left = `${left + movementX}px`
    letters5.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters5.addEventListener("mousedown", ()=>{
    letters5.classList.add("active5");
    letters5.addEventListener("mousemove", onDrag5)
});

document.addEventListener("mouseup", ()=>{
    letters5.classList.remove("active5");
    letters5.removeEventListener("mousemove", onDrag5)
});

const letters6 = document.querySelector(".letters6")

function onDrag6({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters6);

    // getting left and top values of letters6 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters6.style.left = `${left + movementX}px`
    letters6.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters6.addEventListener("mousedown", ()=>{
    letters6.classList.add("active6");
    letters6.addEventListener("mousemove", onDrag6)
});

document.addEventListener("mouseup", ()=>{
    letters6.classList.remove("active6");
    letters6.removeEventListener("mousemove", onDrag6)
});

const letters7 = document.querySelector(".letters7")

function onDrag7({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters7);

    // getting left and top values of letters7 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters7.style.left = `${left + movementX}px`
    letters7.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters7.addEventListener("mousedown", ()=>{
    letters7.classList.add("active7");
    letters7.addEventListener("mousemove", onDrag7)
});

document.addEventListener("mouseup", ()=>{
    letters7.classList.remove("active7");
    letters7.removeEventListener("mousemove", onDrag7)
});

const letters8 = document.querySelector(".letters8")

function onDrag8({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters8);

    // getting left and top values of letters8 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters8.style.left = `${left + movementX}px`
    letters8.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters8.addEventListener("mousedown", ()=>{
    letters8.classList.add("active8");
    letters8.addEventListener("mousemove", onDrag8)
});

document.addEventListener("mouseup", ()=>{
    letters8.classList.remove("active8");
    letters8.removeEventListener("mousemove", onDrag8)
});

const letters9 = document.querySelector(".letters9")

function onDrag9({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters9);

    // getting left and top values of letters9 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters9.style.left = `${left + movementX}px`
    letters9.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters9.addEventListener("mousedown", ()=>{
    letters9.classList.add("active9");
    letters9.addEventListener("mousemove", onDrag9)
});

document.addEventListener("mouseup", ()=>{
    letters9.classList.remove("active9");
    letters9.removeEventListener("mousemove", onDrag9)
});

const letters10 = document.querySelector(".letters10")

function onDrag10({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters10);

    // getting left and top values of letters10 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters10.style.left = `${left + movementX}px`
    letters10.style.top = `${top + movementY}px`
}

// could isolate part that is able to activate drag but changing letters
letters10.addEventListener("mousedown", ()=>{
    letters10.classList.add("active10");
    letters10.addEventListener("mousemove", onDrag10)
});

document.addEventListener("mouseup", ()=>{
    letters10.classList.remove("active10");
    letters10.removeEventListener("mousemove", onDrag10)
});

const letters11 = document.querySelector(".letters11")

function onDrag11({movementX, movementY}){
    let getStyle = window.getComputedStyle(letters11);

    // getting left and top values of letters11 and parsing string to integer or number
    let left = parseInt(getStyle.left);
    let top = parseInt(getStyle.top);

    letters11.style.left = `${left + movementX}px`
    letters11.style.top = `${top + movementY}px`
}


// could isolate part that is able to activate drag but changing letters
letters11.addEventListener("mousedown", ()=>{
    letters11.classList.add("active11");
    letters11.addEventListener("mousemove", onDrag11)
});

document.addEventListener("mouseup", ()=>{
    letters11.classList.remove("active11");
    letters11.removeEventListener("mousemove", onDrag11)
});




// these are for the lights 
const light = document.querySelector(".bulb");
const filaments = document.querySelector(".filaments");

light.addEventListener("click", function () {
    if (light.classList.contains("blue")) {
        // light.classList.toggle("green");
        light.classList.replace("blue", "green")
    } else if (light.classList.contains("green")) {
        // light.classList.toggle("red");
        light.classList.replace("green", "red")
    } else if (light.classList.contains("red")) {
        // light.classList.toggle("yellow")
        light.classList.replace("red", "yellow")
    } else if (light.classList.contains("yellow")) {
        // light.classList.toggle("blue")
        light.classList.replace("yellow", "blue")
    } else {
        light.classList.toggle("blue");
        filaments.classList.toggle("off")
        // light.classList.replace("blue", "green")
    }
})


const light2 = document.querySelector(".bulb2");

light2.addEventListener("click", function () {
    if (light2.classList.contains("blue")) {
        // light2.classList.toggle("green");
        light2.classList.replace("blue", "green")
    } else if (light2.classList.contains("green")) {
        // light2.classList.toggle("red");
        light2.classList.replace("green", "red")
    } else if (light2.classList.contains("red")) {
        // light2.classList.toggle("yellow")
        light2.classList.replace("red", "yellow")
    } else if (light2.classList.contains("yellow")) {
        // light2.classList.toggle("blue")
        light2.classList.replace("yellow", "blue")
    } else {
        light2.classList.toggle("blue");
        // light2.classList.replace("blue", "green")
    }
})

const light3 = document.querySelector(".bulb3");

light3.addEventListener("click", function () {
    if (light3.classList.contains("blue")) {
        // light3.classList.toggle("green");
        light3.classList.replace("blue", "green")
    } else if (light3.classList.contains("green")) {
        // light3.classList.toggle("red");
        light3.classList.replace("green", "red")
    } else if (light3.classList.contains("red")) {
        // light3.classList.toggle("yellow")
        light3.classList.replace("red", "yellow")
    } else if (light3.classList.contains("yellow")) {
        // light3.classList.toggle("blue")
        light3.classList.replace("yellow", "blue")
    } else {
        light3.classList.toggle("blue");
        // light3.classList.replace("blue", "green")
    }
})

const light4 = document.querySelector(".bulb4");

light4.addEventListener("click", function () {
    if (light4.classList.contains("blue")) {
        // light4.classList.toggle("green");
        light4.classList.replace("blue", "green")
    } else if (light4.classList.contains("green")) {
        // light4.classList.toggle("red");
        light4.classList.replace("green", "red")
    } else if (light4.classList.contains("red")) {
        // light4.classList.toggle("yellow")
        light4.classList.replace("red", "yellow")
    } else if (light4.classList.contains("yellow")) {
        // light4.classList.toggle("blue")
        light4.classList.replace("yellow", "blue")
    } else {
        light4.classList.toggle("blue");
        // light4.classList.replace("blue", "green")
    }
})

const light5 = document.querySelector(".bulb5");

light5.addEventListener("click", function () {
    if (light5.classList.contains("blue")) {
        // light5.classList.toggle("green");
        light5.classList.replace("blue", "green")
    } else if (light5.classList.contains("green")) {
        // light5.classList.toggle("red");
        light5.classList.replace("green", "red")
    } else if (light5.classList.contains("red")) {
        // light5.classList.toggle("yellow")
        light5.classList.replace("red", "yellow")
    } else if (light5.classList.contains("yellow")) {
        // light5.classList.toggle("blue")
        light5.classList.replace("yellow", "blue")
    } else {
        light5.classList.toggle("blue");
        // light5.classList.replace("blue", "green")
    }
})

const light6 = document.querySelector(".bulb6");

light6.addEventListener("click", function () {
    if (light6.classList.contains("blue")) {
        // light6.classList.toggle("green");
        light6.classList.replace("blue", "green")
    } else if (light6.classList.contains("green")) {
        // light6.classList.toggle("red");
        light6.classList.replace("green", "red")
    } else if (light6.classList.contains("red")) {
        // light6.classList.toggle("yellow")
        light6.classList.replace("red", "yellow")
    } else if (light6.classList.contains("yellow")) {
        // light6.classList.toggle("blue")
        light6.classList.replace("yellow", "blue")
    } else {
        light6.classList.toggle("blue");
        // light6.classList.replace("blue", "green")
    }
})

const light7 = document.querySelector(".bulb7");

light7.addEventListener("click", function () {
    if (light7.classList.contains("blue")) {
        // light7.classList.toggle("green");
        light7.classList.replace("blue", "green")
    } else if (light7.classList.contains("green")) {
        // light7.classList.toggle("red");
        light7.classList.replace("green", "red")
    } else if (light7.classList.contains("red")) {
        // light7.classList.toggle("yellow")
        light7.classList.replace("red", "yellow")
    } else if (light7.classList.contains("yellow")) {
        // light7.classList.toggle("blue")
        light7.classList.replace("yellow", "blue")
    } else {
        light7.classList.toggle("blue");
        // light7.classList.replace("blue", "green")
    }
})


const light8 = document.querySelector(".bulb8");

light8.addEventListener("click", function () {
    if (light8.classList.contains("blue")) {
        // light8.classList.toggle("green");
        light8.classList.replace("blue", "green")
    } else if (light8.classList.contains("green")) {
        // light8.classList.toggle("red");
        light8.classList.replace("green", "red")
    } else if (light8.classList.contains("red")) {
        // light8.classList.toggle("yellow")
        light8.classList.replace("red", "yellow")
    } else if (light8.classList.contains("yellow")) {
        // light8.classList.toggle("blue")
        light8.classList.replace("yellow", "blue")
    } else {
        light8.classList.toggle("blue");
        // light8.classList.replace("blue", "green")
    }
})

const light9 = document.querySelector(".bulb9");

light9.addEventListener("click", function () {
    if (light9.classList.contains("blue")) {
        // light9.classList.toggle("green");
        light9.classList.replace("blue", "green")
    } else if (light9.classList.contains("green")) {
        // light9.classList.toggle("red");
        light9.classList.replace("green", "red")
    } else if (light9.classList.contains("red")) {
        // light9.classList.toggle("yellow")
        light9.classList.replace("red", "yellow")
    } else if (light9.classList.contains("yellow")) {
        // light9.classList.toggle("blue")
        light9.classList.replace("yellow", "blue")
    } else {
        light9.classList.toggle("blue");
        // light9.classList.replace("blue", "green")
    }
})


const light10 = document.querySelector(".bulb10");

light10.addEventListener("click", function () {
    if (light10.classList.contains("blue")) {
        // light10.classList.toggle("green");
        light10.classList.replace("blue", "green")
    } else if (light10.classList.contains("green")) {
        // light10.classList.toggle("red");
        light10.classList.replace("green", "red")
    } else if (light10.classList.contains("red")) {
        // light10.classList.toggle("yellow")
        light10.classList.replace("red", "yellow")
    } else if (light10.classList.contains("yellow")) {
        // light10.classList.toggle("blue")
        light10.classList.replace("yellow", "blue")
    } else {
        light10.classList.toggle("blue");
        // light10.classList.replace("blue", "green")
    }
})


const light11 = document.querySelector(".bulb11");

light11.addEventListener("click", function () {
    if (light11.classList.contains("blue")) {
        // light11.classList.toggle("green");
        light11.classList.replace("blue", "green")
    } else if (light11.classList.contains("green")) {
        // light11.classList.toggle("red");
        light11.classList.replace("green", "red")
    } else if (light11.classList.contains("red")) {
        // light11.classList.toggle("yellow")
        light11.classList.replace("red", "yellow")
    } else if (light11.classList.contains("yellow")) {
        // light11.classList.toggle("blue")
        light11.classList.replace("yellow", "blue")
    } else {
        light11.classList.toggle("blue");
        // light11.classList.replace("blue", "green")
    }
}) 