
import './formModal.css'

import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import Form from 'react-bootstrap/Form';
import { useState } from 'react';
import { FormLabel, ModalTitle } from 'react-bootstrap';

export function FormModal()
{
    const formRegistr = <Modal.Body>
                    <Form.Group>
                        <Form.Control type="login" placeholder="Ім'я"></Form.Control>
                        <Form.Control type="email" placeholder='Електронна адреса'></Form.Control>
                        <Form.Control type="password" placeholder='Пароль'></Form.Control>
                    </Form.Group>
                    <Button>Увійти</Button>
                    <FormLabel>Реєструючись — Ви автоматично погоджуєтесь з політикою конфіденційності та умови використання</FormLabel>
                    <Button id="buttonGoogle" variant='outline-light'><img src="/google.webp" alt=""></img>Авторизуватись через Google</Button>
                </Modal.Body>
    const formRegistrLabel = "Регістрація";

    const formAuth = <Modal.Body>
                    <Form.Group>
                        <Form.Control type="login" placeholder="Ім'я"></Form.Control>
                        <Form.Control type="password" placeholder='Пароль'></Form.Control>
                    </Form.Group>
                    <Button>Увійти</Button>
                    <FormLabel>Забули пароль?</FormLabel>
                    <Button id="buttonGoogle" variant='outline-light'><img src="/google.webp" alt=""></img>Авторизуватись через Google</Button>
                </Modal.Body>
    const formAuthLabel = "Авторизація"
                
    const [form, setForm] = useState(formAuth);
    const [labelForm, setLabelForm] = useState(formAuthLabel);
    const [isOpen, setIsOpen] = useState(false);
    const [styleBorder, setStyleBorder] = useState({style1: {borderBottom: "2px solid black", fontWeight: "bold"}, style2: {borderBottom: "none",}})
    function handleStyle(e)
    {
        if(e === "style1")
        {
            setStyleBorder(prevState => ({
                ...prevState,
                style1: {borderBottom: "2px solid black", fontWeight: "bold"},
                style2: {borderBottom: "none"}
            }))
            setForm(formAuth);
            setLabelForm(formAuthLabel);
        }
        else {
            setStyleBorder(prevState => ({
                ...prevState,
                style2: {borderBottom: "2px solid black", fontWeight: "bold"},
                style1: {borderBottom: "none"}
            }))
            setForm(formRegistr);
            setLabelForm(formRegistrLabel);
        }
    }

    
    return (
        <>
            <Button onClick={() => setIsOpen(true)}>Click</Button>


            <Modal show={isOpen} onHide={() => setIsOpen(false)}>
                <Modal.Header style={{flexDirection: "column-reverse"}} closeButton>
                    <div id="divButtonsAuthorization">
                        <Button style={styleBorder.style1} onClick={() => handleStyle("style1")}>Вхід</Button>
                        <Button style={styleBorder.style2} onClick={() => handleStyle("style2")}>Реєстрація</Button>
                    </div>
                    <ModalTitle id="mainModalTitle">{labelForm}</ModalTitle>
                </Modal.Header>
                    {form}
                <Modal.Footer>

                </Modal.Footer>
            </Modal>
        </>
    )
}