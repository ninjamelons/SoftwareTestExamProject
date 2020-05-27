
public abstract class Character
{
    //Properties
    protected string Name { get; set; }
    protected int Health { get; set; }
    protected int Damage { get; set; }

    //Abstract methods
    public abstract void Attack();
    public abstract void Defend();
    public abstract void Heal();
}
