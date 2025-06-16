import React from 'react';
import './Task1.css'

export class Button extends React.Component
{
    constructor(props)
    {
        super(props);
        this.change = this.change.bind(this);
        this.state = { class:this.props.from}
    }
    change(ev)
    {
        if(ev.target.className === this.props.from)
        {
            this.setState({class:this.props.to})
        }
        else { this.setState({class:this.props.from});}
    }
    render()
    {
        return (
            <button className={this.state.class} onClick={this.change}>{this.props.nameButton}</button>
        )
    }
}