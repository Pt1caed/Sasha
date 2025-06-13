import './Catalog.css'

export function Card(props)
{
    const path = "/catalog/" + props.img;
    return (
        <div id="card">
            <img src={path} alt=""></img>
            <p>{props.name}</p>
        </div>
    )
}

