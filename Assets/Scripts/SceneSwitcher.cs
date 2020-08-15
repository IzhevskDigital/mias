using UnityEngine.SceneManagement;

public static class SceneSwitcher
{
    public static void GotoAchivementScene()
    {
        SceneManager.LoadScene("Achivement");
    }
    public static void GotoMyProjectsScene()
    {
        SceneManager.LoadScene("MyProjects");
    }
    public static void GotoInventoryScene()
    {
        SceneManager.LoadScene("Inventory");
    }
    public static void GotoMyVideoScene()
    {
        SceneManager.LoadScene("MyVideo");
    }
    public static void GotoWelcomeScene()
    {
        SceneManager.LoadScene("Welcome");
    }
    public static void GotoHonorsScene()
    {
        SceneManager.LoadScene("Honors");
    }
    public static void GotoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public static void GotoRegisterScene()
    {
        SceneManager.LoadScene("Register");
    }
    public static void GotoRegisterSmSScene()
    {
        SceneManager.LoadScene("RegisterSMS");
    }
    public static void GotoScanScene()
    {
        SceneManager.LoadScene("Scan");
    }
}