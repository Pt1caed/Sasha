import '../styles/Catalog/Catalog.css'

function Card(props)
{
    const path = "/catalog/" + props.img;
    return (
        <div id="card">
            <img src={path} alt=""></img>
            <p>{props.name}</p>
        </div>
    )
}

function Components(start, end)
{
  let massiveComponents = [];
  for(let i = 0; i <= 17; i++)
  {
    massiveComponents.push(`Rectangle 28-${i}.png`)
  }
  return massiveComponents;
}

export function Catalog()
{
    let images = Components(19, 36);
      return (
        <section id="sectionCatalog">
          <div id="catalog">
            <p>КАТАЛОГ</p>
            {images.map(image => (
              <Card img={image} name="НАЗВА НАБОРУ"></Card>
            ))}
          </div>
        </section>
      );
}