using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private bool Active;
    [SerializeField] private float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Activar( bool activado)
    {
        Active = activado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime, 0f));
        }
    }
}
