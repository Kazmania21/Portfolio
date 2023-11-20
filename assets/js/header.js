const header_xhttp = new XMLHttpRequest()

header_xhttp.onload = function() {
    const body = document.body
    body.innerHTML = this.responseText + body.innerHTML
}

header_xhttp.open("GET", "/header.html")
header_xhttp.send()