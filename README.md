Test Driven development with gforth

# The bowling score kata

A game of bowling consists of ten frames. In each frame, the bowler will have two chances to knock down as many pins as possible with their bowling ball. In games with more than one bowler, as is common, every bowler will take their frame in a predetermined order before the next frame begins. If a bowler is able to knock down all ten pins with their first ball, he is awarded a strike. If the bowler is able to knock down all 10 pins with the two balls of a frame, it is known as a spare. Bonus points are awarded for both of these, depending on what is scored in the next 2 balls (for a strike) or 1 ball (for a spare). If the bowler knocks down all 10 pins in the tenth frame, the bowler is allowed to throw 3 balls for that frame. This allows for a potential of 12 strikes in a single game, and a maximum score of 300 points, a perfect game.

(source:[https://www.playerssports.net/page/bowling-rules#:~:text=Rules%20of%20play,before%20the%20next%20frame%20begins.])

Write a program which, given a series of rolls delivered by a player, computes the score of this player. The roll values will be consistent with the game rules: no entry will contain values that would not be possible in a real game (e.g 11, or 7 then 6 in the same frame, or more than ten frames of rolls). In test cases where not all rolls have been played, the resulting value should be the minimum score obtained (the score value if all the subsequent rolls were 0).

## Input

- *t* – the number of test cases, then t test cases follows.
- each test case consists in 2 lines:
    - *n* - the number of rolls delivered, ( 0 < *n* ≤ 21 )
    - *r1*,..*rn* - the rolls delivered    ( 0 ≤ *r* ≤ 10 ) 

## Output

For each test case output one integer: the score made given the test case rolls.

## Example
### Input

    3
    2
    4 6
    4
    10 3 7 5
    12
    10 10 10 10 10 10 10 10 10 10 10 10

### Output

    10
    40
    300
