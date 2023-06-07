using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game : Singleton<game>
{
    // Start is called before the first frame update
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public List<GameObject> balls;

    public void RemoveBall(GameObject ball)
    {
        balls.Remove(ball);
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if (balls.Count <= 0)
        {
            ReSetGame();
        }
    }

    private void ReSetGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameObject i1;
        i1 = Instantiate(item1, new Vector3(-2.4f,-4.91f,0f), Quaternion.identity, this.transform);
        balls.Add(i1);

        GameObject i2;
        i2 = Instantiate(item3, new Vector3(-1.45f, -4.91f, 0f), Quaternion.identity, this.transform);
        balls.Add(i2);

        GameObject i3;
        i3 = Instantiate(item2, new Vector3(-0.48f, -4.91f, 0f), Quaternion.identity, this.transform);
        balls.Add(i3);

        GameObject i4;
        i4 = Instantiate(item1, new Vector3(0.51f, -4.91f, 0f), Quaternion.identity, this.transform);
        balls.Add(i4);

        GameObject i5;
        i5 = Instantiate(item2, new Vector3(1.49f, -4.91f, 0f), Quaternion.identity, this.transform);
        balls.Add(i5);

        GameObject i6;
        i6 = Instantiate(item3, new Vector3(2.43f, -4.91f, 0f), Quaternion.identity, this.transform);
        balls.Add(i6);
    }

}
