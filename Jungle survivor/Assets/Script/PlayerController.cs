using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fuerzaMovimiento,horizontal,fuerzasalto;    
    public LayerMask piso;
    private void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(horizontal != 0){
            transform.Translate(Vector3.right*horizontal *fuerzaMovimiento * Time.deltaTime);
        }
        Debug.DrawRay(transform.position,Vector3.down, Color.red, 0.1f);
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            //if(Physics2D.Raycast(transform.position,Vector2.down, 1f, piso)){                
                GetComponent<Rigidbody2D>().velocity = Vector2.up*fuerzasalto;
                Debug.Log("hit");
            //}
        }
    }
}
