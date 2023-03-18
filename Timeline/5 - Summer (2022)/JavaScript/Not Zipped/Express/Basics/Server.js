let express = require('express'),
    app = express();

let { readFileSync, writeFileSync } = require('fs');

const api = require('./Answers.json')

app.use(express.json());

app.use(express.urlencoded({extended: true}));

app.use(express.static(__dirname + "/."));

app.get("/data", (req, res)=>{
    res.status(200).json(api.answers)
})

app.post("/", (req, res)=>{

    var data = req.body

    writeFileSync("./Basics.json", 
    `{
    "user_Inputs": [
        {
            "user_Input": "${data.user_Input}"
        }
    ]
}`, {flag: "w"})

    res.json(req.body)

    //window.location.assign("/Basics.html")

})

app.get("/answers", (req, res)=>{
    const { idNumber } = req.query
    
    let sortedAnswers = [...api.answers]

    if (idNumber) {
        sortedAnswers = sortedAnswers.filter((api)=>{
            return api.id.startsWith(idNumber)
        })
    }

    res.status(200).json(sortedAnswers)
})

app.get("/answers2", (req, res)=>{
    function search(answer) {
        return answer.id === idNumber
    }

    const { idNumber } = req.query

    const { newAnswer } = req.query
    
    let sortedAnswers = [...api.answers]

    const index = api.answers.findIndex(search)

    console.log(newAnswer)

    api.answers[index] = {id: idNumber, answer: newAnswer}

    console.log(api.answers)

    res.status(200).json(api.answers)
})

//?_method=PUT

//app.use(methodOverride("_method"))

//app.get("/answers2/:id", (req, res)=>{
//    res.send(req.params)
//})

app.get("/answers3", (req, res)=>{
    function search(answer) {
        return answer.id === idNumber
    }

    const { idNumber } = req.query

    const index = api.answers.findIndex(search)

    api.answers[index] = {}

    let apiStr = `{
    "answers": [`

    api.answers.forEach(answerJSON => {
        apiStr += `
        {
            "id": "${answerJSON.id}",
            "answer": "${answerJSON.answer}"
        },
`
    });

    apistr = apiStr.slice(0, -2)

    apiStr += `]
}`

    writeFileSync("Answers.json", apiStr)

    res.status(200).json(api.answers)
})

app.all('*', (req, res)=>{
    res.status(404).send("Sorry, the file you are looking for could not be found.")
})

app.listen(8005);