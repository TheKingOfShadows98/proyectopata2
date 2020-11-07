using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameController : MonoBehaviour
{

    [SerializeField] Transform MaxPos;
    [SerializeField] Transform MinPos;

    public static MiniGameController controller;

    private void Awake()
    {
        controller = this;
    }

    private void OnDrawGizmos()
    {
        if(MaxPos != null && MinPos != null)
        {
            Gizmos.DrawLine(new Vector3(MaxPos.position.x, MinPos.position.y, 0f), MaxPos.position);
            Gizmos.DrawLine(MaxPos.position, new Vector3(MinPos.position.x, MaxPos.position.y, 0f));
            Gizmos.DrawLine(new Vector3(MinPos.position.x, MaxPos.position.y, 0f), MinPos.position);
            Gizmos.DrawLine(MinPos.position, new Vector3(MaxPos.position.x, MinPos.position.y, 0f));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


}
