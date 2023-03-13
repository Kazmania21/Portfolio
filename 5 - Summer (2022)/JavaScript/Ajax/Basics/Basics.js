const xhttp = new XMLHttpRequest()

options = ["1. I'm doing good! How are you?", "2. Horrible"]

for (let index=0; index<=1; index++){
    document.getElementById(`arrayLabel${index+1}`).innerHTML = options[index]
}

function getAnswers(){
    xhttp.onload = function() {
        document.getElementById("getObject").innerHTML = this.responseText
        //document.body.appendChild = this.body
    }

    xhttp.open("GET", "./Get.html")
    xhttp.send()
}

function postAnswer(){
    xhttp.onload = function() {
        document.getElementById("postObject").innerHTML = this.responseText
        //document.body.appendChild = this.body
    }
    
    xhttp.open("POST", "/post")
    
    xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded")
    
    xhttp.send(`user_Input=${document.getElementById("user_Input").value}`)
}