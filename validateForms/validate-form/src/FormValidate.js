import { useState } from "react"
import './FormValidate.css'

function TextLabelUser(props)
{
    const [styleName, setStyleName] = useState("invalid");
    const regex = new RegExp(props.pattern);
    function onChangeValue(e)
    {
        const regexTest = regex.test(e.target.value)
        props.setState(e);
        regexTest ? setStyleName("valid") : setStyleName("invalid");
        props.setValid(regexTest);
    }

    return (
        <label id="textUser">
            {props.text}
            <input className={styleName} type="text" value={props.state} onChange={onChangeValue}></input>
        </label>
    )
}
function AboutLabelUser(props)
{
    return (
        <label id="userAbout">
            About
            <textarea value={props.state} onChange={props.setState}></textarea>
        </label>
    )
}
function SelectLabelUser(props)
{
    function handleChange(e)
    {
        props.setState(e);
        let value = e.target.value !== "";
        props.setValid(value);
    }
    return (
            <label id="userCountry">
                Country [Must select a country]
                <select value={props.country} onChange={handleChange}>
                    {props.countries.map(country => (
                        <option>{country}</option>
                    ))}
                </select>
            </label>
    )
}
function GenderLabelUser(props)
{
    return (
        <label id="userGender">
            Gender [Male of Female]
            <label>
                <input type="radio" name="genderInput" id="genderInput" value="male" onClick={(e) => {props.setState(e); props.setValid(true)}}></input>
                Male
            </label>
            <label>
                <input type="radio" name="genderInput" id="genderInput" value="female" onClick={(e) => {props.setState(e); props.setValid(true)}}></input>
                Female
            </label>
        </label>
    )
}
function LanguageLabelUser(props)
{
    function handleChange(e)
    {
        let checkedBoxClon = props.checkedBox;
        if(props.checkedBox.indexOf(e.target.value) === -1)
        {
            checkedBoxClon.push(e.target.value)
        }
        else { checkedBoxClon = checkedBoxClon.filter((element) => element !== e.target.value)}
        props.setCheckedBox("language", checkedBoxClon)
    }

    return (
    <label id="userLanguage">
        Language [Optional]
        <label>
            <input type="checkbox" name="languageInput" value="russian" onChange={handleChange}></input>
            Russian
        </label>
        <label>
            <input type="checkbox" name="languageInput" value="english" onChange={handleChange}></input>
            English
        </label>
    </label>
    )
}

export function FormValidity(props)
{
    const countries = [null, "Germany", "Ukraine", "Moldova", "Canada", "Iceland"]
    const[dataUser, setDataUser] = useState({id: "", password: "", name: "", address: "", country: countries[0], zipCode: "", email: "", gender: "", language: [], about: ""})
    const[dataUserValid, setDataUserValid] = useState({idValid: false, passwordValid: false, nameValid: false, addressValid: false, countryValid: false, zipCodeValid: false, emailValid: false, languageValid: true, aboutValid: true, })
    

    function submit(e)
    {
        e.preventDefault();

        let isError = false;
        const dataUserValidMassive = Object.keys(dataUserValid);
        dataUserValidMassive.forEach(element => {
            console.log(`${element} - ${dataUserValid[element]}`)
            if(!dataUserValid[element] || dataUserValid[element] === null)  
            {
                props.setDialogText(`Incorrect data - ${element}`)
                props.setDialogOpen(true);
                isError = true;
                return;
            }
        });
        if(isError) {return;}

        let textDialog = [];
        const dataUserMassive = Object.keys(dataUser);
        dataUserMassive.forEach(element => {
            textDialog.push(<div id="textDialog">{element} : <b>{dataUser[element]}</b></div>)
        })
        console.log(dataUser)
        props.setDialogText(textDialog)  
        props.setDialogOpen(true);
        return;
    }
    function changeStateDataUser(name, e)
    { 
        setDataUser({...dataUser, [name]: e.target.value})
    }
    function changeStateDataUserNoTarget(name, value)
    {
        setDataUser({...dataUser, [name]: value})

    }
    function setValid(name, value)
    {
        setDataUserValid({...dataUserValid, [name]: value})
    }

    return (
        <form id="userForm" onSubmit={submit}>
            <div id="divUserForm">
                <TextLabelUser pattern="^\w{5,7}$" setValid={(value) => setValid("idValid", value)} setState={(e) => changeStateDataUser("id", e)} state={dataUser.id}  text="User Id [5 to 7 characters]"></TextLabelUser>
                <TextLabelUser pattern="^\w{7,12}$"  setValid={(value) => setValid("passwordValid", value)} setState={(e) => changeStateDataUser("password", e)} state={dataUser.password} text="Password [7 to 12 characters]"></TextLabelUser>
                <TextLabelUser pattern="^[a-zA-Z]{2,}"  setValid={(value) => setValid("nameValid", value)} setState={(e) => changeStateDataUser("name", e)} state={dataUser.name} text="Name [Alphabates characters]"></TextLabelUser>
                <SelectLabelUser setValid={(value) => setValid("countryValid", value)} setState={(e) =>  changeStateDataUser("country", e)} countries={countries} ></SelectLabelUser>
                <TextLabelUser pattern="^[a-zA-Z0-9]{3,}$" setValid={(value) => setValid("addressValid", value)}  setState={(e) => changeStateDataUser("address", e)} state={dataUser.address} text="Address [alphanumeric characters]"></TextLabelUser>
                <TextLabelUser pattern="^[a-zA-Z0-9]{5,}$" setValid={(value) => setValid("zipCodeValid", value)}  setState={(e) => changeStateDataUser("zipCode", e)} state={dataUser.zipCode} text="ZIP Code [alphanumeric characters]"></TextLabelUser>
                <TextLabelUser pattern="^[a-z0-9._%+\-]+@[a-z0-9.\-]+(\.[a-z]{2,}|\.xn--[a-z0-9]+)$" setValid={(value) => setValid("emailValid", value)}  setState={(e) => changeStateDataUser("email", e)} state={dataUser.email} text="Email [Valid email]"></TextLabelUser>
                <GenderLabelUser setValid={(value) => setValid("gender", value)} setState={(e) => changeStateDataUser("gender", e)}></GenderLabelUser>
                <LanguageLabelUser setCheckedBox={changeStateDataUserNoTarget} checkedBox={dataUser.language}></LanguageLabelUser>
                <AboutLabelUser setState={(e) => changeStateDataUser("about", e)} state={dataUser.about}></AboutLabelUser>
                <input type="submit" value="click"></input>
            </div>
        </form>
        
    )
} 