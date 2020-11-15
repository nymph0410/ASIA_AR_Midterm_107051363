using UnityEngine;

public class GameManger : MonoBehaviour
{
    [Header("羊")]
    public Transform sheep;

    [Header("企鵝")]
    public Transform penguin;

    [Header("虛擬搖桿")]
     public FixedJoystick joystick;

    [Header("旋轉速度"),Range(1.0f,20f)]
    public float turn = 1.5f;

    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;


        private void Start()
    {
        print("開始事件進行中");
    }

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        sheep.Rotate(0, joystick.Horizontal*turn,0);
        penguin.Rotate(0, joystick.Horizontal * turn, 0);

        sheep.localScale += new Vector3(1, 1, 1) * joystick.Vertical;
        
    }
}
