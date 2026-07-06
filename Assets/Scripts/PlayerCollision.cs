using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag=="Obstacle")
        {
            playerMovement.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(collisionInfo.collider.tag=="Finish")
        {
            Debug.Log("Bu aþamayý bitirdiniz");
        }
    }
}
