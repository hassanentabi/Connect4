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

namespace TheWinningApp
{
    public partial class Frm_Game : Form
    {
        public Frm_Game()
        {
            InitializeComponent();
            InitialiseGridOfBoxes();
            InitialiseButtons();
            InitialiseGameData();
        }

        #region defination Initialise of Value 

        // Initialise Squar Size
        int mHeight = 45;
        int mWidth = 45;
        int mTop = 51;
        int mLeft = 51;

        // Initialise Row & Column and Button
        int RowNumber = 7;
        int ColumnNumber = 7;
        int ButtonNumber = 7;


        // Initialise Name Player 1 & 2
        String Player1; 
        String Player2; 

        // In this country, we count many of piece we used in board
        int PieceCount; 

        //Initialise round
        String round;

        // Initialise Picture Boxes Array 
        // We Set Size of Array is 7*7 
        PictureBox[,] gridOfBoxes = new PictureBox[7, 7];

        //Array of Strings to store the values grid Of Boxs
        String[,] gridValue = new String[7, 7];

        //Array of column buttons
        Button[] buttonSelect = new Button[7];

        #endregion

        #region Initialise the grid Picture Box
        // in this ragion we Initialise the grid Picture Box
        void InitialiseGridOfBoxes()
        {
            for (int i = 0; i < RowNumber; i++)
            {
                for (int y = 0; y < ColumnNumber; y++)
                {
                    //Set options the grid
                    gridOfBoxes[i, y] = new PictureBox();
                    // Set the Bounds (Left , Top, width, height);
                    gridOfBoxes[i, y].SetBounds((mLeft * y) + 12, (mTop * i) + 105, mWidth, mHeight);
                    // Set the Back ground Color is White  
                    gridOfBoxes[i, y].BackColor = Color.White;
                    // Set the SizeMode to "will enlarge the image as needed to fit into"
                    gridOfBoxes[i, y].SizeMode = PictureBoxSizeMode.StretchImage;
                    gridValue[i, y] = "None";
                    Controls.Add(gridOfBoxes[i, y]);

                    //Set the Button Click handler  
                    switch (y)
                    {
                        case 0:
                            gridOfBoxes[i, y].Click += new EventHandler(this.ClickOnColumn1);
                            break;
                        case 1:
                            gridOfBoxes[i, y].Click += new EventHandler(this.ClickOnColumn2);
                            break;
                        case 2:
                            gridOfBoxes[i, y].Click += new EventHandler(this.ClickOnColumn3);
                            break;
                        case 3:
                            gridOfBoxes[i, y].Click += new EventHandler(this.ClickOnColumn4);
                            break;
                        case 4:
                            gridOfBoxes[i, y].Click += new EventHandler(this.ClickOnColumn5);
                            break;
                        case 5:
                            gridOfBoxes[i, y].Click += new EventHandler(this.ClickOnColumn6);
                            break;
                        case 6:
                            gridOfBoxes[i, y].Click += new EventHandler(this.ClickOnColumn7);
                            break;
                    }
                }
            }
        }
        #endregion

        #region InitialiseGameData
        //Initialise the date we needed when Running the game
        void InitialiseGameData()
        {
            Player1 = "Red";
            Player2 = "Blue";

            lblPlayNow.ForeColor = Color.Red;
            lblPlayer1.ForeColor = Color.Red;
            lblPlayer2.ForeColor = Color.Blue;

            round = "Red";
            PieceCount = 0;
        }
        #endregion

        #region initialise Buttons
        //Initialise the row of buttons
        void InitialiseButtons()
        {
            for (int i = 0; i < ButtonNumber; i++)
            {
                buttonSelect[i] = new Button();
                buttonSelect[i].SetBounds((mLeft * i) + 12, 55, mWidth, mHeight);
                buttonSelect[i].Text = Convert.ToString(i + 1);
                buttonSelect[i].Click += new EventHandler(this.ColumnClick);
                Controls.Add(buttonSelect[i]);
            }
        }

        #endregion

