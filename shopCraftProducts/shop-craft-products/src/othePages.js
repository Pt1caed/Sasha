import { Link } from "react-router-dom";
import './otherPages.css'
import { NewsOnMain } from "./newsOfSite";

function ProductCard(props)
{
    return (
        <div id="productCard">
            <img src={props.img} alt=""></img>
            <div id="divProductCard">
                <p id="titleProductCard">{props.title}</p>
                <p id="costProductCard">{props.cost}</p>
                <Link id="linkProductCard" to={props.path}>Перейти</Link>
            </div>
        </div>
    )
}
function product(title, desc, info, cost)
{
  return {
    title: title,
    desc: desc,
    info: info,
    cost: cost,
  }
}
function category(title, name, element)
{
    return {title, name, element}
}
function DataProducts(products, nameImg)
{
    return {products, nameImg};
}

export function products(indexProduct) {
    const BaseDataProducts = 
    [
        DataProducts([
        product(
            "Ваза для колосков",
            "Изящная стеклянная ваза, идеально подходящая для сухоцветов и колосков.",
            "Высота: 25 см, Материал: стекло, Цвет: прозрачный",
            "$40"
        ),
        product(
            "Настенная каменная ваза",
            "Оригинальное настенное украшение с нишей для цветов или декора.",
            "Материал: искусственный камень, Крепление: настенное, Вес: 1.2 кг",
            "$83"
        ),
        product(
            "Кактус",
            "Миниатюрный декоративный кактус в горшке, не требует ухода.",
            "Материал: пластик и керамика, Высота: 12 см",
            "$15"
        ),
        product(
            "Гламурно чёрная ваза",
            "Стильная ваза с глянцевым чёрным покрытием для современного интерьера.",
            "Материал: керамика, Высота: 30 см, Цвет: чёрный",
            "$60"
        ),
        product(
            "Мини-деревья на подставке",
            "Декоративная композиция из трёх мини-деревьев на деревянной подставке.",
            "Материалы: дерево и текстиль, Размер: 20×10×15 см",
            "$73"
        ),
        product(
            "Глобус",
            "Классический настольный глобус для декора или обучения.",
            "Диаметр: 20 см, Язык: русский, Основание: металл/пластик",
            "$45"
        )
        ],"bestkit"),

        DataProducts([
        product(
            "Ретро белые окна",
            "Элегантные деревянные окна в винтажном стиле, идеально подойдут для уютного интерьера.",
            "Материал: дерево, Цвет: белый, Размер: 120×100 см",
            "$120"
        ),
        product(
            "Дизайнерская лампа накаливания",
            "Современная лампа с тёплым свечением и уникальным дизайном для атмосферного освещения.",
            "Мощность: 40 Вт, Тип цоколя: E27, Материал: стекло и металл",
            "$55"
        ),
        product(
            "Белый стол для всей семьи",
            "Просторный и прочный стол в минималистичном стиле, отлично подходит для обедов и встреч.",
            "Материал: МДФ и металл, Размер: 180×90×75 см, Цвет: белый",
            "$230"
        ),
        product(
            "Полка для разных вещей",
            "Универсальная настенная полка для книг, декора и повседневных мелочей.",
            "Материал: дерево, Количество уровней: 3, Размер: 80×20×60 см",
            "$67"
        )
        ], "news"),
    ]
    if(indexProduct === -1)
    {
        return BaseDataProducts;
    }
    return BaseDataProducts[indexProduct]
} // база данных товаров

export function categories(isList)
{
    const listTitleCategory = 
    [
        ["ЛУЧШИЕ ТОВАРЫ", "theBestCategory"],
        ["НОВИНКИ", "newCategory"],
    ];
    
    if(isList != null)
    {
        return listTitleCategory;
    }
    let listCategories = [];
    let i = 0;
    listTitleCategory.forEach(element => {
        listCategories.push(category(element[0], element[1], <ProductsPage index={i} category={element[1]}></ProductsPage>))
        i++;
    })
    return listCategories;
}

export function ProductsPage(props)
{
      const imageGroup = products(props.index);
    if(imageGroup.nameImg === "news")
    {
        console.log(imageGroup.products)
    }
    return (
        <div id="productsPage">
            {imageGroup.products.map((element, i) => (
                <ProductCard title={element.title} cost={element.cost} img={`/ProductImages/${imageGroup.nameImg}${i+1}.png`} path={`/${props.category}/${imageGroup.nameImg}${i+1}`}></ProductCard>
            ))}
        </div>
    )
}

export function IndexPage()
{
    return <section>
        <Categories />
        <NewsOnMain />
    </section>
}

function Categories()
{
    const infoCategories = categories();
    return (
        <div id="categoriesPage">
            <p id="categoriesTitle">Категории</p>
            {infoCategories.map(element => (
                
                    <Link to={`/${element.name}`}>
                        <div id="categoryCard">
                            <p>{element.title}</p>
                            <img src={`/CategoriesImages/${element.name}.png`} alt=""></img>
                        </div>
                    </Link>
            ))}
        </div>
    )
}
export function ProductPage(props)
{
    return <div id="productPage">
        <img src={props.img} alt=""></img>
        <p id="titleProductPage">{props.title}</p>
        <p id="descProductPage">{props.desc}</p>
        <p id="infoProductPage">{props.info}</p>
        <p id="costProductPage">{props.cost}</p>
    </div>
}

export function PageNotFound()
{
    return <div id="divPageNotFound">
        <img src="/pageNotFound.png" alt=""></img>
        <p>Страница не найдена...</p>
    </div>
}