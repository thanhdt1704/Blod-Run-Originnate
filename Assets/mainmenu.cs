using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
   public void cauchuyen()
   {
        SceneManager.LoadScene(3);
   }
   public void cachchoi()
   {
        SceneManager.LoadScene(5);
   }
   public void luatchoi()
   {
        SceneManager.LoadScene(4);
   }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
