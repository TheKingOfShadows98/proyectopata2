using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigsagEnemy : MonoBehaviour
{
    [SerializeField] bool Active;
    [SerializeField] float Vertical_speed;
    [SerializeField] float Horizontal_speed;
    [SerializeField] float Distancia;
    [SerializeField] float Target;
    [SerializeField] float mov = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Target = transform.position.x + (Distancia * mov);
    }

    void Activar( bool _activar)
    {
        Active = _activar;
    }



    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            HorizontalMove();
            VerticalMove();
        }
    }

    void VerticalMove()
    {
        transform.Translate(-transform.up * Vertical_speed * Time.deltaTime);
    }
    void HorizontalMove()
    {
        float distancia = Mathf.Abs(transform.position.x - Target);
        Debug.Log(distancia);
        if (distancia < 1.5f)
        {
            mov *= -1;
            Target = transform.position.x + (Distancia * mov);
        }
        Vector3 vel = new Vector3(Horizontal_speed * mov * Time.deltaTime, 0f,0f ); 
        transform.Translate(vel);

    }
}
