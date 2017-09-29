﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour {
   public enum Name {BLACK, WHITE};//black goes first
    public Name playerName;
    public Board board;
    public Sideboard sideboard;
    public Kifu kifu;
    public Turns turns;
    public bool movingUpward;
    // Use this for initialization
	protected virtual void Start () {

	}

	// Update is called once per frame
	protected virtual void Update () {

	}

    protected virtual void TakeTurn(Piece piece, Move move){
        kifu.addMove(move);
        piece.makeMove(move);
        //promotion choice
        turns.passTurn();
    }
}
