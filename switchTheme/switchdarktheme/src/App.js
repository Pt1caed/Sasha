
import './App.css';
import { Button } from './Tasks/Task1';
import { GreatMan } from './Tasks/Task2';
import { QuoteOfTheDay } from './Tasks/Task4';

function quote(name, text)
{
  return {
    name:name,
    text:text,
  }
}

let quotes = 
[
  quote("Lorem", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,"),
  quote("Lorem1", "re-or-less normal distribution of letters, as opposed to using 'Conte"),
  quote("Lorem2", "ed alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to us"),

]

function App() {
  return (
    <div id="app">
      {/* Первое и третье задание */}
      <div id="buttons">
        <Button from="white" to="black" nameButton="hello"></Button>
        <Button from="orange" to="gray" nameButton="hi"></Button>
        <Button from="pink" to="purple" nameButton="bye"></Button>
      </div>
      {/* Второе задание */}
      <div id="GreatMan">
        <GreatMan name="Alexandr" surname="Rubov" age="18" country="Ukraine" img="https://img.freepik.com/free-photo/portrait-smiling-charming-young-man-grey-t-shirt-standing-against-plain-background_23-2148213406.jpg?semt=ais_hybrid&w=740" description="lor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
        Duis aute irure dolor in reprehenderit in voluptate velit esse cillum ">
        </GreatMan>
      </div>
      {/* Четвёртое задание */}
      <div id="quotes">
        <QuoteOfTheDay quotes={quotes}></QuoteOfTheDay>
      </div>

    </div>

  
  );
}

export default App;
