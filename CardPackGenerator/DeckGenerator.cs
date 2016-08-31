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
    public partial class DeckGenerator : Form
    {
        private struct CardData
        {
            public string FileName;
            public Bitmap Image;
            public Int32 Count;

            public CheckBox whiteBoarderCheckbox;
        }

        private List<CardData> Cards;
        public Size CardImageSize;
        public Size CardBoarderSize;
        public Int32 numOfColumns = 10;
        public Int32 numOfRows = 7;

        public DeckGenerator()
        {
            InitializeComponent();
            Cards = new List<CardData>();
            CardImageSize = new Size(312, 445);
            CardBoarderSize = new Size(10, 10);
        }

        private void DeckGenerator_Load(object sender, EventArgs e)
        {

        }

        private void DeckGenerator_Resize(object sender, System.EventArgs e)
        {
            Size newSize = this.Size;
            newSize.Height -= this.menuStrip1.Height;
            cardPanel.Size = newSize;
        }

        private void AddCard()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "jpg files(*.jpg)|*.jpg";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        bool bIsNewCard = true;
                        foreach (CardData Card in Cards)
                        {
                            if(Card.FileName == fileName)
                            {
                                bIsNewCard = false;
                                break;
                            }
                        }

                        if (bIsNewCard)
                        {
                            CardData NewCard = new CardData();
                            NewCard.FileName = fileName;
                            NewCard.Image = (Bitmap)Image.FromFile(fileName, true);
                            NewCard.Count = 1;

                            NewCard.whiteBoarderCheckbox = new CheckBox();

                            Cards.Add(NewCard);
                        }
                    }
                       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void RenderCards()
        {
            cardPanel.Controls.Clear();

            Size newSize = this.Size;
            newSize.Height -= this.menuStrip1.Height;
            cardPanel.Size = newSize;
           
            for(int i = 0; i < Cards.Count; ++i)
            {

                CardData Card = Cards[i];

                FlowLayoutPanel newPanel = new FlowLayoutPanel();


                /*
                Label cardFilePath = new Label();
                cardFilePath.Location = new Point(0, 0);
                cardFilePath.Text = "White Boarder";
                cardPanel.Controls.Add(cardFilePath);
                */

                /*
                TextBox cardCountTextBox = new TextBox();
                cardCountTextBox.Location = new Point(0, 0);
                cardCountTextBox.Text = Card.Count.ToString();
                newPanel.Controls.Add(cardCountTextBox);
                */

                Card.whiteBoarderCheckbox.Location = new Point(0, 0);
                newPanel.Controls.Add(Card.whiteBoarderCheckbox);

                PictureBox cardPicture = new PictureBox();
                cardPicture.Image = Card.Image;
                cardPicture.Location = new Point(0, 0);
                cardPicture.Size = Card.Image.Size;
                newPanel.Controls.Add(cardPicture);

                Size NewSize = cardPicture.Size;
                NewSize.Height += Card.whiteBoarderCheckbox.Height;

                newPanel.Size = NewSize;

                cardPanel.Controls.Add(newPanel);
            }

            this.Text = "Deck Generator (" + Cards.Count.ToString() + " Cards) (" + numOfColumns.ToString() + " Columns) (" + numOfRows.ToString() + " Rows)";
        }

        private void addCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCard();
            AutoGenGrid();
            RenderCards();
        }

        private void clearCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cards.Clear();
            RenderCards();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDeckImage();
        }

        private void SaveDeckImage()
        {

            if(numOfColumns * numOfRows < Cards.Count)
            {
                MessageBox.Show("There is not enough space on the card sheet for the number of cards");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "png files(*.png)|*.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Int32 width = (CardBoarderSize.Width * 2 + CardImageSize.Width) * numOfColumns;
                Int32 height = (CardBoarderSize.Height * 2 + CardImageSize.Height) * numOfRows;

                Int32 cardWidth = width / numOfColumns;
                Int32 cardHeight = height / numOfRows;

                Bitmap output = new Bitmap(width, height);

                Graphics canvas = Graphics.FromImage(output);
                canvas.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                int i = 0;
                foreach(CardData Card in Cards)
                {
                    int row = i / numOfColumns;
                    int column = i % numOfColumns;

                    int x = cardWidth * column;
                    int y = cardHeight * row;

                    Brush cardbackBrush;
                    if (Card.whiteBoarderCheckbox.Checked)
                    {
                        cardbackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                    }
                    else
                    {
                        cardbackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                    }
                    canvas.FillRectangle(cardbackBrush, x, y, x + cardWidth, y + cardHeight);

                    Point imagePoint = new Point(x + CardBoarderSize.Width, y + CardBoarderSize.Height);
                    canvas.DrawImage(Card.Image, imagePoint.X,imagePoint.Y,CardImageSize.Width,CardImageSize.Height);


                    ++i;
                }

                canvas.Save();

                try
                {
                    output.Save(saveFileDialog.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file on disk. Original error: " + ex.Message);
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Form = new Settings();
            Form.SetDeckGenerator(this);

            Form.Show();
        }

        private void AutoGenGrid()
        {
            int maxColumns = 10;
            int maxRows = 7;

            int bestColumns = maxColumns;
            int bestRows = maxRows;
            int bestTotal = maxRows * maxColumns;
            bool done = false;

            for (int rows = 2; !done && (rows <= maxRows); ++rows)
            {
                for (int columns = 2; !done && (columns <= maxColumns); ++columns)
                {
                    int Total = rows * columns;

                    if(Total >= Cards.Count && Total < bestTotal)
                    {
                        bestRows = rows;
                        bestColumns = columns;
                        bestTotal = Total;
                    }
                    /*
                    else if(bestRows < rows && bestColumns < columns)
                    {
                        done = true;
                    }
                    */

                }
            }

            numOfColumns = bestColumns;
            numOfRows = bestRows;

        }
    }
}
