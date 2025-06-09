import './App.css';
import { Navbar } from './ClassWork/Navbar';
import { Book } from './ClassWork/Card';
import { Info } from './DZ/Task3/Task3';
import { InfoCity } from './DZ/Task4/Task4';

function App() {
  return (
    <div>
      <p>Классная работа: </p>
      <Navbar></Navbar>
      <Book></Book>
      <p>Дз:</p>
      <Info></Info>
      <InfoCity></InfoCity>
    </div>
  );
}

export default App;
