import { useEffect, useState } from "react";
import { flushSync } from "react-dom";

function fromSecToData(secs)
{
    const secsStr = secs + "";
    return `${secsStr.slice(0, 2)}:${secsStr.slice(2,4)}:${secsStr.slice(4,6)}`
}



export function Weather()
{
    const apiKey = 'd77e8a80bfcc7551c3135a39d716ce92';
    const [weather, setWeather] = useState({
        city:"",
        temperature:"",
        icon:"",
        country:"",
        desc: "",
        sunrise:"",
        sunset:"",
    })

    async function fetchWeather()
    {
        const url = `https://api.openweathermap.org/data/2.5/weather?q=${weather.city}&appid=${apiKey}&units=metric`;
        const response = await fetch(url);
        if(!response.ok)
        {
            return;
        }

        const data = await response.json()
        const temperature = data.main.temp;
        const src = `https://openweathermap.org/img/wn/${data.weather[0].icon}.png`;
        const sunrise = data.sys.sunrise;
        const sunset = data.sys.sunset;
        setWeather({...weather, temperature: temperature, icon: src, country: data.sys.country, desc: data.weather[0].description, sunrise: fromSecToData(sunrise), sunset: fromSecToData(sunset)});
    }

    return (
        <div>
            <img src={weather.icon} alt=""></img>
            <h1>Прогноз погоды - <b>{weather.city}</b></h1>
            <h2>Температура: <b>{weather.temperature}</b></h2>
            <h3>Время заката: <b>{weather.sunrise}</b> Время рассвета: <b>{weather.sunset}</b></h3>
            <p>Описание: <b>{weather.desc}</b></p>
            <input type="text" value={weather.city} onChange={(e) => setWeather({...weather, city: e.target.value})}></input>
            <button onClick={fetchWeather}>Поиск</button>
        </div>
    )
}