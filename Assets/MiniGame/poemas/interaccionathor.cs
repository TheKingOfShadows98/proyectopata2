using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaccionathor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            eventinador.events.OnActivate();
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        eventinador.events.OnActivate();
        Destroy(gameObject);
    }
    // Start is called before the first frame update

}
