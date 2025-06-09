import './Task4.css'

export function InfoCity()
{
    const city = {
        name: "Odessa",
        nameCountry: "Ukraine",
        yearOfBase: 1794,
        listImagesCity: 
        [
            "https://vgorode.ua/img/article/11788/24_main-v1632136806.jpg",
            "https://odessa-life.od.ua/wp-content/uploads/2021/09/skolko-let-Odesse.jpg",
            "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Potemkinstairs.jpg/1200px-Potemkinstairs.jpg",
        ]
    }
    return (
        <div id='divInfoCity'>
            <p>Название города: <b>{city.name}</b></p>
            <p>Название страны: <b>{city.nameCountry}</b></p>
            <p>Год основания: <b>{city.yearOfBase}</b></p>
            <p>Фото из города:</p>
            <img src={city.listImagesCity[0]} alt=""></img>
            <img src={city.listImagesCity[1]} alt=""></img>
            <img src={city.listImagesCity[2]} alt=""></img>
        </div>
    )
}