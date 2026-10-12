using System;
using UnityEngine;

class Character
{
    public String Name;
    public int Health;
    public int Damage;
    
    public void Attack(Character target)
    {
        if (target.Health <= 0)
        {
            Debug.Log(target.Name + " is already defeated!");
            return;
        }
        target.Health -= this.Damage;
        Debug.Log(this.Name + " attacked " + target.Name + " for " + this.Damage + " damage.");
        
        if (target.Health <= 0)
        {
            Debug.Log(target.Name + " has been defeated!");
        }
        else
        {
            Debug.Log(target.Name + " has " + target.Health + " health remaining.");
        }
    }
}

class Program
{
    static void Main()
    {
        Character player = new Character();
        
        player.Name = "Elon";
        player.Health = 100;
        player.Damage = 20;
        

        Debug.Log("Player Name: " + player.Name); 
        Debug.Log("Player Health: " + player.Health);
        
        Character enemy = new Character();
        enemy.Name = "Zombie";
        enemy.Health = 65;
        enemy.Damage = 15;

        while (player.Health > 0 && enemy.Health > 0)
        {
            enemy.Attack(player);
            if (player.Health <= 0)
            {
                Debug.Log(player.Name + " has been defeated!");
                break;
            }
            player.Attack(enemy);
            if (enemy.Health <= 0)
            {
                Debug.Log(enemy.Name + " has been defeated!");
                break;
            }
        }
    }
}