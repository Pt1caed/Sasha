import './otherPages.css'
import './newsOfSite.css'
import { Link } from "react-router-dom";

function news() {
    return [
        newsConstr("Пополнение ассортимента", "В нашем каталоге появились новые уникальные изделия, созданные с вниманием к деталям и стилю.", "/theBestCategory/bestkit1"),
        newsConstr("Ограниченный выпуск", "Добавлены редкие товары, доступные в ограниченном количестве. Идеально для тех, кто ценит эксклюзивность.", "/theBestCategory/bestkit4"),
        newsConstr("Тренды этого сезона", "Мы отобрали для вас самые актуальные товары, отражающие современные интерьерные тенденции.", "/theBestCategory/bestkit3"),
        newsConstr("Обновлён дизайн упаковки", "Теперь наши товары приходят к вам не только качественными, но и в стильной, подарочной упаковке.", "/newCategory/news2"),
        newsConstr("Выбор покупателей", "Мы собрали товары, которые получили наибольшее количество положительных отзывов — возможно, вы найдёте среди них и своё вдохновение.", "/newCategory/news4")
    ];
}


function newsConstr(title, text, path)
{
    return {title, text, path}
}

export function NewsOnMain()
{
    const newsOfSite = news();

    return (
        <div id="newsOfSite">
            <p id="newsTitle">Новости</p>
            {newsOfSite.map(element => (
                <Link id="news" to={element.path}>
                    <div id="divNews">
                        <p id="titleNews">{element.title}</p>
                        <p id="textNews">{element.text}</p>
                    </div>
                </Link>
            ))}
        </div>
    )
}