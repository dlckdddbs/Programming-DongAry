using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] private short hp;
    public Vector2 monsterRespawnPostion;
    public Slider HPbar;
    // Start is called before the first frame update

    public short HP
    {
        get { return hp; }
        set
        {
            hp = value;
            HPbar.value = hp;
            Debug.Log(hp);
            if (hp < 0)
                gameObject.SetActive(false);  
        }
    }

    private void RestHPbar()
    {
        HPbar.maxValue = hp;
        HPbar.value = hp;
    }

    void Start()
    {
        RestHPbar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
