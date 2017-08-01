using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    // Starting Stats
    public float MAX_HEALTH;
    public float MAX_STAMINA;
    public float MAX_FOOD;
    public float MAX_WATER;
    public float MAX_PUNCH_DAMAGE;

    // Current Stats (set to "private set" to avoid negatives and overages)
    public float health { get; private set; }
    public float stamina { get; private set; }
    public float food { get; private set; }
    public float water { get; private set; }

    public void hit(int damage)
    {
        health -= damage;
        health = (health < 0) ? 0 : health;
    }

    public void heal(int amount)
    {
        hit(-amount);
        health = (health > MAX_HEALTH) ? MAX_HEALTH : health;
    }

    public void eat(int amount)
    {
        food += amount;
        food = (food > MAX_FOOD) ? MAX_FOOD : food;
    }

    public void drink(int amount)
    {
        water += amount;
        water = (water > MAX_WATER) ? MAX_WATER : water;
    }

}
