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
    public Vector3 v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, va, vb, vc, vd, ve, vf;

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
        text.text = v0.ToString()
            + "\n" + v1.ToString()
            + "\n" + v2.ToString()
            + "\n" + v3.ToString()
            + "\n" + v4.ToString()
            + "\n" + v5.ToString()
            + "\n" + v6.ToString()
            + "\n" + v7.ToString()
            + "\n" + v8.ToString()
            + "\n" + v9.ToString()
            + "\n" + va.ToString()
            + "\n" + vb.ToString()
            + "\n" + vc.ToString()
            + "\n" + vd.ToString()
            + "\n" + ve.ToString()
            + "\n" + vf.ToString();
    }

    public void _Randomize()
    {
        v0 = Random.insideUnitSphere;
        v1 = Random.insideUnitSphere;
        v2 = Random.insideUnitSphere;
        v3 = Random.insideUnitSphere;
        v4 = Random.insideUnitSphere;
        v5 = Random.insideUnitSphere;
        v6 = Random.insideUnitSphere;
        v7 = Random.insideUnitSphere;
        v8 = Random.insideUnitSphere;
        v9 = Random.insideUnitSphere;
        va = Random.insideUnitSphere;
        vb = Random.insideUnitSphere;
        vc = Random.insideUnitSphere;
        vd = Random.insideUnitSphere;
        ve = Random.insideUnitSphere;
        vf = Random.insideUnitSphere;
        refresh();
    }

    #region Callbacks

    public void _SSPostLoad()
    {
        refresh();
    }

    #endregion Callbacks
}
