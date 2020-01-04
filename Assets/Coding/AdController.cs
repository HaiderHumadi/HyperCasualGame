using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdController : MonoBehaviour
{

    public string gameId = "3416469";
    public string placementId = "BannerAd";
    public bool testMode = true;

    void Start()
    {
        // Initialize the SDK if you haven't already done so:
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenReady());
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(placementId);
        

    }
}