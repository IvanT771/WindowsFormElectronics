using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormElectronics
{
    public static class SaveSystem
    {
        public static void SaveData(Material[] materials)
        {
            string path = Application.CommonAppDataPath+"Data.mt";
            AllMaterials data = new AllMaterials(materials);

            using (FileStream stream = new FileStream(path,FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream,data);
            }
           
        }

        public static AllMaterials LoadDefaultData()
        {

            Material[] materials = new Material[3];

            materials[0] = new Material();
            materials[1] = new Material();
            materials[2] = new Material();
            

            materials[0].SetDefaultData(0);
            materials[1].SetDefaultData(1);
            materials[2].SetDefaultData(2);

            return new AllMaterials(materials);


        }

        public static AllMaterials LoadData()
        {
            string path = Application.CommonAppDataPath + "Data.mt";
            if (!File.Exists(path)) { return LoadDefaultData();}

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (AllMaterials)formatter.Deserialize(stream);
            }
        }
    }
}
