import React, { Component } from 'react'
import { answers } from "./answers.json"

export class Answers extends Component{
    render(){  
       return(
            <div>
                <fieldset id="answers">
                    <label>{ answers[Number(this.props.id - 1)].answer }</label>
                </fieldset>
            </div>
       )  
    }
}  