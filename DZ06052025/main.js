function StatisticWord() //1
{

    let str = "hello 123... %32 ";

    let ch = 0, dig = 0, other = 0;
    
    for (let i in str) {
        if (str[i] >= 0 && str[i] <= 9) {
            dig++;
        }
        else if((str[i]>='A' && str[i]<='Z')||(str[i]>='a' && str[i]<='z'))
        {
            ch++;
        }
        else{
            other++;
        }
    }
    
    document.writeln(`Количество букв = ${ch.toString().fontcolor("red")}<br>`);
    document.writeln(`Количество цифр = ${dig.toString().fontcolor("red")}<br>`);
    document.writeln(`Количество других знаков = ${other.toString().fontcolor("red")}<br>`);
}
function FromNumToText() //2
{
    massiveNumbers = ["один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"];
    massiveTens = ["десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто"];
    let num = parseInt(prompt("Введите число:"))
    if(num == undefined) { return; }
    let numStr = num + "";

    let numStroke = massiveTens[parseInt(numStr[0])] + " " + massiveNumbers[parseInt(numStr[1])];
    document.writeln(numStroke);
}
function ReverseLetterCase() //3
{
    let text = prompt("Введите слово: ")
    let text1 = text.split("")

    for(let i in text1)
    {
        if(text1[i] >= 'A' && text1[i] <= 'Z')
        {
            text1[i] = text1[i].toLowerCase()
        }
        else if(text1[i] >= 'a' && text1[i] <= 'z')
        {
            text1[i] = text1[i].toUpperCase()
        }
        else if(text1[i] == '-')
        {
            text1[i] = '_';
        }
    }
    text = text1.join("")
    document.writeln(text)
}
function FromDashToCamel() //4
{
    let text = prompt("Введите тег CSS: ")
    let textColl = text.split("")
    let index = textColl.indexOf('-')
    if(index != -1 && index != 0)
    {
        textColl.splice(index, 1)
        textColl[index + 1] = textColl[index + 1].toUpperCase() 
        text = textColl.join("")
        document.writeln(text)
    }
}
function FromWordsToAbbreviation() //5
{
    let text = prompt("Ввведите текст:")
    let textColl = text.split(" ")
    
    let text1 = []
    for(let i in textColl)
    {
        text1.push(textColl[i][0].toUpperCase())
    }
    document.writeln(text1.join(""))  
}
function LongStroke() //6
{
    let massiveStrokes = []
    for(let i in arguments)
    {
        massiveStrokes.push(arguments[i])
    }
    let stroke = massiveStrokes.join("")
    document.writeln(stroke)
}
function TestLongStroke() //6
{
    LongStroke("hello", "bye", "bye1", "privet", "goodbye")
}
function Calculator() //7
{
    let divide = function(num1, num2)
    {
        if(num2 == 0)
        {
            return;
        }
        return num1/num2
    }

    let num1 = parseFloat(prompt("Первое число: "))
    let num2 = parseFloat(prompt("Второе число: "))
    let operator = prompt("Оператор: ")
    let result
    switch (operator)
    {
        case "+":
            result = num1 + num2
            break;
        case "-":
            result = num1 - num2
            break;
        case "*":
            result = num1 * num2
            break;
        case "/":
            result = divide(num1, num2)
            break;
        default:
            result = "Error"
    }
    document.writeln(result)
}
function urlInfo() //8
{
    let url = prompt("url: ")

    let url1 = url.split("//")
    let second = url1[1]
    let index = second.indexOf("/")

    let protocol = url1[0]
    let domen = second.slice(0, index)
    let path = second.slice(index, second.length)
    document.writeln(`протоколо: ${protocol} <br> домен: ${domen} <br> путь: ${path}`)

}
function SplitStroke()//9
{
    let stroke = prompt("строка: ")
    let separator = prompt("сепаратор: ")
    let coll = []

    let indexStart = 0;
    for(let i = 0; i < stroke.length - separator.length; i++)
    {
        let indexSeparator = separator.length
        if(stroke.slice(i, i + indexSeparator) == separator)
        {
            let elem = stroke.slice(indexStart, i)
            coll.push(elem)
            indexStart = i+indexSeparator;
        }
    }
    let a = stroke.slice(indexStart, stroke.length)
    coll.push(a)
    document.writeln(coll)
}
function TemplateStroke(stroke) //10
{
    let stroke1 = stroke + ""
    for(let i = 1; i < arguments.length; i++)
    {
        stroke1 = stroke1.replaceAll(`%${i}`, arguments[i])
    }
    document.writeln(stroke1)
}

function CheckTemplateStroke() //10
{
    TemplateStroke("hello %1 %2", "privet", "poka")
}