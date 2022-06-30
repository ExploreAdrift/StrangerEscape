function trackMouse(event) {
  document.documentElement.style.setProperty("--cursorXpos", `${event.clientX}px`);
  document.documentElement.style.setProperty("--cursorYpos", `${event.clientY}px`);
}
document.addEventListener("mousemove", trackMouse);

// this is for the basement lights
function openFormLights() {
  document.getElementById("basementlights").style.display = "block";
}

function closeFormLights() {
  document.getElementById("basementlights").style.display = "none";
}


// this is for the fort when you dont have access 
function openFort() {
  document.getElementById("fort").style.display = "block";
}

function closeFort() {
  document.getElementById("fort").style.display = "none";
}

// this is for the door when they cant leave
function openLivingRoomDoor() {
  document.getElementById("LivingRoomDoor").style.display = "block";
}

function closeLivingRoomDoor() {
  document.getElementById("LivingRoomDoor").style.display = "none";
}


// this is to track the value of the light switch riddle clicks
let hiddenSwitchFormValue = "";

function pressSwitch(numVal) {
  if (hiddenSwitchFormValue.length <= 3) {
    hiddenSwitchFormValue = hiddenSwitchFormValue + numVal.toString();
  }
  document.getElementById("lightriddle").setAttribute("value", hiddenSwitchFormValue);

  let lightriddle = document.getElementById("lightriddle");
  console.log(lightriddle);
}

// this is to change the light switch photos

function pictureChange() {
  document.getElementById("theImage").src = "../img/SingleDown.jpg";
}

function pictureChange2() {
  document.getElementById("theImage2").src = "../img/SingleDown.jpg";
}

function pictureChange3() {
  document.getElementById("theImage3").src = "../img/SingleDown.jpg";
}

function pictureChange4() {
  document.getElementById("theImage4").src = "../img/SingleDown.jpg";
}

particlesJS("particles-js", {
  particles: {
    number: {
      value: 500,
      density: {
        enable: true,
        value_area: 500,
      },
    },
    color: {
      value: "#ffffff",
    },
    shape: {
      type: "circle",
      stroke: {
        width: 0,
        color: "#000000",
      },
      polygon: {
        nb_sides: 5,
      },
      image: {
        src: "img/github.svg",
        width: 100,
        height: 100,
      },
    },
    opacity: {
      value: 0.48927153781200905,
      random: true,
      anim: {
        enable: true,
        speed: 0.2,
        opacity_min: 0,
        sync: false,
      },
    },
    size: {
      value: 2,
      random: true,
      anim: {
        enable: true,
        speed: 2,
        size_min: 0,
        sync: false,
      },
    },
    line_linked: {
      enable: false,
      distance: 150,
      color: "#ffffff",
      opacity: 0.4,
      width: 1,
    },
    move: {
      enable: true,
      speed: 2,
      direction: "none",
      random: true,
      straight: false,
      out_mode: "out",
      bounce: true,
      attract: {
        enable: false,
        rotateX: 600,
        rotateY: 1200,
      },
    },
  },
  interactivity: {
    detect_on: "canvas",
    events: {
      onhover: {
        enable: true,
        mode: "bubble",
      },
      onclick: {
        enable: true,
        mode: "push",
      },
      resize: true,
    },
    modes: {
      grab: {
        distance: 400,
        line_linked: {
          opacity: 1,
        },
      },
      bubble: {
        distance: 75,
        size: 1,
        duration: 3,
        opacity: 1,
        speed: 3,
      },
      repulse: {
        distance: 200,
        duration: 0.4,
      },
      push: {
        particles_nb: 4,
      },
      remove: {
        particles_nb: 2,
      },
    },
  },
  retina_detect: true,
});
