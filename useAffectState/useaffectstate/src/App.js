import logo from './logo.svg';
import './App.css';
import { InfoRestaurant } from './Task1';

function App() {
  let restaurant = {
    name: "Irina",
    address: "Классная №123",
    rating: "5.5",
    typeKitchen: "Китайская кухня",
    img: "https://avatars.mds.yandex.net/get-altay/10926933/2a0000018b1a21faa71938fce2f7daae4b8f/L_height"
  }
  return (
    <div className="App">
      <InfoRestaurant rest={restaurant}></InfoRestaurant>
    </div>
  );
}

export default App;
