﻿document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This content comes from third.js";
    element.setAttribute("id", "thirdDiv");
    element.setAttribute("class", "czary");
    document.querySelector("body").appendChild(element);
})