import './App.css';
import { Card } from './Catalog' 

function Components(start, end)
{
  let massiveComponents = [];
  for(let i = 0; i <= 17; i++)
  {
    massiveComponents.push(`Rectangle 28-${i}.png`)
  }
  return massiveComponents;
}
function App() {
  
  let images = Components(19, 36);
  return (
    <section>
      <div id="catalog">
        <p>КАТАЛОГ</p>
        {images.map(image => (
          <Card img={image} name="НАЗВА НАБОРУ"></Card>
        ))}
      </div>
    </section>
  );
}

export default App;
