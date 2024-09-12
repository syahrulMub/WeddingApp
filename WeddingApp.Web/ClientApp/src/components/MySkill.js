import React from "react";
import { useState } from "react";


function MySkill() {
  const [data, setData] = useState();
return (
  <div>
    check coba
  </div>
)
}

function Squere({value, onSquereClick}){
  return (
    <div>
      <p>{value}</p>
      <button className="Squere" onClick={onSquereClick}>{value}</button>
    </div>
  )
}

function Board({xIsNext, squeres, onPlay}){
  function handleClick(i){
    if (calculateWinner(squeres) ||squeres[i]){
      return;
    }

    const winner = calculateWinner(squeres)
  }
}

function calculateWinner(squares){
  const lines = [
    [0, 1, 2],
    [3, 4, 5],
    [6, 7, 8],
    [0, 3, 6],
    [1, 4, 7],
    [2, 5, 8],
    [0, 4, 8],
    [2, 4, 6],
  ];
}
export default MySkill;
