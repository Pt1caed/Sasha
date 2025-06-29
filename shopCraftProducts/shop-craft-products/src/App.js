import './App.css';
import { BrowserRouter, Route, Routes } from "react-router-dom"
import { MainPage } from './mainPage';
import { products, categories, IndexPage, ProductPage, PageNotFound } from './othePages';





function App() {
  const allCategories = categories();
  let allProductsRoutes = [];
  let i = 0;

  let j = 0;
  allCategories.forEach(category => {
    j = 0;
    let allProducts = products(i);
    allProducts.products.forEach(product => {
      allProductsRoutes.push(
      <Route 
        path={`${category.name}/${allProducts.nameImg}${j+1}`} 
        element={<ProductPage img={`/ProductImages/${allProducts.nameImg}${j+1}.png`} 
        title={product.title} 
        desc={product.desc} info={product.info} 
        cost={product.cost}/>}  
      />)
      j++;
    })
    i++;

  })
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<MainPage />}>
          <Route index element={<IndexPage />}></Route>

          {allCategories.map(category => (
            <Route path={`/${category.name}`} element={category.element}/>
          ))}
          {allProductsRoutes.map(route => route)}
          
          <Route path="*" element={<PageNotFound />}></Route>
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
