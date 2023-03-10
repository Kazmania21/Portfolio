let express = require('express'),
    app = express();

let { readFileSync, writeFileSync } = require('fs');

const number = readFileSync('./Basics.txt', 'utf8')

console.log(number)

const writeFile = (data) => {
    writeFileSync(data)
}

app.use(express.static(__dirname + '/.'));

app.post('/answer', (req, res)=>{
    const answer = req.body
})

app.all("*", (req, res) => {
    res.status(404).send('Sorry. We could not find the page you are looking for.')
})

app.listen(8002);