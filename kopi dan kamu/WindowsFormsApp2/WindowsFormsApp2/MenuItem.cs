using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class MenuItem
{
    public string Nama { get; set; }
    public int Harga { get; set; }
    public string Kategori { get; set; }
    public string NamaFileGambar { get; set; }

    public Image Gambar
    {
        get
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "images", NamaFileGambar);
                return Image.FromFile(path);
            }
            catch
            {
                return SystemIcons.Warning.ToBitmap(); 
            }
        }
    }
}
