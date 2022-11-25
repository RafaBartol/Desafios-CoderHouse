using UnityEngine;

public class Guerrero : Clases
{
   public override void Attack()
   {
      Debug.Log("Ataque potenciado");
   }

   public void BasicAttack()
   {
      Debug.Log("Ataque BasIco");
   }
}
