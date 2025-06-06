let api = "9135f63c83535c27ddef7bf2"

let requestCurrencyRate = `https://v6.exchangerate-api.com/v6/${api}/latest/`;
let requresCurrencyName = "https://openexchangerates.org/api/currencies.json";

let popularityCurrencyRate = document.querySelector("#popularityCurrencyRate")

let buttonPCR = popularityCurrencyRate.querySelector("#popularityCurrencyRateButton");
let inputTextPCR = popularityCurrencyRate.querySelector("#popularityCurrencyRateInput");
let tablePCR = popularityCurrencyRate.querySelector("#popularityCurrencyRateTable");



let buttonImgTheme = document.querySelector("#darkLightTheme");

let namesOfCurrency;

fetch(requresCurrencyName)
.then(promise => promise.json())
.then(result => namesOfCurrency = result);


function switchTheme(theme)
{
    
    let ico = document.querySelector("#darkLightTheme");
    let switchOn;
    document.documentElement.removeAttribute("data-theme");
    switch(theme)
    {
        case "dark":
            document.documentElement.setAttribute("data-theme", "light");
            ico.textContent = "light_mode"
            break;
        case "light":       
            document.documentElement.setAttribute("data-theme", "dark")
            ico.textContent = "dark_mode"
            break;
    }
    return theme
}
function loadTheme()
{
    let theme = localStorage.getItem("theme");
    switchTheme(theme);
}
function saveTheme(themeName)
{
    localStorage.setItem("theme", themeName)
}




buttonImgTheme.addEventListener("click", function(e) {
    let theme = document.documentElement.getAttribute("data-theme");
    document.documentElement.removeAttribute("data-theme");
    let themeSave = switchTheme(theme);
    saveTheme(themeSave);
})


function loadPCR()
{
    let table = localStorage.getItem("tablePCR");
    let input = localStorage.getItem("inputPCR");
    if(table != null && input != null)
    {
        let tablePCR = document.querySelector("#popularityCurrencyRateTable");
        let inputPCR = document.querySelector("#popularityCurrencyRateInput");
        tablePCR.innerHTML = table;
        inputPCR.value = input;
    }
}
buttonPCR.addEventListener("click", function() {
    let nameCurrency = inputTextPCR.value.toUpperCase(); 
    let innerTable;
    if(namesOfCurrency[nameCurrency] != undefined)
    {
        console.log(requestCurrencyRate + nameCurrency)
        fetch(requestCurrencyRate + nameCurrency).then(promise => promise.json()).then(json => {
        let massiveJson = Object.entries(json.conversion_rates);
        
        innerTable = 
        `<thead><tr>
        <th>Номер</th>
        <th>Курс</th>
        <th>Валюта</th>
        </tr></thead><tbody>`
        for(let i = 1; i < massiveJson.length; i++)
        {
            let className;
            let name = massiveJson[i][0];
            let currency = massiveJson[i][1];

            if(currency >= 1)
            {
                className = "high";
            }
            else {className = "low";}
            innerTable += `<tr>
            <td>${i}</td>
            <td>${name}</td>
            <td class="${className}">${currency}</td>
            </tr>`
        }
        innerTable += "</tbody>"
        tablePCR.innerHTML = innerTable;

        localStorage.setItem("tablePCR", innerTable);
        localStorage.setItem("inputPCR", nameCurrency);
    })
    }
})



let currencyUAH = document.querySelector("#randomCurrencyRateTable")
let tableToUAH = document.querySelector("#currencyRateUAHTable")
document.addEventListener("DOMContentLoaded", function() {
    fetch(requestCurrencyRate + "UAH").then(promise => promise.json()).then(json => json.conversion_rates).then(rates => {

        let listValute = ["USD", "EUR", "JPY"];

        for(let item of listValute)
        {
            console.log(rates[item])
            tableToUAH.innerHTML += 
            `<tr>
            <td>${item}</td>
            <td>${rates[item]}</td>
            </tr>`
        }
    });
})

let selectFromValute = document.querySelector("#ConvertFromValuteSelect")
let selectToValute = document.querySelector("#ConvertToValuteSelect");

let inputFromValute = document.querySelector("#ConvertFromValuteInput")
let inputToValute = document.querySelector("#ConvertToValuteInput");

let buttonConverterValute = document.querySelector("#ConverterValuteButton");
fetch(requresCurrencyName).then(promise => promise.json()).then(json => {
    let massiveJson = Object.entries(json);
    for(let i = 0; i < massiveJson.length; i++)
    {
        let item = massiveJson[i][0];
        let html = `<option>${item}</option>`
        selectFromValute.innerHTML += html;
        selectToValute.innerHTML += html
    }
    loadConverter();
})

let infoValute;

buttonConverterValute.addEventListener("click", function() {
    fetch(requestCurrencyRate + selectFromValute.value).then(promise => promise.json()).then(json => {
        let rates = json.conversion_rates;

        let countFrom = inputFromValute.value;

        let toValute = selectToValute.value;

        let rateToValute = rates[toValute];

        inputToValute.value = (rateToValute * countFrom).toFixed(2);
        saveConverter();
    })
})

function saveConverter()
{
    let valueFrom = inputFromValute.value;
    let valueTo = inputToValute.value;

    let valuteFrom = selectFromValute.value;
    let valuteTo = selectToValute.value;

    localStorage.setItem("inputFromValute", valueFrom);
    localStorage.setItem("inputToValute", valueTo);

    localStorage.setItem("selectFromValute", valuteTo);
    localStorage.setItem("selectToValute", valuteFrom)
}
function loadConverter()
{
    let massiveData = [localStorage.getItem("inputFromValute"), 
        localStorage.getItem("inputToValute"), 
        localStorage.getItem("selectToValute"),
        localStorage.getItem("selectFromValute")]; 

    let isNotNull = true;

    for(let i in massiveData)
    {
        if(massiveData[i] == null)
        {
            return;
        }
    }
    
    let inputFrom = document.querySelector("#ConvertFromValuteInput");
    let inputTo = document.querySelector("#ConvertToValuteInput");
    let selectFrom = document.querySelector("#ConvertFromValuteSelect");
    let selectTo = document.querySelector("#ConvertToValuteSelect");
    
    inputFrom.value = massiveData[0];
    inputTo.value = massiveData[1];
    selectFrom.value = massiveData[2];
    selectTo.value = massiveData[3];
}


window.addEventListener("load", function() {
    loadTheme();
    loadPCR();
})