        #region ClickOnColumn
        //Set Grid of boxes Click event handler for each column
        void ClickOnColumn1(object sender, EventArgs e)
        {
            DropOutPiece(0);
        }

        void ClickOnColumn2(object sender, EventArgs e)
        {
            DropOutPiece(1);
        }

        void ClickOnColumn3(object sender, EventArgs e)
        {
            DropOutPiece(2);
        }

        void ClickOnColumn4(object sender, EventArgs e)
        {
            DropOutPiece(3);
        }

        void ClickOnColumn5(object sender, EventArgs e)
        {
            DropOutPiece(4);
        }

        void ClickOnColumn6(object sender, EventArgs e)
        {
            DropOutPiece(5);
        }

        void ClickOnColumn7(object sender, EventArgs e)
        {
            DropOutPiece(6);
        }
        #endregion

        #region Switch Player
        // in this Ragion we Switch the player 
        void SwitchPlayer()
        {
            if (round == "Red")
            {
                round = "Blue";
                lblPlayNow.Text = Player2;
                lblPlayNow.ForeColor = Color.Blue;

            }
            else
            {
                round = "Red";
                lblPlayNow.Text = Player1;
                lblPlayNow.ForeColor = Color.Red;

            }
            PieceCount++;

            // if the pieces of the game equal (49) this mean the bord is full  
            if (PieceCount == 49)
            {
                EndGame();
            }
        }


        #endregion

        #region End Game
        // End game if on one of the player win in the game
        void EndGame()
        {
            string message = "No One Of the Player Win in the Game ";
            string title = "Result";
            // Show Message Box
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Re-Start the game 
            StartNewGame();
        }
        #endregion

        #region Check Is Win
        //Check if the one the playr is win
        bool CheckIsWin(int row, int Column)
        {

            //------------------------------------
            // ----------- HORIZONTAL  -----------
            //------------------------------------

            //set counter to 1 (the piece itself)
            int mCounter = 1;

            //Loop left and count
            int mColumn = Column - 1;
            while (mColumn >= 0 && gridValue[row, mColumn] == round)
            {

                mCounter++;
                mColumn--;

            }

            //Loop right and count
            mColumn = Column + 1;
            while (mColumn <= 6 && gridValue[row, mColumn] == round)
            {
                mCounter++;
                mColumn++;

            }

            //Check if there is a win
            if (mCounter >= 4)
            {

                //-----------------
                PlayerWin();
                return true;

                ////Make background Coulor is 
                ////-----------------
                //if(mCounter == 4)
                //{
                //    for (int i = 0; i < 4; i++)
                //    {
                //        if (Column < 4)
                //        {
                //            gridOfBoxes[row, Column - i].BackColor = Color.Yellow;
                //        }
                //        else
                //        {
                //            gridOfBoxes[row, Column + (i - 1)].BackColor = Color.Yellow;
                //        }

                //    }
                //}
                ////-----------------
                //if (mCounter > 4)
                //{
                //    for (int i = 0; i < (mCounter - 3); i++)
                //    {
                //        gridOfBoxes[row, Column + i].BackColor = Color.Yellow;
                //    }

                //    for (int i = 0; i < 4; i++)
                //    {
                //        gridOfBoxes[row, Column - i].BackColor = Color.Yellow;
                //    }
                //}

            }

            //------------------------------------
            // ----------- VERTICAL  -----------
            //------------------------------------

            //set counter to 1(the piece itself)
            mCounter = 1;

            //Loop up and count
            int mRow = row - 1;
            while (mRow >= 0 && gridValue[mRow, Column] == round)
            {
                mCounter++;
                mRow--;
            }

            //Loop down and count
            mRow = row + 1;
            while (mRow <= 6 && gridValue[mRow, Column] == round)
            {
                mCounter++;
                mRow++;
            }

            //Check if there is a win
            if (mCounter >= 4)
            {
                PlayerWin();
                return true;
            }

            //------------------------------------
            // ---- { +ve GRADIENT DIAGONAL } ----
            //------------------------------------

            //set counter to 1(the piece itself)
            mCounter = 1;

            //Loop down and left
            mRow = row + 1;
            mColumn = Column - 1;
            while (mRow <= 6 && mColumn >= 0 && gridValue[mRow, mColumn] == round)
            {
                mCounter++;
                mRow++;
                mColumn--;
            }

            //Loop up and right
            mRow = row - 1;
            mColumn = Column + 1;
            while (mRow >= 0 && mColumn <= 6 && gridValue[mRow, mColumn] == round)
            {
                mCounter++;
                mRow--;
                mColumn++;
            }

            //Check if there is a win
            if (mCounter >= 4)
            {
                PlayerWin();
                return true;
            }

            //------------------------------------
            // --- {-ve GRADIENT DIAGONAL  } -----
            //------------------------------------
            //set counter to 1 (the piece itself)
            mCounter = 1;

            //Loop up and left
            mRow = row - 1;
            mColumn = Column - 1;
            while (mRow >= 0 && mColumn >= 0 && gridValue[mRow, mColumn] == round)
            {
                mCounter++;
                mRow--;
                mColumn--;
            }

            //Loop down and right
            mRow = row + 1;
            mColumn = Column + 1;
            while (mRow <= 6 && mColumn <= 6 && gridValue[mRow, mColumn] == round)
            {
                mCounter++;
                mRow++;
                mColumn++;
            }

            //Check if there is a win
            if (mCounter >= 4)
            {
                PlayerWin();
                return true;
            }

            return false;
        }
        #endregion

