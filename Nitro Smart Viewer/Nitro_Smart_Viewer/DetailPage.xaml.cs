using System;
using Xamarin.Forms;

namespace Nitro_Smart_Viewer
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(object detail, ITextFileReader textFileReader)
        {
            InitializeComponent();

            if (detail is string)
                detailLabel.Text = detail as string;
            else if (detail is ResourceFileData)
            {
                detailLabel.Text = (detail as ResourceFileData).DisplayName;
                if (textFileReader != null)
                    contentLabel.Text = textFileReader.GetTxtFileContent(ResourceHelper.GetResourceStream((detail as ResourceFileData).FileName));
            }
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}