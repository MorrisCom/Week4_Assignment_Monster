using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度")] [Range(0, 10)]
    public float speed = 3.5f;
    [Range(0, 500)] [Header("攻擊力")]
    public int attack = 100;
    [Header("血量")] [Range(0, 5000)]
    public float HP = 350F;
    [Header("掉落物品")]
    [Tooltip("遊戲物件")]
    public bool itemdrop = false;
    [Header("掉落物品機率")]
    [Range(0, 1)]
    public float itemdropbrobaility = 1;
    [Header("掉落物品音效")]  [Tooltip("這裡是掉落音效存放區")]
    public AudioClip auddrop;
    AudioSource aud;
    Rigidbody2D rig;
    Animator ani;
    
    
    
}
