export function question2(){
    var options = ["1. I'm doing good! How are you?", "2. Horrible"]

    for (var index = 0; index <= 1; index++) {
        document.getElementById(`listLabel${index + 1}`).innerHTML += options[index]
    }
}