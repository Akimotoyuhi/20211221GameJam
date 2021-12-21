using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// シーンを制御するコンポーネント
/// </summary>
public class SceneManeger : MonoBehaviour
{
    /// <summary>
    /// シーンを切り替える。 "scene = シーン名" 
    /// </summary>
    /// <param name="scene"></param>
    public void Scene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    /// <summary>
    /// ゲームを終了する。
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }
}
