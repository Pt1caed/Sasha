import { Component } from 'react';
import './Task4.css'

export class QuoteOfTheDay extends Component {
    constructor(props) {
        super(props);
        this.state = {name:this.props.quotes[0].name, text:this.props.quotes[0].text, count:0 }
        
        this.changeQuote = this.changeQuote.bind(this);
    }
    changeQuote()
    {
        let i = this.state.count + 1;
        if(i === this.props.quotes.length)
        {
            i = 0;
        }
        this.setState({name:this.props.quotes[i].name, text:this.props.quotes[i].text, count:i })
    }
    render()
    {
        return (
            <div id="quote">
                <div>
                    <p id="quoteName">{this.state.name}</p>
                    <p id="quoteText">{this.state.text}</p>
                </div>
                <button id="quoteButton" onClick={this.changeQuote}>Поменять цитату</button>
            </div>
        )
    }
    
}