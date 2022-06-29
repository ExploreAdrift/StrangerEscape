function trackMouse(event){
    document.documentElement.style.setProperty(
        '--cursorXpos', `${event.clientX}px`
        )
    document.documentElement.style.setProperty(
        '--cursorYpos', `${event.clientY}px`
        )
}
document.addEventListener('mousemove', trackMouse)

// this is for the basement lights
function openFormLights() {
    document.getElementById("basementlights").style.display = "block";
}

function closeFormLights() {
    document.getElementById("basementlights").style.display = "none";
}

// this is to track the value of the light switch riddle clicks
let hiddenSwitchFormValue = "";

function pressSwitch(numVal) {
    if(hiddenSwitchFormValue.length <= 3){
        hiddenSwitchFormValue = hiddenSwitchFormValue + numVal.toString();
    }
    document.getElementById("lightriddle").setAttribute('value', hiddenSwitchFormValue)

    let lightriddle = document.getElementById("lightriddle")
    console.log(lightriddle)
}

// this is to change the light switch photos 

function pictureChange()
{
document.getElementById('theImage').src="../img/SingleDown.jpg";
}

function pictureChange2()
{
document.getElementById('theImage2').src="../img/SingleDown.jpg";
}

function pictureChange3()
{
document.getElementById('theImage3').src="../img/SingleDown.jpg";
}

function pictureChange4()
{
document.getElementById('theImage4').src="../img/SingleDown.jpg";
}