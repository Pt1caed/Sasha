import './Task3.css'


export function Info()
{
    const yourInfo = {
        name: "Alexandr",
        surname: "Rubov",
        age: 16,
        contactNumber: "+380674523212",
        email: "AlexandrRubov@i.ua",
    }

    const p = "infoP"
    const p1 = "infoPSmall";
    return(
    <div id='divInfo'>
        <p id={p}>Информация о тебе:</p>
        <p id={p1}>Имя: {yourInfo.name}</p>
        <p id={p1}>Фамилия: {yourInfo.surname}</p>
        <p id={p1}>Возраст: {yourInfo.age}</p>
        <p id={p1}>Номер телефона: {yourInfo.contactNumber}</p>
        <p id={p1}>Почта: {yourInfo.email}</p>
    </div>
    )
}