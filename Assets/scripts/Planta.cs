using UnityEngine;

public class Planta : MonoBehaviour
{
   int life = 3;
    public void TakeDamage(int damage)
    {
         life -= damage;
         if (life <= 0)
         {
              Destroy(gameObject);
         }
    }
}
