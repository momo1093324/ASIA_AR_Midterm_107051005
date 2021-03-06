﻿using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Girl1")]
   public Transform girl1;

    [Header("Girl2")]
    public Transform girl2;
   
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;

    [Header("Girl1旋轉"),Range(0.1f,20f)]
    public float turn=1.5f;

  [Header("Girl1縮放"), Range(0f, 5f)]
    public float size = 0.3f;

    [Header("女孩1動畫元件")]
    public Animator aniGril01;
    [Header("女孩2動畫元件")]
    public Animator aniGril02;
    //
    private void Start()
    {
        print("開始事件處理中");
    }
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        girl1.Rotate(0, joystick.Horizontal*turn, 0);
        girl2.Rotate(0, joystick.Horizontal * turn, 0);

        girl1.localScale+= new Vector3(1, 1, 1) * joystick.Vertical*size;
        girl2.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;

        girl1.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(girl1.localScale.x, 0.5f, 3.5f);
        girl2.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(girl2.localScale.x, 0.5f, 3.5f);
    }
    public void Playanimation(string aniName)
    {
        print(aniName);
       aniGril01.SetTrigger(aniName);
     aniGril02.SetTrigger(aniName);
    }

}
