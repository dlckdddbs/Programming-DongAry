using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrollbar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Monster;
    public Camera CM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float monstersize = Monster.GetComponent<SpriteRenderer>().size.y * 2;
        transform.position = CM.WorldToScreenPoint(new Vector2(Monster.transform.position.x, Monster.transform.position.y + monstersize));
    }
}
