# Gobblet-Game
Game-Playing Supported Algorithms
➢ Min-Max with Alpha-Beta algorithm to get the best move of the current player.
➢ The get next moves algorithm is used to get all the valid moves available for each player.
➢ Valid Moves Algorithms to make sure that players apply the right rules.
➢ Clone Algorithms to make a copy of the main objects.
➢ Helper Algorithms are used to serve the other algorithms.
Heuristics description and their benefit
1- We calculate the heuristic for each move and sum them together until we reach the 
maximum depth.
2- Each player searches for all his possible moves and then chooses the best move to make 
him a winner. This move has a heuristic value, he sums this value to the total score and 
passes the score to the next depth where the other player plays.
3- For example, If the depth is 3, the white player will play his best move depending on the 
calculated heuristic then add it to the score that is initially zero and pass that score to 
depth 2 where the black player does the same thing until we reach the maximum depth.
4- The White player represents the beta, so he tries to get the move with the minimum 
heuristic and the opposite with the black player.
5- Each move has a heuristic depending on the current situation of the board and the 
effect of that move.
6- Heuristic calculations as follows:
a. If the move prevents the opponent from a winning state, the heuristic equals the 
multiplication of the depth and the size of the piece.
b. If the move will the player win the game, it will return depth * 7 which is the 
highest heuristic of the game.
c. If the move prevents the opponent from a winning state but at the same time 
will give him a chance to win the heuristic will be small indicating that this move 
is bad.
d. There is a bonus heuristic assigned to the move:
i. If the move is in the middle of the board, it will return a higher heuristic 
value than the corner cells because it will have a bigger effect.
ii. Move of external pieces has a bonus than moving a piece in the board 
because it will increase the chances of winning as the player has more 
pieces.
7- Heuristic is signed according to the players, If the player is white it will be negative, 
otherwise it will be positive.
Supported Features 
➢ The game has three states:
o Player VS Player
o Player VS Computer
o Computer VS Computer
➢ The computer has three levels of difficulties:
o Easy
o Medium
o Hard
➢ You can restart the game or end the game.
Maximum Difficulty Level Supported
➢ Depth at 5
The level at which the AI will always win.
➢ Depth at 6 or more
