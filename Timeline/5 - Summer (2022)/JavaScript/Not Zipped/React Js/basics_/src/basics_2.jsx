import React, { Component } from 'react'
import { question2 } from './basics_2.js'

export class Module extends Component{
    componentDidMount(){
        question2()
    }  

    render(){  
       return(
            <div>
                <fieldset id="question2">
                    <label>Hello! How are you?</label>
                    <label>Options:</label>
                    <label id="listLabel1"></label>
                    <label id="listLabel2"></label>
                    <input type="text" name="user_Input" id="user_Input2"></input>
                    <button onClick={this.buttonClicked}>Submit</button>
                    <button onClick={this.getAnswers}>Get All Answers For Each Response</button>
                </fieldset>
            </div>
       )  
    }  

    buttonClicked() {
        let user_Input = document.querySelector("#user_Input2").value

        if (user_Input === "1" || user_Input === "2"){
            window.location.assign("/answers/?" + user_Input)
        }

        else {
            window.location.assign("/answers/?3")
        }
    }

    getAnswers() {
        window.location.assign("/answers")
    }
}  