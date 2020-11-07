using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int Damage;
    [SerializeField] bool Active;
    [SerializeField] bool InstaKill;
    [SerializeField] float Altura_min;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, new Vector3(transform.position.x, Altura_min, transform.position.z));
        if(transform.position.y < Altura_min)
        {
            Destroy(gameObject);
        }
    }
}
