import React from "react";
import './Task1.css'
import Dialog from '@mui/material/Dialog'
import DialogTitle from '@mui/material/DialogTitle'
import DialogContent from '@mui/material/DialogContent'
import DialogContentText from '@mui/material/DialogContentText'
import DialogActions from '@mui/material/DialogActions'
import Button from '@mui/material/Button'
export function InfoRestaurant(props)
{
    const [restaurant, setRestaurant] = React.useState(null);
    const [editButtonStyle, setEditButtonStyle] = React.useState({display: "none"});
    const [applyButtonStyle, setApplyButtonStyle] = React.useState({display: "none"});
    const [inputStyle, editInputStyle] = React.useState({display: "none"});
    const [restaurantEditValues, setRestaurantEditValues] = React.useState({name: "", rating: "", address: "", typeKitchen: "",})

    const [dialogOpen, setDialogOpen] = React.useState(false);
    React.useEffect(() => {
        setRestaurant(props.rest)
    }, [1])

    function editRestaurant()
    {
        let display;
        if(inputStyle.display === "inline-block")
        {
            display = "none";
        }
        else 
        { 
            display = "inline-block" 
        }

        editInputStyle({display: display});
        setApplyButtonStyle({display: display})
    }
    function applyEditRestaurant()
    {
        let rest = restaurantEditValues;
        let dataZero = () => {
            setRestaurantEditValues(({name: "", rating: "", address: "", typeKitchen: "",}))}
        if(rest.name !== "" && rest.rating !== "" && rest.address !== "" && rest.typeKitchen !== "")
        {
            setRestaurant(prevState => ({...prevState, ...restaurantEditValues}))
            editRestaurant();
            dataZero();
        }
        else {
            setDialogOpen(true);
            dataZero();
        }
    }
    if(!restaurant)
    {
        return (<div></div>)
    }
    return (
        <section>
            <div id="restaurantDiv" onMouseEnter={() => {setEditButtonStyle({display: "inline-block"})}} onMouseLeave={() => {setEditButtonStyle({display: "none"})}}>
                <button id="editButton" style={editButtonStyle} onClick={editRestaurant}>Edit</button>
                <button id="applyButton" style={applyButtonStyle} onClick={applyEditRestaurant}>Apply</button>


                <div id="divRestaurantDiv">
                    <p>Имя ресторана: <b>{restaurant.name}</b></p>
                    <input style={inputStyle} onInput={(ev) => {setRestaurantEditValues(prevState => ({...prevState, name:ev.target.value}))}} value={restaurantEditValues.name}></input>
                </div>
                <div id="divRestaurantDiv">
                    <p>Рейтинг: <b>{restaurant.rating}</b></p>
                    <input style={inputStyle} onInput={(ev) => {setRestaurantEditValues(prevState => ({...prevState, rating:ev.target.value}))}} value={restaurantEditValues.rating}></input>
                </div>
                <div id="divRestaurantDiv">
                    <p>Адрес: <b>{restaurant.address}</b></p>
                    <input style={inputStyle} onInput={(ev) => {setRestaurantEditValues(prevState => ({...prevState, address:ev.target.value}))}} value={restaurantEditValues.address}></input>
                </div>
                <div id="divRestaurantDiv">
                    <p>Тип кухни: <b>{restaurant.typeKitchen}</b></p>
                    <input style={inputStyle} onInput={(ev) => {setRestaurantEditValues(prevState => ({...prevState, typeKitchen:ev.target.value}))}} value={restaurantEditValues.typeKitchen}></input>
                </div>
                <p>Изображение ресторана:</p>
                <img src={restaurant.img} alt="imgRestaurant"></img>

                
                <Dialog open={dialogOpen}>
                <DialogTitle>
                    Ошибка с веденными данными
                </DialogTitle>
                <DialogContent>
                    <DialogContentText>
                    Данные для сохранения введены неправильно, или же вообще не введены.
                    </DialogContentText>
                </DialogContent>
                <DialogActions>
                    <Button
                    color="primary"
                    onClick={() => {setDialogOpen(false)}}
                    >
                    Хорошо
                    </Button>
                </DialogActions>
                </Dialog>
            </div>
        </section>
        
    )
}