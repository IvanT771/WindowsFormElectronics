using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
