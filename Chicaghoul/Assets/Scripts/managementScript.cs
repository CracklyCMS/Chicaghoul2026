using TMPro;
using UnityEngine;

public class managementScript : MonoBehaviour
{

    public GameObject alien;
    public targetScript target;
    public TextMeshProUGUI aliensCapturedNum;

    private float timer;

    void Start()
    {
        //Instantiate(alien);
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2f)
        {
            Instantiate(alien);
            timer = 0f;
        }
        aliensCapturedNum.text = target.aliensCaptured.ToString();
    }
}
