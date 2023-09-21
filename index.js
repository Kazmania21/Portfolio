const xhttp = new XMLHttpRequest()

xhttp.onload = function() {
    console.log("hi")
}

xhttp.open("GET", "./projects.json")
xhttp.send()