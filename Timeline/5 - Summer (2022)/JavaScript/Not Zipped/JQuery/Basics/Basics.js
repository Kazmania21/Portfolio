var options = ["1. I'm doing good! How are you?", "2. Horrible"]
    
var index = 1
    
options.forEach(option => {
    $(`#arrayLabel${index}`).text(option)
    index += 1
})

$("#SubmitButton").click(function(){
    $.post("/post", { "user_Input": $("#user_Input").val() }, function(data, status){
        $("#response").append(data)
    })
})

$("#ResponsesButton").click(function(){
    $("#response").load("./Get.html")
})