using MaterialSkin.Controls;
using System;

namespace EasyMC
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple900, MaterialSkin.Primary.Purple800, MaterialSkin.Primary.Purple700, MaterialSkin.Accent.Red700, MaterialSkin.TextShade.WHITE);
        }
    }
}