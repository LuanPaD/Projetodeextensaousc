namespace Projeto_de_Extensão.Properties
{
    using System;

    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        internal Resources()
        {
        }

        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Projeto_de_Extensão.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static System.Drawing.Bitmap Group_855
        {
            get
            {
                object obj = ResourceManager.GetObject("Group 855", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap Group_856
        {
            get
            {
                object obj = ResourceManager.GetObject("Group 856", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap Perguntas
        {
            get
            {
                object obj = ResourceManager.GetObject("Perguntas", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
