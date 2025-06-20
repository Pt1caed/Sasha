import '../styles/Menu/Menu.css' 
import '../styles/Menu/Hashtags.css'
import '../styles/Menu/Navigator.css'
import '../styles/Menu/SearchBar.css'
import '../styles/Menu/FeaturedProducts.css'


export function Menu()
{
    return (
    <header>
        <Hashtags></Hashtags>
        <Navigator></Navigator>
        <SearchBar></SearchBar>
        <HugeText></HugeText>
        <FeaturedProducts></FeaturedProducts>
    </header>
    )
}


function CreateHashtags()
{
    const uniqueHashtags = [ "#buynow", "#вседлядому", "#швидкотазручно"];
    let Hashtags = [];

    for(let i = 0; i < 6; i++)
    {
        for(let j = 0; j < uniqueHashtags.length; j++)
        {
            Hashtags.push(<p>{uniqueHashtags[j]}</p>)
        }
    }
    return Hashtags
}
export function Hashtags()
{  

    const hashtags = CreateHashtags();
    return (
        <span id="backgroundHashtags">
            <span id="Hashtags">
                {hashtags}
            </span>
        </span>
    )
}

function ButtonMenu()
{
    return (<span id="buttonMenu">
                <span>
                    <img src="/navigator/menuSymbol.png" alt=""></img>
                    <p>Меню</p>
                </span>
            </span>)
}
function Logo()
{
    return (
        <img id="logoNavigation" src="/navigator/logo.png" alt=""></img>
    )
}

function PartMenu(props)
{
    const path = `/navigator/${props.img}`;
    return (
        <span id="partMenu">
            <img src={path} alt="" id="partMenuImg"></img>
            <a id="partMenuA" href='/'>{props.text}</a>
        </span>
    )
}
function PartsLeftSide()
{
    return (
        <div id="leftSide">
            <a href='/'>Товари</a>
            <a href='/'>Кімнати</a>
            <a href='/'>Дизайн</a>
        </div>
    )
}
function PartsRightSide()
{
    return (
        <div id="rightSide">
            <PartMenu img="gpsImage.png" text="Київ"></PartMenu>
            <PartMenu img="people.png" text="Привіт! Увійдіть в систему"></PartMenu>
            <div id="storeFavorite">
                <PartMenu img="store.png"></PartMenu>
                <PartMenu img="heart.png"></PartMenu>
            </div>
        </div>
    )
}
function Navigator()
{
    return (
        <div id="navigator">
            <div id="leftSide">
                <ButtonMenu></ButtonMenu>
                <Logo></Logo>
                <PartsLeftSide></PartsLeftSide>
            </div>
            <div id="rightSide">
                <PartsRightSide></PartsRightSide>
            </div>
        </div>
    )
}
function SearchBar()
{
    return (
        <div id="searchBar">
            <span></span>
            <input placeholder='Пошук
            '></input>
        </div>
    )
}
function HugeText()
{
    return <h1 id="hugeText">ВСЕ ДЛЯ ДОМУ</h1>
}

function FeaturedProduct(props)
{
    let path = "/featuredProducts/" + props.img
    return (
        <div id="featuredProduct">
            <img src={path} alt="featured product"></img>
            <span id="topFeaturedProduct">TOP</span>
            <div id="textsFeaturedProduct">
                <p id="titleFeaturedProduct">{props.title}</p>
                <p id="descriptionFeaturedProduct">{props.description}</p>
                <p id="costFeaturedProduct">{props.cost}</p>
            </div>
        </div>
    )
}
function FeaturedProducts()
{
    let description = "спальна кімната..."
    return (
        <div id="fullFeaturedProducts">
            <button id="createAccountButton">СТВОРИТИ АКАУНТ ТА ПОЧАТИ!</button>
            <button id="catalogButton">КАТАЛОГ <span id="arrowDown">    </span></button>
            <div id="featuredProducts">
                <FeaturedProduct title="ПОДУШКИ" description={description} cost="12$" img="pillows.png"></FeaturedProduct>
                <FeaturedProduct title="КОВДРА" description={description} cost="30$" img="blanket.png"></FeaturedProduct>
                <FeaturedProduct title="ЛІЖКО" description={description} cost="414$" img="bed.png"></FeaturedProduct>
            </div>
            <p id="descriptionFullFeatured">ЛОВИ МОМЕНТ | <b>Знижки до 60%</b> на вибрані категорії товарів!</p>
        </div>
    )
}