using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardPackGenerator
{
    public partial class Settings : Form
    {
        DeckGenerator Generator;

        public Settings()
        {
            InitializeComponent();
            
        }

        public void SetDeckGenerator(DeckGenerator Gen)
        {
            Generator = Gen;

            CardImageWidth.Value = Generator.CardImageSize.Width;
            CardImageHeight.Value = Generator.CardImageSize.Height;

            CardBoarderWidth.Value = Generator.CardBoarderSize.Width;
            CardBoarderHeight.Value = Generator.CardBoarderSize.Height;

            Columns.Value = Generator.numOfColumns;
            Rows.Value = Generator.numOfRows;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Generator.CardImageSize.Width = (int)CardImageWidth.Value;
            Generator.CardImageSize.Height = (int)CardImageHeight.Value;

            Generator.CardBoarderSize.Width = (int)CardBoarderWidth.Value;
            Generator.CardBoarderSize.Height = (int)CardBoarderHeight.Value;

            Generator.numOfColumns = (int)Columns.Value;
            Generator.numOfRows = (int)Rows.Value;

            Close();
        }
    }
}
