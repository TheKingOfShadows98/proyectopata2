using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectMoveEnemy : MonoBehaviour
{
    [SerializeField] private bool Active;
    [SerializeField] private float Speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Activar(bool activado)
    {
        Active = activado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            Vector2 _speed_vector = transform.up * -1;
            _speed_vector *= Speed * Time.deltaTime;
            transform.Translate(_speed_vector);
        }
    }
}
