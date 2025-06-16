import { Component } from 'react';
import './Task2.css'

class Biography extends Component {
    render() {
        return (<div id="biography">
            <p>Имя: {this.props.name}</p>
            <p>Фамилия: {this.props.surname}</p>
            <p>Возраст: {this.props.age}</p>
            <p>Родился в: {this.props.country}</p>
            <p>Описание: {this.props.description}</p>
        </div>)
    }
}

class Portret extends Component {
    render() {
        return (<img src={this.props.img} id="portret" alt="portret"></img>)
    }
}

export class GreatMan extends Component
{
    render()
    {
        return (<div id="GreatManDiv">
            <Biography name={this.props.name} surname={this.props.surname} age={this.props.surname} country={this.props.country} description={this.props.description}></Biography>
            <Portret img={this.props.img}></Portret>
        </div>)
    }
}