using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("���ʳt��")] [Range(0, 10)]
    public float speed = 3.5f;
    [Range(0, 500)] [Header("�����O")]
    public int attack = 100;
    [Header("��q")] [Range(0, 5000)]
    public float HP = 350F;
    [Header("�������~")]
    [Tooltip("�C������")]
    public bool itemdrop = false;
    [Header("�������~���v")]
    [Range(0, 1)]
    public float itemdropbrobaility = 1;
    [Header("�������~����")]  [Tooltip("�o�̬O�������Ħs���")]
    public AudioClip auddrop;
    AudioSource aud;
    Rigidbody2D rig;
    Animator ani;
    
    
    
}
