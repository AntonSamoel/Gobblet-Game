﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Gobblet_Game
{
    public class GameState
    {
        public Board currentBoard;
        public Player player1;
        public Player player2;
        //public static Move lstMove;
        //public int alpha;
        //public int beta;
      //  public int totalHeuristicScore; //heuristic
        public Move bestMove;


        //TODO
        //constructors 
        //for gui initial gamestate

        //for Algorithm Create new Node State to test Move

        //Game constructor to game state with current board state 
        public GameState(Board b, Player player1, Player player2, bool reverse = false)
        {
            
            this.currentBoard = b;
            this.player1 = player1;
            this.player2 = player2;
        }
        

        //main work
        /*
        public long getBestMove(int depth, long id, Move lstMove)
        {
            
            if (depth == 0)
            {
                if (player1.IsMyTurn && ValidMove.isAboutToWin("white", currentBoard.Celles, lstMove) && !ValidMove.isAboutToWin("black", currentBoard.Celles, lstMove))
                {
                    return 1000000000*lstMove.p.Size;
                }
                else if (player1.IsMyTurn && ValidMove.IsWinning("black", currentBoard.Celles) == "black")
                {
                    if (ValidMove.IsWinning("white", currentBoard.Celles) == "white") return -1000000000;               // special case sent to el mo3ed
                    return (depth + 1) * 10;
                }
                else if (player2.IsMyTurn && ValidMove.IsWinning("white", currentBoard.Celles) == "white")
                {
                    if (ValidMove.IsWinning("black", currentBoard.Celles) == "black") return 1000000000;                // special case sent to el mo3ed
                    return (5 - depth) * -10;
                }

                return 0;
            }

            //get all possible moves in this state
            List<Move> moves;
            moves = getNextMoves((player1.IsMyTurn ? player1 : player2), currentBoard);

            long maxHeuristic = 0;                          //how many wins under this state

            for (int i = 0; i < moves.Count; i++)
            {
                int x, y;
                Piece tempPeice = moves[i].p;
                if (moves[i].from is not null)
                {
                    x = moves[i].from!.Row;
                    y = moves[i].from!.Column;
                    if (currentBoard.Celles[x, y].Pieces.Count != 0)  currentBoard.Celles[x, y].Pieces.Pop();
                }
                else
                {
                    if (player1.IsMyTurn) 
                        player1.Pieces[moves[i].stack].Pop(); 
                    else 
                        player2.Pieces[moves[i].stack].Pop();
                }
                x = moves[i].to!.Row;
                y = moves[i].to!.Column;
                currentBoard.Celles[x, y].Pieces.Push(tempPeice);

                player1.IsMyTurn = !player1.IsMyTurn;
                player2.IsMyTurn = !player2.IsMyTurn;
                lstMove = moves[i];
                maxHeuristic += getBestMove(depth - 1, id + 1, lstMove); //calculate the heuristic score after making this move

                player1.IsMyTurn = !player1.IsMyTurn;
                player2.IsMyTurn = !player2.IsMyTurn;
                currentBoard.Celles[x, y].Pieces.Pop();
                if (moves[i].from is not null)
                {
                    x = moves[i].from!.Row;
                    y = moves[i].from!.Column;
                    currentBoard.Celles[x, y].Pieces.Push(tempPeice!);
                }
                else
                {
                    if (player1.IsMyTurn) 
                        player1.Pieces[moves[i].stack].Push(tempPeice); 
                    else 
                        player2.Pieces[moves[i].stack].Push(tempPeice);
                }

            }
            return maxHeuristic;
        }
        */
        public long getBestMoveAB(long alpha, long beta,bool isMax, int depth,long score/*, Move lstMove*/)
        {

            if (depth == 0)
            {
                /*if (isMax) return alpha;
                return beta;*/
                return score;
            }

            

            //get all possible moves in this state
            List<Move> moves;
            moves = getNextMoves((player1.IsMyTurn ? player1 : player2), currentBoard);
            if (depth == 1)
                isMax = !isMax;

            for (int i = 0; i < moves.Count; i++)
            {
                Update(moves[i]);
                // lstMove = moves[i];

                // long score = long.MinValue;

                score += HeustricComp(player1, player2, currentBoard, moves[i]);


                score = getBestMoveAB(alpha, beta, !isMax, depth - 1,score/*, moves[i]*/);

                RollBack(moves[i]);

                //alpha beta implementation

                    if (isMax)
                    {
                        long temp = alpha;
                        alpha = long.Max(alpha, score);
                        if (alpha >= beta) return temp;
                    }
                    else
                    {
                        long temp = beta;
                        beta = long.Min(beta, score);
                        if (alpha >= beta) return temp;
                    }
                
                //=========================================

            }

            if (isMax) return alpha;
             return beta;
            //return score;
        }
        public static long HeustricComp(Player player1,Player player2,Board currentBoard, Move move)
        {
            if (player1.IsMyTurn && ValidMove.isAboutToWin("white", currentBoard.Celles, move) /*&& !ValidMove.isAboutToWin("black", currentBoard.Celles, lstMove)*/)
            {
                return  1000 * move.p.Size;
            }
            else if (player1.IsMyTurn && ValidMove.IsWinning("black", currentBoard.Celles) == "black")
            {
                // if (ValidMove.IsWinning("white", currentBoard.Celles) == "white") score = long.MinValue + 100;               // special case sent to el mo3ed
                //else 
                return 10000;
            }
            else if (player2.IsMyTurn && ValidMove.IsWinning("white", currentBoard.Celles) == "white")
            {
                // if (ValidMove.IsWinning("black", currentBoard.Celles) == "black") score = long.MaxValue - 100;                // special case sent to el mo3ed
                // else
                return -10000;
            }
            return 0;
        }
        private void Update(Move move)
        {
            int x, y;
            Piece tempPeice = move.p;
            if (move.from is not null)
            {
                x = move.from!.Row;
                y = move.from!.Column;
                if (currentBoard.Celles[x, y].Pieces.Count != 0) currentBoard.Celles[x, y].Pieces.Pop();
            }
            else
            {
                if (player1.IsMyTurn)
                    player1.Pieces[move.stack].Pop();
                else
                    player2.Pieces[move.stack].Pop();
            }
            x = move.to!.Row;
            y = move.to!.Column;
            currentBoard.Celles[x, y].Pieces.Push(tempPeice);

            player1.IsMyTurn = !player1.IsMyTurn;
            player2.IsMyTurn = !player2.IsMyTurn;
        }
        private void RollBack(Move move)
        {
            Piece tempPeice = move.p;
            int x, y;
            x = move.to!.Row;
            y = move.to!.Column;
            player1.IsMyTurn = !player1.IsMyTurn;
            player2.IsMyTurn = !player2.IsMyTurn;
            currentBoard.Celles[x, y].Pieces.Pop();
            if (move.from is not null)
            {
                x = move.from!.Row;
                y = move.from!.Column;
                currentBoard.Celles[x, y].Pieces.Push(tempPeice!);
            }
            else
            {
                if (player1.IsMyTurn)
                    player1.Pieces[move.stack].Push(tempPeice);
                else
                    player2.Pieces[move.stack].Push(tempPeice);
            }
        }
        //must return list of valid moves 
        //must return list of valid moves 
        public static List<Move> getNextMoves(Player player, Board currentBoard)
        {
            List<Move> nextMoves = new();
            List<Tuple<int, Move>> tempNextMoves=new();

            for (int k = 0; k < 3; k++)
            {
                if (player.Pieces[k].Count() == 0) continue;
                Piece piece = player.Pieces[k].Peek();
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                    {
                        if (ValidMove.IsExternalMoveAvailble(currentBoard.Celles, currentBoard.Celles[i, j], piece))
                            tempNextMoves.Add(Tuple.Create(piece.Size, new Move(piece, null, currentBoard.Celles[i, j], k)));
                        //nextMoves.Add(new Move(piece, null, currentBoard.Celles[i, j],k));
                    }
            }
            tempNextMoves = tempNextMoves.OrderByDescending(x => x.Item1).ToList();
            foreach (var item in tempNextMoves)
            {
                nextMoves.Add(item.Item2);
            }
            tempNextMoves.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)                                     // from (i, j)
                {
                    if (currentBoard.Celles[i, j].Pieces.Count != 0 && currentBoard.Celles[i, j].Pieces.Peek().Color == player.Color)
                    {
                        for (int ii = 0; ii < 4; ii++)
                        {
                            for (int jj = 0; jj < 4; jj++)                      // to (ii, jj)
                            {
                                if (ii != i && jj != j && ValidMove.IsInternalMoveAvailble(currentBoard.Celles[ii, jj], currentBoard.Celles[i, j]))
                                    tempNextMoves.Add(Tuple.Create(currentBoard.Celles[i, j].Pieces.Peek().Size, new Move(currentBoard.Celles[i, j].Pieces.Peek(), currentBoard.Celles[i, j], currentBoard.Celles[ii, jj])));
                                    //nextMoves.Add(new Move(currentBoard.Celles[i, j].Pieces.Peek(), currentBoard.Celles[i, j], currentBoard.Celles[ii, jj]));
                            }
                        }
                    }
                }
            }
            tempNextMoves = tempNextMoves.OrderByDescending(x => x.Item1).ToList();
            foreach (var item in tempNextMoves)
            {
                nextMoves.Add(item.Item2);
            }
            return nextMoves;
        }
        //method to check the draw condition
      /*  public bool isDraw()
        {
            //check that white make the sequence of moves that lead to draw
            bool whiteCondition = (player1.previousMoves.first.from == player1.previousMoves.third.from);
            whiteCondition = whiteCondition && (player1.previousMoves.first.to == player1.previousMoves.third.to);
            whiteCondition = whiteCondition && (player1.previousMoves.second.to == player1.previousMoves.first.from);
            whiteCondition = whiteCondition && (player1.previousMoves.second.from == player1.previousMoves.first.to);

            //check that black make the sequence of moves that lead to draw
            bool blackCondition = (player2.previousMoves.first.from == player2.previousMoves.third.from);
            blackCondition = blackCondition && (player2.previousMoves.first.to == player2.previousMoves.third.to);
            blackCondition = blackCondition && (player2.previousMoves.second.to == player2.previousMoves.first.from);
            blackCondition = blackCondition && (player2.previousMoves.second.from == player2.previousMoves.first.to);

            //return true if both player make the sequence of draw
            return blackCondition && whiteCondition;
        }*/
    }
    public class Move
    {
        public Piece p;
        public Cell from;
        public Cell to;
        public int stack;
       /* public Move()
        {

        }*/

        public Move(Piece p, Cell from, Cell to, int stack = -1)
        {
            this.p = p;
            this.from = from;
            this.to = to;
            this.stack = stack;
        }
    }
    public class PreviousMoves
    {
      /*  public Move? first = GameState.dummy;
        public Move? second = GameState.dummy;
        public Move? third = GameState.dummy;


        public void addMove(Piece p, Cell from, Cell to)
        {
            first = second;
            second = third;
            third = new Move(p, from, to);
        }*/
    }
}

