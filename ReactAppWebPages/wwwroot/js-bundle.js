document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This content comes from (modified) third.js";
    element.setAttribute("id", "thirdDiv");
    element.setAttribute("class", "czary");
    document.querySelector("body").appendChild(element);
})
document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "This is element from fourth.js file";
    element.setAttribute("id", "fourthDiv");
    element.setAttribute("class", "czary");
    document.querySelector("body").appendChild(element);
})