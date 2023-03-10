import React, { Component } from 'react'
import './basics.css'
import { Module } from './basics_2.jsx'
import { question1 } from './basics.js'
// import axios from 'axios'

export class Rojo extends Component{
    componentDidMount(){
        question1()
    }

    render(){
        return(
            <div>
                <fieldset id="question1">
                    <label>Hello! How are you?</label>
                    <label>Options:</label>
                    <label id="arrayLabel1"></label>
                    <label id="arrayLabel2"></label>
                    <input type="text" name="user_Input" id="user_Input"></input>

                    <button onClick={this.buttonClicked}>Submit</button>

                    <button onClick={this.getAnswers}>Get All Answers For Each Response</button>
                </fieldset>

                <Module />
            </div>
       )
    }  
    buttonClicked() {
        //const data = {
        //    id : document.querySelector("#user_Input").value
        //}

        //axios.post("/answers", data)

        let user_Input = document.querySelector("#user_Input").value

        if (user_Input === "1" || user_Input === "2"){
            window.location.assign("/answers/" + user_Input)
        }
    }

    getAnswers() {
        window.location.assign("/answers")
    }
}  