        #region Player Win
        //Game Won by current player
        void PlayerWin()
        {
            String message = " has won the game! \n Are you Want play Agin";
            String title = "CONGRATULATIONS";
            String name = "";
            if (round == "Red")
            {
                name = Player1;
            }
            else
            {
                name = Player2;
            }

            if (MessageBox.Show(name + message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Re-Start the game 
                StartNewGame();

            }
            else
            {
                Application.Exit();
            }


        }
        #endregion

        #region ColumnClick
        //Event work  when the column is selected
        void ColumnClick(object sender, EventArgs e)
        {
            DropOutPiece(int.Parse(((Button)sender).Text) - 1);
        }
        #endregion

        #region FillPiece
        //Fill the piece and chech is win
        bool FillPiece(int row, int column)
        {
            gridValue[row, column] = round;
            if (round == "Red")
            {
                gridOfBoxes[row, column].Image = Properties.Resources.Red;
            }
            else
            {
                gridOfBoxes[row, column].Image = Properties.Resources.Blue;
            }
            return CheckIsWin(row, column);
        }
        #endregion

        #region Drop Out Piece
        // Drop out a piece of the current color into the column 
        // that is passed in the column
        void DropOutPiece(int Column)
        {
            //Loop down grid
            bool traversal = true;
            int row = 0;
            while (traversal)
            {
                if (row == 6)
                {
                    traversal = false;
                    if (!FillPiece(row, Column))
                    {
                        SwitchPlayer();
                    }
                }
                else if (gridValue[row + 1, Column] != "None")
                {
                    if (gridValue[row, Column] == "None")
                    {
                        if (!FillPiece(row, Column))
                        {
                            SwitchPlayer();
                        }
                    }
                    traversal = false;
                }
                else
                {
                    row++;
                }
            }

        }

        #endregion

        #region Start New Game
        // in this ragion we Start new Game by make 
        // grid Of Boxes  Clear
        void StartNewGame()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    gridOfBoxes[i, y].Image = null;
                    // gridOfBoxes[i, y].BackColor = Color.White;
                    gridValue[i, y] = "None";
                }
            }
            InitialiseGameData();
        }
        #endregion

        #region Set Name Player
        //Set Name Player 1 
        public void setNamePlayer1(string name)
        {
            Player1 = name;
            lblPlayer1.Text = name;
            lblPlayNow.Text = name;
        }

        //Set Name Player 2
        public void setNamePlayer2(string name)
        {
            Player2 = name;
            lblPlayer2.Text = name;
        }
        #endregion

        #region Information button 

        private void newGameToolStripMenuNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void exiteToolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuAbout_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
