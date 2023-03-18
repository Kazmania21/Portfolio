import React, { Component } from "react"
import { Route, Routes, BrowserRouter } from 'react-router-dom'
import { Rojo } from "./basics.jsx"
import { answers } from "./answers.json"
import { Answers } from "./answers.jsx"

export class App extends Component{

    getPost(){
        let url = window.location.href

        let index = url.lastIndexOf("/")
        
        return url.slice(index + 1, url.length)
    }

    useGet(ClassElement, strElement){
        let url = window.location.href

        let index = url.indexOf("?")
        
        if (index !== -1){
            return <ClassElement id={url.slice(index + 1, url.length)}/>
        }

        return strElement
    }

    render(){
        return(
            <BrowserRouter>
                <Routes>
                    <Route exact path="/" element={ <Rojo /> }></Route>
                    <Route exact path="/answers" element={ this.useGet(Answers, JSON.stringify(answers)) }></Route>
                    <Route exact path="/answers/:id" element={ <Answers id={this.getPost()}/> }></Route>
                </Routes>
            </BrowserRouter>
        )
    }
}