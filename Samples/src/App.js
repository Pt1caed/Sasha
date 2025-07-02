import React from 'react';
import './App.css';
import {Avatar} from './components/avatar'
import { Counter1 } from './components/counter';
import { Weather } from './components/fetchUse'
class App extends React.Component {

  render () {
    return (
      <div className="App">
        <header className="App-header">
          <Weather></Weather>
        </header>
      </div>
    );
  }
}
export default App;
