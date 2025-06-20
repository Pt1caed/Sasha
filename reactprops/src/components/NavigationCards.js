import '../styles/NavigationCards/navigationCards.css'
export function NavigationCards()
{
    return (
        <section id="sectionNavigationCards">
            <p id="titleNavigationCards">ЗНАЙДИ ТЕ, ЩО ШУКАЄШ!</p>
            <div id="cardsText">
                <NavigationCard height="400px" width="781px" image="Collection.png" text="НАША НОВА КОЛЕКЦІЯ"></NavigationCard>
                <NavigationCard height="400px" width="678px" image="propositions.png" text="НАШІ НАЙКРАЩІ ПРОПОЗИЦІЇ"></NavigationCard>
            </div>
            <NavigationCard id="cardsNoText" height="364px" width="1480px" image="sofa.png" text={null}></NavigationCard >
        </section>
    )
}

function HorizontalButtonCard(props)
{
    return (
        <div id="HorizontalButton">
            <p id="textHorizontalButton">{props.text}</p>
            <span id="buttonHorizontalButton"></span>
        </div>
    )
}
function VerticalButtonCard()
{
    return (
    <div id="VerticalButton">
        <span id="buttonVerticalButton"></span>
    </div>
    )
}

function NavigationCard(props)
{
    const height = props.height;
    const width = props.width;

    const image = props.image;
    const text = props.text;
    const style = {
        backgroundImage: `url(/navigatonCards/${image})`,
        height: height,
        width: width,
        position: "relative"
    }

    let button;
    if(text != null)
    {
        button = <HorizontalButtonCard text={text}></HorizontalButtonCard>;
    }
    else {
        button = <VerticalButtonCard></VerticalButtonCard>
        console.log("HI")
    }
    return (
        <div style={style} id="navigationCard">
            {button}
        </div>
    )
}