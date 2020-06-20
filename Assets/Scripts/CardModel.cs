﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel {
    public string name;
    public int hp;
    public int at;
    public int cost;
    public Sprite icon;
    public bool isAlive = true;

    public CardModel(int cardId) {

        CardEntity cardEntity = Resources.Load<CardEntity>("CardList/Card" + cardId);
        name = cardEntity.name;
        hp = cardEntity.hp;
        at = cardEntity.at;
        cost = cardEntity.cost;
        icon = cardEntity.icon;
    }
}

