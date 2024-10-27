using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.VFX;

public class WeatherSystem : MonoBehaviour
{
    [Header("Global")]
    public Material globalMaterial;
    public Light sunLight;
    public Material skyboxMaterial;
    public TMP_Text weatherText;

    [Header("Winter Assets")]
    public ParticleSystem winterParticleSystem;
    public Volume winterVolume;

    [Header("Rain Assets")]
    public ParticleSystem rainParticleSystem;
    public Volume rainVolume;

    [Header("Autumn Assets")]
    public ParticleSystem autumnParticleSystem;
    public Volume autumnVolume;
    public VisualEffect autumnVFX;

    [Header("Summer Assets")]
    public ParticleSystem summerParticleSystem;
    public Volume summerVolume;

    private void Start()
    {
        Summer();

        
    }

    public void Winter()
    {
        resetPriorities();
        winterVolume.priority = 10;
        winterParticleSystem.Play();
        globalMaterial.SetFloat("_SnowFade", 1);
    }

    public void Rain()
    {
        resetPriorities();
        rainVolume.priority = 10;
        rainParticleSystem.Play();
    }

    public void Autumn()
    {
        resetPriorities();
        autumnVolume.priority = 10;
        autumnVFX.Play();
        
    }

    public void Summer()
    {
        resetPriorities();
        summerVolume.priority = 10;
        summerParticleSystem.Play();
    }

    void resetPriorities()
    {
 //       Volume[] volumes = {winterVolume, rainVolume, autumnVolume, summerVolume};

        summerVolume.priority = 0;
        winterVolume.priority = 0;
        rainVolume.priority = 0;
        autumnVolume.priority = 0;

        rainParticleSystem.Stop();
        winterParticleSystem.Stop();
        autumnVFX.Stop();
        summerParticleSystem.Stop();

        globalMaterial.SetFloat("_SnowFade", 0);

    }

}
