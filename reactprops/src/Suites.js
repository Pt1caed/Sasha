import './styles/Suites/Suites.css'
import React from 'react'
function makeSuitesPath(image, count)
{
    let path = `${image}`;
    let imagesNames = [];
    for(let i = 1; i <= count; i++)
    {
        imagesNames.push(`${path}${i}.png`)
    }
    return imagesNames;
}

export function Suite(props)
{
    let path = `/suites/${props.img}` ;
    let style = {
        backgroundImage: `url(${path})`,
    }
    return (
        <div id="suite" style={style}>
            <button>{props.nameSuite}</button>
        </div>
    )
}
export function Suites(props)
{
    const [translate, setTranslate] = React.useState({translate: "0px"});
    const [translateNum, setTranslateNum] = React.useState(0);
    const [opacityButtonBack, setOpacityButtonBack] = React.useState({opacity: 0, cursor:"auto"})
    let images = makeSuitesPath(props.nameImg, props.count);

    function changeTranslate(px)
    {
        setTranslateNum(prev => {
            const newTranslate = prev - px;
            isTranslateZero(newTranslate)
            setTranslate({ translate: `${newTranslate}px` });
            return newTranslate;
        });
    }
    function buttonScrollFront()
    {
        const widthDivs = 219 * images.length / -8;

        console.log(widthDivs)
        console.log(translateNum)
        if(translateNum > widthDivs)
        {
            changeTranslate(239)
        }
    }
    function buttonScrollBack()
    {
        if(translateNum !== 0)
        {
            changeTranslate(-239)
        }
    }
    function isTranslateZero(num)
    {
        if(num < 0)
        {
            setOpacityButtonBack({opacity: 1, cursor: "pointer"})
        }
        else {setOpacityButtonBack({opacity: 0, cursor: "auto"})}
    }

    return(
        <section id={props.id}>
            <div id="divSuiteDiv">
                <div id="suitesDiv">
                    <p>{props.title}</p>
                    <div id="suites" style={translate}>
                        {images.map(image => (
                            <Suite img={image} nameSuite="НАЗВА НАБОРУ"></Suite>
                        ))}
                    </div>
                </div>
                
            </div>
            
            <span onClick={buttonScrollFront} id="scrollButtonFront"></span>
            <span onClick={buttonScrollBack} id="scrollButtonBack" style={opacityButtonBack}>
            </span>
        </section>
    )
}