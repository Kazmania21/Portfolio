for (let i = 0; i <= 2; i++){
    $.get("./Answers.json", function(data, status){
        $("#Get").append(()=>{
            if (i < 2){
                return `<label>${i+1} = ${data.answers[i].answer}<label>`
            }

            return`<label>other = ${data.answers[i].answer}<label>`
        })
    })
}