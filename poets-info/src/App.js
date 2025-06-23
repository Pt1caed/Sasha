
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import { IndexPage, Poet, AllPoets } from './Poets';




function App() {
  
  let poets = AllPoets();

  return (
    <div id="app">
      <img id="imgApp" src="https://www.telefonica.com/en/wp-content/uploads/sites/5/2023/09/10-Tips-to-improve-your-photos-e1696506323825.jpg" alt=""></img>
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<IndexPage/>}>
              {poets.map(poet => (
                <Route path={poet.path} element={<Poet fullName={poet.fullName} img={poet.img} info={poet.info}></Poet>}></Route>
              ))}
            </Route>
          </Routes>
        </BrowserRouter>
    </div>
  );
}

export default App;
