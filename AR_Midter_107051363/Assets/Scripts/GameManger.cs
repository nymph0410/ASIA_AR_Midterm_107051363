using UnityEngine;

public class GameManger : MonoBehaviour
{
    [Header("人類")]
    public Transform male;

    [Header("殭屍")]
    public Transform Zombie;

    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
    }
}
