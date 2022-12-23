  using UnityEngine;

public class Enemix : MonoBehaviour
{
  public float enemixLife = 100f;
    
    //public static float dead_Chackra = 100f;
    public GameObject burst;// explosion
     public GameObject blood;// sangre
     


    void Update()
    {
        if(enemixLife <=0)// si la vida del enemigo es menor a 0 (si muere)
        {
          
            HudGame.dead_Chackra++;  // cada vez que muere un Enemigo 
            //ingreso a la variable entera dead_Chackra aumento el valor en 1

            Destroy(gameObject);
           // GameObject exp = Instantiate(burst,transform.position,transform.rotation);
            //Destroy(exp,3f);// que se destruya la explosión despues de este tiempo
            //GameObject s = Instantiate(blood,transform.position,transform.rotation);
            //Destroy(s,3f); // lo mismo con la sangre
        }
    }
}
