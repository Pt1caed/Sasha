import React, { Component, useState, useEffect } from 'react';
import './style.css';

export function Counter1()
{
  const [state, setState] = useState({count: 0});
  const [hello, setHello] = useState()

  let increaseCounter1 = function(_e)
  {
    setState({ count: parseInt(state.count) + 2 })
  }

  let increaseCounter2 = _e => {
    setState({ count: parseInt(state.count) + 1 })
  }

  let resetCounter = () => setState({ count: 0 })

  
  useEffect(() => {
    console.log("componentDidMount-> ",state.count);
    
  }, [1])
  
  useEffect(() => {
    console.log("componentDidUpdate -> ",state.count);
  })
  return (
      <div className="counter__container">
        <div className="counter__header">
          <p>You clicked {state.count} times</p>
        </div>
        <div className="counter__main">
          <button onClick={increaseCounter1}>Increase counter with arrow function</button>
          <button onClick={increaseCounter2}>Increase counter with bind</button>
          <button onClick={resetCounter}>Reset counter</button>
        </div>
      </div>
    );
}

export class Counter extends Component 
{
  constructor(props)
  {
    super(props);
    this.state = { count: 0 }

    this.increaseCounter1 = this.increaseCounter1.bind(this);
  }

  increaseCounter1 = function(_e)
  {
    this.setState({ count: this.state.count + 2 })
  }

  increaseCounter2 = _e => {
    this.setState({ count: this.state.count + 1 })
  }

  resetCounter = () => this.setState({ count: 0 })


  componentDidMount(){
    console.log("componentDidMount -> ",this.state.count);
  }
  componentDidUpdate(){
    console.log("componentDidUpdate -> ",this.state.count);
  }
  componentWillUnmount(){
    console.log("componentWillUnmount -> ",this.state.count);
  }

  render()
  {
    return (
      <div className="counter__container">
        <div className="counter__header">
          <p>You clicked {this.state.count} times</p>
        </div>
        <div className="counter__main">
          <button onClick={this.increaseCounter1}>Increase counter with arrow function</button>
          <button onClick={this.increaseCounter2}>Increase counter with bind</button>
          <button onClick={this.resetCounter}>Reset counter</button>
        </div>
      </div>
    );
  }
}

