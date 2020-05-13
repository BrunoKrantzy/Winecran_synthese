using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;


namespace WinecranFormsApp
{
    public class EcranCZS : IDisposable
    {
        public List<WinShape> ListeShapes
        { get; }

        public int NbShapes
        { get; set; } = 0;

        public Bitmap Picture
        { get; set; }

        public string SonEnteteQuestion
        { get; set; } = string.Empty;

        public string SonErreur
        { get; set; } = string.Empty;

        public string SonExact
        { get; set; } = string.Empty;

        private bool disposed = false;


        public EcranCZS(string bitmapEcran, string wavEntete, string wavExact, string wavErreur)
        {
            Picture = new Bitmap(bitmapEcran);
            SonEnteteQuestion = wavEntete;
            SonExact = wavExact;
            SonErreur = wavErreur;

            ListeShapes = new List<WinShape>();
        }


        // Implémenter IDisposable()

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                Picture.Dispose();
                ListeShapes.Clear();
            }

            // Free any unmanaged objects here.
            // ... ...

            disposed = true;
        }


        ~EcranCZS()
        {
            Dispose(false);
        }

    }
}

