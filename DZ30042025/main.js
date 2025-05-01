// 1
function InfoUser()
{
    var firstname, surname, gender, age, email
    do
    {
    
        firstname = prompt("Введите имя: ");
        surname = prompt("Введите фамилию: ");
        gender = (prompt("Введите пол(1/0 - мужской/женский): "))
        age = parseInt(prompt("Введите возраст: "))
        email = prompt("Введите почту: ")
        
        if(gender == true)
        {
            gender = "мужской"
        }
        else { gender = "женский" }
    } while(!confirm(`Имя: ${firstname}\n${surname}\n${gender}\n${age}\n${email}\n\nВсе верно?`))
    
    document.writeln(`Спасибо за предоставленную информацию! Вот, что вы нам написали:
        <p>${firstname}</p><p>${surname}</p><p>${gender}</p><p>${age}</p><p>${email}</p>`)
}

// 2
function SumMassive(massive)
{
    if(!Array.isArray(massive) && typeof(massive[0]) != "number")
    {
        return -1;
    }
    sum = 0; 
    for(let i = 0; i < massive.length; i++)
    {
        sum += massive[i]
    }
    return sum;
}

function LuckyTicket()
{
    var ticket = "", ticketIsLuckyString = "", ticketIsLuckyString1 = "";
    
    while(true)
    {
        ticket = prompt("Введите счастливый билет(минимум 6-ти значное число и парное)") 
        document.writeln(ticket.length)
        if(ticket.length < 6 || ticket.length % 2 != 0)
        {
            confirm("Неправильный билет!")
            continue;
        }
        var sum = SumMassive([...ticket.slice(0, ticket.length / 2)].map(Number))
        var sum1 = SumMassive([...ticket.slice(ticket.length / 2, ticket.length)].map(Number))
        if(sum == sum1)
        {
            ticketIsLuckyString = (`<p> Счастливый билет: ${ticket}</p>`)
            ticketIsLuckyString1 = "Счастливый билет! Ура!"
        }
        else
        {
            ticketIsLuckyString = (`<p>Не Счастливый билет: ${ticket}</p>`)
            ticketIsLuckyString1 = "Не счастливый билет("
        }
        confirm(ticketIsLuckyString1)
        document.writeln(ticketIsLuckyString)

    }
}
// 3

function GuessRandomNumber()
{
    let min = 0;
    let max = 100;
    let random = parseInt(Math.random() * max)
    while(true)
    {
        let number = parseInt(prompt(`Введите число(${min}-${max}): `))
        var isNum = number <= 100 && number >= 0 
        if(random < number && isNum && number < max)
        {
            max = number - 1
        }
        else if(random > number && isNum && number > min)
        {
            min = number + 1
        }
        else if(random == number)
        {
            confirm("Вы угадали!")
            break;
        }

    }
}


// InfoUser() // 1 задание
// LuckyTicket() // 2 задание. Я сделал не только для 6-ти значных чисел, а для любых, но парных
// GuessRandomNumber() // 3 задание