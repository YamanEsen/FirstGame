using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameended = false;

    public float restartdelay = 1f;

    public GameObject completeLevelUI;



    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }

    public void EndGame (){
        if(gameended == false){
            gameended = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart",restartdelay);
        }
        
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
