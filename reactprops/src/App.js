import './styles/App.css';
import { Catalog } from './components/Catalog' 
import { Menu } from './components/Menu'
import { NavigationCards } from './components/NavigationCards';
import { Suites } from './Suites';
function App() {

  return (
    <div>
      <Menu></Menu>
      <NavigationCards></NavigationCards>
      <Suites nameImg="recommendations/recommendation" count="7" title="РЕКОМЕНДАЦІЇ" id="sectionRecommendations"></Suites>
      <Suites nameImg="theBestKits/bestkit" count="7" title="НАЙКРАЩІ НАБОРИ" id="sectionRecommendations"></Suites>
      <Catalog></Catalog>
      
    </div>
  )
}

export default App;

