using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text score;
    private void Update()
    {
        score.text =((int)(player.transform.position.z)).ToString();
    }
}
