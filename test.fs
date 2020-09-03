REQUIRE ffl/tst.fs
REQUIRE bowling.fs
\ normal
\ x + y < 10 - std score
\ x + y = 10 - spare 
\ x     = 10 - strike

PAGE    \ Clears the screen
: CHECK ( x,y -- x ) OVER ?S ;
T{
." Average frame counts both throws for scoring " CR
RESET-SCORE 
3 5 SCORE-FRAME 
0 ?S SCORE @ 8 ?S
}T

T{ 
." Spare frame counts the next frame score twice " CR
RESET-SCORE
6 4 SCORE-FRAME 
DUP 1 ?S SCORE @ 10 ?S 
3 2 SCORE-FRAME 
0 ?S SCORE @ 18 ?S
}T
 
BYE
