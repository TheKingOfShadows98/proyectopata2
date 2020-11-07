using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Camera cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 campos = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(campos.x, campos.y, 0f);
        var a1 = new List<string>();
        a1.Add("AF");
        a1.AddRange({"F", "A"});
    }
}
