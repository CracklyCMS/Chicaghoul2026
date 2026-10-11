using TMPro;
using UnityEngine;

public class managementScript : MonoBehaviour
{

    public GameObject alien;
    public GameObject human;
    public targetScript target;
    public TextMeshProUGUI aliensCapturedNum;

    private float timer;

    void Start()
    {

    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2f)
        {
            int decider = Random.Range(0, 2);
            if(decider == 0)
            {
                Instantiate(alien);
            }
            else
            {
                Instantiate(human);
            }
            timer = 0f;
        }
        aliensCapturedNum.text = target.aliensCaptured.ToString();
    }
}
