using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private bool Active;
    [SerializeField] private float Speed;

    [SerializeField] private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
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
            //transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime, 0f));
            rb2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * Speed, 0f) * Time.deltaTime;
        }
    }
}
