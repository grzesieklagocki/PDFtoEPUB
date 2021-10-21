using GalaSoft.MvvmLight;
using PropertyChanged;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace PDFtoEPUB.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : ViewModelBase
    {
        public string Text { get; set; }
        public List<System.Drawing.Image> PdfBitmaps { get; private set; } = new List<System.Drawing.Image>();

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}



        }


    }
}