using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private bool Active;
    [SerializeField] private float Speed;
    [SerializeField] private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
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
            float Speedest = Speed * transform.localScale.x;
            float speedx = Input.GetAxisRaw("Horizontal") * Speedest;
            float speedy = Input.GetAxisRaw("Vertical") * Speedest;
            rig.velocity = new Vector2(speedx, speedy);
        }
    }
}
