using System;
public class HealthSystem
{
    public event EventHandler OnHealthChanged;
    private int health;
    private int maxHealth;
    public HealthSystem(int health)
    {
        this.health = health;
        maxHealth = health;
    }
    public int GetHealth() { return health; }
    public int GetMaxHealth() {  return maxHealth; }
    public float GetHealthPrecent() { return (float)health/maxHealth; }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) { health = 0; }
        if(OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
    public void Heal(int healAmount) 
    {
        health += healAmount;
        if(health > maxHealth) { health = maxHealth; }
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
}
