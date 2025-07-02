import React from 'react';
import logo from '../../logo.svg';
import './style.css';

export function Avatar (props) 
{

  return (
      <div className="avatar__container">
      <div className="avatar__header">
        <img src={logo} className="avatar__image" alt="user avatar" />
        <p>{props.name}</p>
      </div>
      <div className="avatar__main">
        <p>{props.position ? props.position : 'not set'}</p>
      </div>
      <div className="avatar__footer">
        <p>Twitter: {props.twitter}</p>
        <p>Facebook: {props.facebook}</p>
      </div>
    </div>
   
  );
}

