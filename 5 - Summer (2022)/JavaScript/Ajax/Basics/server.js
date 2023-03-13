let express = require('express'),
    app = express();

const { answers } = require("./Answers.json")

app.use(express.urlencoded({extended: true}))
    
app.use(express.json())

app.use(express.static(__dirname + '/.'));

app.post("/post", (req, res)=>{
    var data = req.body

    try { //if the id of the user's input is found in answers
        res.status(200).send(`<fieldset> ${answers[data.user_Input - 1].answer} </fieldset>`)
    }

    catch (TypeError) { //if the id of the user's input is not found in answers
        res.status(200).send(`<fieldset> ${answers[2].answer} </fieldset>`)
    }
})

app.all("*", (req, res) => {
    res.status(404).send('Sorry. We could not find the page you are looking for.')
})

app.listen(8002);