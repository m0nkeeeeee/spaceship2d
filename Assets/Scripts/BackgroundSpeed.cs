using UnityEngine;

public class BackgroundSpeed : MonoBehaviour
{

    public float backgroundSpeed;   //how fast our background will move 
    public Renderer backgroundRenderer;  // we need to get the renderer of our background to be able to move it

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f); // we move the background by changing the offset of the texture of our background material. We only change the x coordinate since we want to move it horizontally. We multiply it by Time.deltaTime to make it frame rate independent.
    }
}
