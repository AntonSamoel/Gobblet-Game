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

        //Game constructor to game state with current board state 
    public GameState(Board b, Player player1, Player player2, bool reverse = false)
        {
            if (reverse)
            {
                player2.IsMyTurn = true;
                player1.IsMyTurn = false;
               // player1.IsMyTurn = !player1.IsMyTurn;
               // player2.IsMyTurn = !player2.IsMyTurn;
            }
            /*
            if (player1.IsMyTurn)
            {
                player1.IsMyTurn = false;
                player2.IsMyTurn = true;
                //if(player1.previousMoves.third != dummy) //not first move for player in the game
                 //   lastMove = player1.previousMoves.third;
            }
            else
            {
                player1.IsMyTurn = true;
                player2.IsMyTurn = false;
                //if (player2.previousMoves.third != dummy)
                 //   lastMove = player2.previousMoves.third;
            }*/
            /*if (lastMove != dummy)
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
            }*/
            this.currentBoard = b;
            this.player1 = player1;
            this.player2 = player2;
        }


        //main work
        public int getBestMove(GameState gameState, int depth)
        {
            if (player1.IsMyTurn && (ValidMove.IsWinning("black", gameState.currentBoard.Celles) == "black")) return (depth+1)*10;
            else if (player2.IsMyTurn && (ValidMove.IsWinning("white", gameState.currentBoard.Celles) == "white")) return (depth + 1) * -10;
            // else if (gameState.isDraw()) return 1;
            else if (depth == 0) return 0;

            //get all possible moves in this state
            List<Move> moves;
            moves = getNextMoves((player1.IsMyTurn? player1:player2), gameState.currentBoard);

            int maxHeuristic = 0;                       //how many wins under this state
            Move maxMove = null;                        //hold the best move that achieve the max heuristic score
            for (int i = 0; i < moves.Count; i++){
                /*
                 *  we've changed the current boards and the players turns on the fly
                Board tempBoard = HandleAI.copyBoard(currentBoard);
                Player tempPlayer1 = HandleAI.copyPlayer(player1);
                Player tempPlayer2 = HandleAI.copyPlayer(player2);

                GameState newState = new GameState(tempBoard, tempPlayer1, tempPlayer2); //create new state after playing this move
                */
                //make move on newState
                //Piece currentPiece = HandleAI.copyPiece(moves[i].p);
                int x, y;
                Piece tempPeice = null;
                if (moves[i].from is not null) {
                    x = moves[i].from.Row;
                    y = moves[i].from.Column;
                    if (currentBoard.Celles[x, y].Pieces.Count != 0) tempPeice=currentBoard.Celles[x, y].Pieces.Pop();
                }
                x = moves[i].to.Row;
                y = moves[i].to.Column;
                currentBoard.Celles[x, y].Pieces.Push(moves[i].p);
                player1.IsMyTurn = !player1.IsMyTurn;
                player2.IsMyTurn = !player2.IsMyTurn;
                maxHeuristic+= getBestMove(this, depth - 1); //calculate the heuristic score after making this move
                player1.IsMyTurn = !player1.IsMyTurn;
                player2.IsMyTurn = !player2.IsMyTurn;
                // should it work?

                currentBoard.Celles[x, y].Pieces.Pop();
                if (moves[i].from is not null)
                {
                    x = moves[i].from.Row;
                    y = moves[i].from.Column;
                    currentBoard.Celles[x, y].Pieces.Push(tempPeice);
                }

                if (maxHeuristic >= totalHeuristicScore)
                {
                    totalHeuristicScore = maxHeuristic;
                    bestMove = moves[i];
                }
            }
            return maxHeuristic;
        }


        //must return list of valid moves 
        //must return list of valid moves 
        List<Move> getNextMoves(Player player, Board currentBoard)
        {
            List<Move> nextMoves = new List<Move>();
            
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
                                    nextMoves.Add(new Move(currentBoard.Celles[i, j].Pieces.Peek(), currentBoard.Celles[i, j], currentBoard.Celles[ii, jj]));
                            }
                        }
                    }
                }
            }
            for (int k = 0; k < 3; k++)
            {
                if (player.Pieces[k].Count() == 0) continue;
                Piece piece = player.Pieces[k].Peek();
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                    {
                        if (ValidMove.IsExternalMoveAvailble(currentBoard.Celles, currentBoard.Celles[i, j], piece))
                            nextMoves.Add(new Move(piece, null, currentBoard.Celles[i, j]));
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

