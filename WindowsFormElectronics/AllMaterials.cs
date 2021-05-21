using System;


namespace WindowsFormElectronics
{
    [System.Serializable]
    public class AllMaterials
    {
        public Material[] materials;
        public AllMaterials(Material[] _materials)
        {
            materials = _materials; 
        }
    }
}
