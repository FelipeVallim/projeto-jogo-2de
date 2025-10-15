using UnityEngine;

public class coligioncontroler : MonoBehaviour
{
    [SerializeField] playercontroler playerControler;
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Planta")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Planta planta = other.gameObject.GetComponent<Planta>();
                if (planta != null)
                {
                    Debug.Log("Atacando planta");
                    playerControler.attack(planta);
                }



            }
        }
    }
}
