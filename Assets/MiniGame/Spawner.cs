using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Timer
{
    public float tiempo { get; set; }

    public bool terminado()
    {
        if(tiempo < 0)
        {
            return true;
        }
        tiempo -= Time.deltaTime;
        return false;
    }

}

public class Spawner : MonoBehaviour
{
    [SerializeField] float Area;
    [SerializeField] bool Active;
    [SerializeField] float intervalo;
    [SerializeField] List<GameObject> Prefabs = new List<GameObject>();
    [SerializeField] Timer timer = new Timer();

    // Start is called before the first frame update
    private void OnDrawGizmos()
    {
        Debug.DrawLine(new Vector2(transform.position.x - Area, transform.position.y), new Vector2(transform.position.x + Area, transform.position.y));
    }
    void Start()
    {
        timer.tiempo = intervalo;
    }
    public void Activar( bool _activar)
    {
        Active = _activar;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (timer.terminado() && Active)
        {
            timer.tiempo = intervalo;
            int objecto = Random.Range(0, Prefabs.Count);
            float _area = transform.position.x + Random.Range(-Area, Area);
            var nuevo_objeto = Instantiate(Prefabs[objecto]);
            nuevo_objeto.transform.parent = null;
            nuevo_objeto.transform.position = new Vector3(_area, transform.position.y, transform.position.z);

        }
    }
}
