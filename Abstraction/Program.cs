// Abstract class defining the common interface for all weapons
public abstract class Weapon
{
    protected string name;
    protected int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    // Abstract method representing the attack action
    public abstract void Attack();

    public string GetName()
    {
        return name;
    }
}

// Concrete implementation of Sword
public class Sword : Weapon
{
    public Sword() : base("Sword", 20)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"Swinging the sword! - Damage: {damage}");
    }
}

// Concrete implementation of Axe
public class Axe : Weapon
{
    public Axe() : base("Axe", 25)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"Swinging the axe! - Damage: {damage}");
    }
}

// Concrete implementation of Bow
public class Bow : Weapon
{
    public Bow() : base("Bow", 15)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"Shooting arrows with the bow! - Damage: {damage}");
    }
}

// Knight class interacting with weapons through abstraction
public class Knight
{
    private string name;
    private Weapon weapon;

    public Knight(string name, Weapon weapon)
    {
        this.name = name;
        this.weapon = weapon;
    }

    // Method to perform an attack using the current weapon
    public void Attack()
    {
        Console.WriteLine($"{name} is attacking with {weapon.GetName()}!");
        weapon.Attack(); // Abstraction: Knight interacts with weapons through the common Weapon interface
    }

    // Method to change the equipped weapon
    public void EquipWeapon(Weapon newWeapon)
    {
        weapon = newWeapon;
        Console.WriteLine($"{name} has equipped {weapon.GetName()}!");
    }
}

class Program
{
    static void Main()
    {
        // Creating different types of weapons
        Sword sword = new Sword();
        Axe axe = new Axe();
        Bow bow = new Bow();

        // Creating a knight with a sword
        Knight knight = new Knight("Sir Lancelot", sword);

        // Knight attacks with the sword
        knight.Attack();

        // Knight equips an axe
        knight.EquipWeapon(axe);

        // Knight attacks with the axe
        knight.Attack();

        // Knight equips a bow
        knight.EquipWeapon(bow);

        // Knight attacks with the bow
        knight.Attack();
    }
}
