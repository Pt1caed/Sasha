import { useState } from 'react'
import './Forms.css'
import {Link} from "react-router-dom"

export function AuthorizationForm(props)
{
    return (
       <div id="mainPage">
            <ImageWithTextForm img="/images/authorization.png" text="ЗАПОВНІТЬ ВХІД ДО ОБЛІКОВОГО ЗАПИСУ"></ImageWithTextForm>
            <div id="firstForm">
                <InputForm title="Електронна пошта або мобільний номер" description={<PrivacyPoliceDesc></PrivacyPoliceDesc>}></InputForm>
                <PasswordInputForm></PasswordInputForm>
                <div id="saveInformation">
                    <label>
                        <input type="checkbox"></input>
                        Зберегти інформацію
                    </label>
                    <ButtonWithImg img="/images/icons/info.png" width="20px" height="20px" onClick={null} id="infoForm"></ButtonWithImg>
                </div>
                <button id="blackButton">ПРОДОВЖИТИ</button>

                <div id="createAccount">
                    <p>У вас ще нема облікового запису? Створіть його: </p>
                    <Link to="/registration">
                        <button id="whiteButton">СТВОРИТИ АККАУНТ</button>
                    </Link>
                </div>
            </div>
       </div> 
    )
}
export function RegistrationForm(props)
{
    let massiveFields = [["Ім'я", null], ["Фамілія", null], ["Дата народження", null], ["Країна", null], ["Адреса", null], ["Мобільний номер", <PrivacyPoliceDesc></PrivacyPoliceDesc>], ["Електронна пошта", <VerificationDesc></VerificationDesc>], ["Пароль", null]]

    return (

    <div id="mainPage">
        <ImageWithTextForm img="/images/registration.png"></ImageWithTextForm>
        <div id="firstForm">
            {massiveFields.map(element => (
                <InputForm title={element[0]} description={element[1]}></InputForm>
            ))}
            <label id="confirmPrivatePolice">
                <input type="checkbox"></input>
                <p>Я, ознайомлений з Політикою конфіденційності з обробки та захисту персональних даних</p>
            </label>
            <button id="blackButton">ПРОДОВЖИТИ</button>
        </div>
    </div>
    )   
}

function PasswordInputForm(props)
{
    const [typeInput, setTypeInput] = useState("text")

    return (
    <div id="inputForm">
        <p id="titleInputForm">Пароль</p>
        <div id="inputInputForm">
            <ButtonWithImg img="/images/icons/viewPassword.png" width="24px" height="15px" event={() => {setTypeInput(typeInput === "text" ? "password" : "text")}} id="viewPasswordForm"></ButtonWithImg>
            <input type={typeInput}></input>
        </div>
        <a href="/">Забули свій пароль?</a>
    </div>
    )
}

function ImageWithTextForm(props)
{
    const path = `url(${props.img})`
    return (
        <span style={{backgroundImage: path}} id="spanForm">

            <Link to="/">
                <ButtonWithImg id="waveButton" img="/images/icons/waveButton.png" width="42px" height="42px"></ButtonWithImg>
            </Link>
            <div id="divSpanForm">
                <p id="pSpanForm">{props.text}</p>
            </div>
        </span>
    )
}
function InputForm(props)
{
    return (
    <div id="inputForm">
        <p id="titleInputForm">{props.title}</p>
        <div id="inputInputForm">
            <input type="text" id=""></input>
        </div>
        {props.description}
    </div>
    )
}
function VerificationDesc()
{
    return <p id="descriptInputForm">Вам потрібно буде пройти верифікацію</p>
}
function PrivacyPoliceDesc()
{
    return (<p id="descriptInputForm">By entering your mobile number and one-time code sign-in option, you agree to receive a one-time verification code via SMS from IKEA. Message and data rates may apply. <a href="/">More info about Privacy Policy</a></p>)
}
function ButtonWithImg(props)
{
    const img = `url(${props.img})`;
    const style = {
        width: props.width,
        height: props.height,
        backgroundImage: img,
        cursor: "pointer",
        display: "inline-block",
        margin: "auto 5px",
    }
    return (
        <span id={props.id} style={style} onClick={props.event}></span>
    )
}