using UnityEngine;
using UnityEngine.Video;

public class DownloadMovieVP : MonoBehaviour
{
    void Start()
    {
        var vp = gameObject.AddComponent<VideoPlayer>();
        vp.url = "https://www.youtube.com/embed/DjIEks2o510";
        vp.isLooping = true;
        vp.renderMode = VideoRenderMode.MaterialOverride;
        vp.targetMaterialRenderer = GetComponent<Renderer>();
        vp.targetMaterialProperty = "_MainTex";
        vp.Play();
    }
}
