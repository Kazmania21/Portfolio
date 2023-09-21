const xhttp = new XMLHttpRequest()

xhttp.onload = function() {
    console.log(this.responseText)
}

xhttp.open("GET", "./projects.json")
xhttp.send()