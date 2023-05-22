using Nessie.Udon.SaveState;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

[AddComponentMenu("")] // Hide the example script from the component menu.
public class NUSaveState_Example_Sharp : UdonSharpBehaviour
{
    // Simple declarations to reflect the Graph equivalents.
    public NUSaveState NUSaveState;

    // Saved/Loaded variables.
    public TMPro.TextMeshPro text;
    public Color c0, c1, c2, c3,
                 c4, c5, c6, c7,
                 c8, c9, ca, cb,
                 cc, cd, ce, cf;

    public void _Save()
    {
        NUSaveState._SSSave();
    }

    public void _Load()
    {
        NUSaveState._SSLoad();
    }
    public void refresh()
    {
        text.text = col(c0) + col(c1) + col(c2) + col(c3) + "\n"
            + col(c4) + col(c5) + col(c6) + col(c7) + "\n"
            + col(c8) + col(c9) + col(ca) + col(cb) + "\n"
            + col(cc) + col(cd) + col(ce) + col(cf);
    }

    private string col(Color c)
    {
        return "<color=" + ToHtmlStringRGB(c) + ">█</color>";
    }

    public static string ToHtmlStringRGB(Color color) //thanks ChatGPT :3
    {
        int r = Mathf.RoundToInt(color.r * 255f);
        int g = Mathf.RoundToInt(color.g * 255f);
        int b = Mathf.RoundToInt(color.b * 255f);

        return $"#{r:X2}{g:X2}{b:X2}";
    }

    public void _Randomize()
    {
        c0 = Random.ColorHSV();
        c1 = Random.ColorHSV();
        c2 = Random.ColorHSV();
        c3 = Random.ColorHSV();
        c4 = Random.ColorHSV();
        c5 = Random.ColorHSV();
        c6 = Random.ColorHSV();
        c7 = Random.ColorHSV();
        c8 = Random.ColorHSV();
        c9 = Random.ColorHSV();
        ca = Random.ColorHSV();
        cb = Random.ColorHSV();
        cc = Random.ColorHSV();
        cd = Random.ColorHSV();
        ce = Random.ColorHSV();
        cf = Random.ColorHSV();
        refresh();
    }

    #region Callbacks

    public void _SSPostLoad()
    {
        refresh();
    }

    #endregion Callbacks
}
