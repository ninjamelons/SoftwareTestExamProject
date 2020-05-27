
public abstract class Character
{
    //Properties
    public string Name { get; set; }
    public float MaxHp { get; set; }
    public float Damage { get; set; }
    public float CurrentHp { get; set; }

    //Abstract methods
    public abstract float Attack();
    public abstract void Defend();
    public abstract void Heal();
}
