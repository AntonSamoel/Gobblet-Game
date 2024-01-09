using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
    public class GameState
    {
        public Board currentBoard;
        public Player player1;
        public Player player2;
        public int alpha;
        public int beta;
        public int totalHeuristicScore; //heuristic
        public Move bestMove;
        public static Move dummy = new() {
            p = new Piece(99, 1, "player1", "white", Properties.Resources.w1),
            from = new Cell(20, 20),
            to = new Cell(20, 20)
        };
        Move lastMove = new();
    //TODO
    //constructors 
    //for gui initial gamestate

    //for Algorithm Create new Node State to test Move
    public GameState(Board b, Player player1, Player player2)
        {
            lastMove = dummy;
            if (player1.IsMyTurn)
            {
                player1.IsMyTurn = false;
                player2.IsMyTurn = true;
                if(player1.previousMoves.third != dummy)
                    lastMove = player1.previousMoves.third;
            }
            else
            {
                player1.IsMyTurn = true;
                player2.IsMyTurn = false;
                if (player2.previousMoves.third != dummy)
                    lastMove = player2.previousMoves.third;
            }
            if (lastMove != dummy)
            {
                if (lastMove is not null && lastMove.from is not null && lastMove.to is not null)
                {
                    int i = lastMove.from.Row;
                    int j = lastMove.from.Column;
                    Piece currentPiece = b.Celles[i, j].Pieces.Pop();
                    i = lastMove.to.Row;
                    j = lastMove.to.Column;
                    b.Celles[i, j].Pieces.Push(currentPiece);
                }
            }
            this.currentBoard = b;
            this.player1 = player1;
            this.player2 = player2;
        }


        //main work
        public int getBestMove(GameState gameState, int depth)
        {
            if (player1.IsMyTurn && (ValidMove.IsWinning("White", currentBoard.Celles) == "White")) return 2;
            else if (player2.IsMyTurn && (ValidMove.IsWinning("Black", currentBoard.Celles) == "Black")) return 2;
            else if (gameState.isDraw()) return 1;
            else if (depth == 0) return 0;

            //get all possible moves in this state
            List<Move> moves;
            int maxHeuristic = 0; //how many wins under this state
            Move maxMove = null; //hold the best move that achieve the max heuristic score
            if (player1.IsMyTurn)
            {
                moves = getNextMoves(player1);
                for (int i = 0; i < moves.Count; i++)
                {
                    GameState newState = new GameState(currentBoard, player1, player2); //create new state after playing this move
                    int currScore = getBestMove(newState, depth - 1); //calculate the heuristic score after making this move
                    if (currScore > maxHeuristic)
                    {
                        maxHeuristic = currScore;
                        maxMove = moves[i];
                    }
                }

            }
            else
            {
                moves = getNextMoves(player2);
                for (int i = 0; i < moves.Count; i++)
                {
                    GameState newState = new GameState(currentBoard, player1, player2); //create new state after playing this move
                    int currScore = getBestMove(newState, depth - 1); //calculate the heuristic score after making this move
                    if (currScore > maxHeuristic)
                    {
                        maxHeuristic = currScore;
                        maxMove = moves[i];
                    }
                }
            }
            totalHeuristicScore += maxHeuristic;
            bestMove = maxMove;
            return maxHeuristic;
        }


        //must return list of valid moves 
        //must return list of valid moves 
        List<Move> getNextMoves(Player player)
        {
            List<Move> nextMoves = new List<Move>();
            for (int k = 0; k < 3; k++)
            {
                Piece piece = player.Pieces[k].Peek();
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                    {
                        if (ValidMove.IsExternalMoveAvailble(currentBoard.Celles, currentBoard.Celles[i, j], piece))
                            nextMoves.Add(new Move(piece, null, currentBoard.Celles[i, j]));
                    }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)                                     // from (i, j)
                {
                    if (currentBoard.Celles[i, j].Color.Equals(player.Color))
                    {
                        for (int ii = 0; ii < 4; ii++)
                        {
                            for (int jj = 0; jj < 4; jj++)                      // to (ii, jj)
                            {
                                if (ii != i && jj != j && ValidMove.IsInternalMoveAvailble(currentBoard.Celles[i, j], currentBoard.Celles[ii, jj]))
                                    nextMoves.Add(new Move(currentBoard.Celles[i, j].Pieces.Peek(), currentBoard.Celles[i, j], currentBoard.Celles[ii, jj]));
                            }
                        }
                    }
                }
            }
            return nextMoves;
        }
        //method to check the draw condition
        public bool isDraw()
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
        }
    }
    public class Move
    {
        public Piece? p;
        public Cell? from;
        public Cell? to;
        public Move()
        {
               
        }

        public Move(Piece p, Cell from, Cell to)
        {
            this.p = p;
            this.from = from;
            this.to = to;
        }
    }
    public class PreviousMoves
    {
        public Move? first = GameState.dummy;
        public Move? second = GameState.dummy;
        public Move? third = GameState.dummy;

        
        public void addMove(Piece p, Cell from, Cell to)
        {
            first = second;
            second = third;
            third = new Move(p, from, to);
        }
    }
}

