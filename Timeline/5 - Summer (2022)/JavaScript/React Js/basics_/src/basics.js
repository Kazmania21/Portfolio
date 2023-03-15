export function question1() {
    var options = ["1. I'm doing good! How are you?", "2. Horrible"]
    
    var index = 1
    
    options.forEach(option => {
        document.getElementById(`arrayLabel${index}`).innerHTML += option
        index += 1
    })
}