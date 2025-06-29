import { Outlet, Link } from "react-router-dom";
import './mainPage.css'
import { categories, products } from "./othePages";
import { useState } from "react";

export function MainPage(props)
{
    const [randomPage, setRandomPage] = useState("/")
    const allProducts = products(-1);
    const allCategories = categories("cat")

    function randomInteger(min, max) {
        let rand = min + Math.random() * (max + 1 - min);
        return Math.floor(rand);
    }
    function handleRandomPage()
    {
        const randomIndexProducts = randomInteger(0, allProducts.length - 1);
        const randomProduct = allProducts[randomIndexProducts];

        const randomCategory = allCategories[randomIndexProducts][1];

        const path = `/${randomCategory}/${randomProduct.nameImg}${randomInteger(1, randomProduct.products.length)}`
        setRandomPage(path)
        window.location.href = path;
    }

    return (
        <>
            <header>
                <nav id="navBar">
                    <Link to="/">Главная страница</Link>
                    <Link onClick={handleRandomPage}>Случайная страница</Link>
                    <hr></hr>
                </nav>
            </header>

            <Outlet />
        </>
    )
}

