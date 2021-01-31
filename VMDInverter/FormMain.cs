using MikuMikuMethods.VMD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMDInverter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePathes = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var filePath in filePathes)
            {
                Invert(filePath);
            }
        }

        private static void Invert(string filePath)
        {
            try
            {
                var outName = Path.GetFileNameWithoutExtension(filePath) + "_reverse.vmd";
                var outPath = Path.Join(Path.GetDirectoryName(filePath), outName);

                using (BinaryReader reader = new(new FileStream(filePath, FileMode.Open), MikuMikuMethods.Encoding.ShiftJIS))
                using (BinaryWriter writer = new(new FileStream(outPath, FileMode.Create), MikuMikuMethods.Encoding.ShiftJIS))
                {
                    VocaloidMotionData vmd = new(reader);
                    VMDInverter.Do(vmd);
                    vmd.Write(writer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error in {Path.GetFileName(filePath)}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
