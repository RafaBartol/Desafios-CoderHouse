using UnityEngine;

public class TestingHerencia : MonoBehaviour
{
    void Start()
    {
        Clases warrior = new Clases();
        warrior.life = 20;
        warrior.name = "Warrior";
        warrior.damage = 20f;
        warrior.Information();
        warrior.Attack();

        Clases archer = new Clases();
        archer.life = 10;
        archer.name = "Archer";
        archer.damage = 25f;
        archer.Information();

        Guerrero guerrero = new Guerrero();
        guerrero.life = 50;
        guerrero.name = "Guerrero";
        guerrero.damage = 45f;
        guerrero.Information();
        guerrero.BasicAttack();
        guerrero.Attack();
    }
}
