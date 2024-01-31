using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Grid
    {
        
        private static char[,] CharacterArray = new char[9, 9];
        private static char[] Areas = new char[9];

        public Grid()
        {
            CharacterArray = new char[9, 9];
            Areas = new char[ 9];
            for (int i = 0; i < 9; i++)
            {
                Areas[i] = ' ';
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    CharacterArray[i, j] = ' ';
                }
            }
        }
        public char getAreas(int i)
        {
            return Areas[i];
        }
        public char getCharacterArray(int i,int j)
        {
            return CharacterArray[i, j];
        }
        public void setCharacterArray(int i,int j,char t)
        {
            CharacterArray[i,j] = t;
        }
        public char [] getAreas()
        {
            return Areas;
        }
        public char[,] getCharacterArray()
        {
            return CharacterArray;
        }
        public void setAreas(char [] areaArray)
        {
            Areas = areaArray;
        }
        public void setCharacterArray(char[,] ChArray)
        {
            CharacterArray = ChArray;
        }
        public void CharacterArray_CheckWin(out int area, out char turn, out string win_state)
        {
            char player_win = ' ';
            area = 0;
            turn = ' ';
            for (int i = 0; i < 9; i++)
            {
                if (Areas[i] != 'O' && Areas[i] != 'X')
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (CharacterArray[(i / 3) * 3 + 0, j + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + 1, j + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + 2, j + (i % 3) * 3] == 'X')
                        {
                            player_win = 'X';
                            Areas[i] = 'X';
                            area = i + 1;
                            turn = 'X';
                            break;
                        }
                        if (CharacterArray[(i / 3) * 3 + j, 0 + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + j, 1 + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + j, 2 + (i % 3) * 3] == 'X')
                        {
                            player_win = 'X';
                            Areas[i] = 'X';
                            area = i + 1;
                            turn = 'X';
                            break;
                        }
                        if (CharacterArray[(i / 3) * 3 + 0, j + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + 1, j + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + 2, j + (i % 3) * 3] == 'O')
                        {
                            player_win = 'O';
                            Areas[i] = 'O';
                            area = i + 1;
                            turn = 'O';
                            break;
                        }
                        if (CharacterArray[(i / 3) * 3 + j, 0 + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + j, 1 + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + j, 2 + (i % 3) * 3] == 'O')
                        {
                            player_win = 'O';
                            Areas[i] = 'O';
                            area = i + 1;
                            turn = 'O';
                            break;
                        }
                    }
                    if (CharacterArray[(i / 3) * 3 + 0, 0 + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + 2, 2 + (i % 3) * 3] == 'X')
                    {
                        player_win = 'X';
                        Areas[i] = 'X';
                        area = i + 1;
                        turn = 'X';
                        break;
                    }
                    if (CharacterArray[(i / 3) * 3 + 0, 2 + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'X' && CharacterArray[(i / 3) * 3 + 2, 0 + (i % 3) * 3] == 'X')
                    {
                        player_win = 'X';
                        Areas[i] = 'X';
                        area = i + 1;
                        turn = 'X';
                        break;
                    }
                    if (CharacterArray[(i / 3) * 3 + 0, 0 + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + 2, 2 + (i % 3) * 3] == 'O')
                    {
                        player_win = 'O';
                        Areas[i] = 'O';
                        area = i + 1;
                        turn = 'O';
                        break;
                    }
                    if (CharacterArray[(i / 3) * 3 + 0, 2 + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'O' && CharacterArray[(i / 3) * 3 + 2, 0 + (i % 3) * 3] == 'O')
                    {
                        player_win = 'O';
                        Areas[i] = 'O';
                        area = i + 1;
                        turn = 'O';
                        break;
                    }
                }

            }

            win_state = "";

            if (Areas[0] == 'X' && Areas[1] == 'X' && Areas[2] == 'X' ||
                Areas[3] == 'X' && Areas[4] == 'X' && Areas[5] == 'X' ||
                Areas[6] == 'X' && Areas[7] == 'X' && Areas[8] == 'X' ||
                Areas[0] == 'X' && Areas[3] == 'X' && Areas[6] == 'X' ||
                Areas[1] == 'X' && Areas[4] == 'X' && Areas[7] == 'X' ||
                Areas[2] == 'X' && Areas[5] == 'X' && Areas[8] == 'X' ||
                Areas[0] == 'X' && Areas[4] == 'X' && Areas[8] == 'X' ||
                Areas[2] == 'X' && Areas[4] == 'X' && Areas[6] == 'X')
            {
                win_state = ("The Winer is X");
            }

            if (Areas[0] == 'O' && Areas[1] == 'O' && Areas[2] == 'O' ||
                Areas[3] == 'O' && Areas[4] == 'O' && Areas[5] == 'O' ||
                Areas[6] == 'O' && Areas[7] == 'O' && Areas[8] == 'O' ||
                Areas[0] == 'O' && Areas[3] == 'O' && Areas[6] == 'O' ||
                Areas[1] == 'O' && Areas[4] == 'O' && Areas[7] == 'O' ||
                Areas[2] == 'O' && Areas[5] == 'O' && Areas[8] == 'O' ||
                Areas[0] == 'O' && Areas[4] == 'O' && Areas[8] == 'O' ||
                Areas[2] == 'O' && Areas[4] == 'O' && Areas[6] == 'O')
            {
                win_state = ("The Winer is O");
            }
        }
        public void CharacterArray_Check_Probability_Win(char[,] chararray, out string win_state)
        {
            win_state = "";
            for (int i = 0; i < 9; i++)
            {
                if (Areas[i] != 'O' && Areas[i] != 'X')
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (chararray[(i / 3) * 3 + 0, j + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + 1, j + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + 2, j + (i % 3) * 3] == 'X')
                        {
                            win_state = ("The Winer is X");
                            break;
                        }
                        if (chararray[(i / 3) * 3 + j, 0 + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + j, 1 + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + j, 2 + (i % 3) * 3] == 'X')
                        {
                            win_state = ("The Winer is X");
                            break;
                        }
                        if (chararray[(i / 3) * 3 + 0, j + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + 1, j + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + 2, j + (i % 3) * 3] == 'O')
                        {
                            win_state = ("The Winer is O");
                            break;
                        }
                        if (chararray[(i / 3) * 3 + j, 0 + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + j, 1 + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + j, 2 + (i % 3) * 3] == 'O')
                        {
                            win_state = ("The Winer is O");
                            break;
                        }
                    }
                    if (chararray[(i / 3) * 3 + 0, 0 + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + 2, 2 + (i % 3) * 3] == 'X')
                    {
                        win_state = ("The Winer is X");
                        break;
                    }
                    if (chararray[(i / 3) * 3 + 0, 2 + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'X' && chararray[(i / 3) * 3 + 2, 0 + (i % 3) * 3] == 'X')
                    {
                        win_state = ("The Winer is X");
                        break;
                    }
                    if (chararray[(i / 3) * 3 + 0, 0 + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + 2, 2 + (i % 3) * 3] == 'O')
                    {
                        win_state = ("The Winer is O");
                        break;
                    }
                    if (chararray[(i / 3) * 3 + 0, 2 + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + 1, 1 + (i % 3) * 3] == 'O' && chararray[(i / 3) * 3 + 2, 0 + (i % 3) * 3] == 'O')
                    {
                        win_state = ("The Winer is O");
                        break;
                    }
                }

            }

            //win_state = "";

            //if (Areas[0] == 'X' && Areas[1] == 'X' && Areas[2] == 'X' ||
            //    Areas[3] == 'X' && Areas[4] == 'X' && Areas[5] == 'X' ||
            //    Areas[6] == 'X' && Areas[7] == 'X' && Areas[8] == 'X' ||
            //    Areas[0] == 'X' && Areas[3] == 'X' && Areas[6] == 'X' ||
            //    Areas[1] == 'X' && Areas[4] == 'X' && Areas[7] == 'X' ||
            //    Areas[2] == 'X' && Areas[5] == 'X' && Areas[8] == 'X' ||
            //    Areas[0] == 'X' && Areas[4] == 'X' && Areas[8] == 'X' ||
            //    Areas[2] == 'X' && Areas[4] == 'X' && Areas[6] == 'X')
            //{
            //    win_state = ("The Winer is X");
            //}

            //if (Areas[0] == 'O' && Areas[1] == 'O' && Areas[2] == 'O' ||
            //    Areas[3] == 'O' && Areas[4] == 'O' && Areas[5] == 'O' ||
            //    Areas[6] == 'O' && Areas[7] == 'O' && Areas[8] == 'O' ||
            //    Areas[0] == 'O' && Areas[3] == 'O' && Areas[6] == 'O' ||
            //    Areas[1] == 'O' && Areas[4] == 'O' && Areas[7] == 'O' ||
            //    Areas[2] == 'O' && Areas[5] == 'O' && Areas[8] == 'O' ||
            //    Areas[0] == 'O' && Areas[4] == 'O' && Areas[8] == 'O' ||
            //    Areas[2] == 'O' && Areas[4] == 'O' && Areas[6] == 'O')
            //{
            //    win_state = ("The Winer is O");
            //}
        }

        public void getAllPossibleMoves(out int[,] sol, out int depth, Grid temp_s, int area)
        { 
            sol=new int [2,9];
            depth = 0;
            int i = area - 1;
            if (temp_s.getAreas(i) != 'O' && temp_s.getAreas(i) != 'X')
            {
                for (int j = 0; j < 3; j++)
                {
                    if (temp_s.getCharacterArray((i / 3) * 3 + 0, j + (i % 3) * 3) != 'X' && temp_s.getCharacterArray((i / 3) * 3 + 0, j + (i % 3) * 3) != 'O')
                    {
                        sol[0, depth] = (i / 3) * 3 + 0;
                        sol[1, depth] = j + (i % 3) * 3;
                        depth++;
                    }
                    if (temp_s.getCharacterArray((i / 3) * 3 + 1, j + (i % 3) * 3) != 'X' && temp_s.getCharacterArray((i / 3) * 3 + 1, j + (i % 3) * 3) != 'O')
                    {
                        sol[0, depth] = (i / 3) * 3 + 1;
                        sol[1, depth] = j + (i % 3) * 3;
                        depth++;
                    }
                    if (temp_s.getCharacterArray((i / 3) * 3 + 2, j + (i % 3) * 3)!= 'X' && temp_s.getCharacterArray((i / 3) * 3 + 2, j + (i % 3) * 3) != 'O')
                    {
                        sol[0, depth] = (i / 3) * 3 + 2;
                        sol[1, depth] = j + (i % 3) * 3;
                        depth++;
                    }

                }       
            }
        
        }

        public int evaluate(Grid test_squares, int area,int ii,int jj)
        {
            string state;
            char[,] chararray = new char[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    chararray[i, j] = test_squares.getCharacterArray(i, j);
                }
            chararray[ii, jj] = 'O';
            CharacterArray_Check_Probability_Win(chararray, out state);
            if (state == "The Winer is O")
                return 10;
            else
            {
                chararray[ii, jj] = 'X';
                CharacterArray_Check_Probability_Win(chararray, out state);
                if (state == "The Winer is X")
                    return 5;
            }
            return 0;
        }
    }
}
