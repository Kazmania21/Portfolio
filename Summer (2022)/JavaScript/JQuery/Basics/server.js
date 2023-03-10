const express = require("express")
const { data } = require("jquery")
    app = express()

const { answers } = require("./Answers.json")

app.use(express.urlencoded({extended: true}))

app.use(express.json())

app.use(express.static(__dirname + '/.'))

app.post("/post", (req, res)=>{
    var data = req.body

    res.status(200).send(answers[data.user_Input - 1].answer)
})

app.listen(8001)