VARIABLE SCORE

: RESET-SCORE ( -- 0 ) 
  0 SCORE !
  0
; 

: CLAIM-BONUS ( throw1, switch -- )
  *
  SCORE +!
;

: CALC-BONUS ( throw2, throw1 -- switch ) 
  + 10 =            \ boolean
  IF 1 ELSE 0 THEN  \ (1|0)      
;

: ADD-THROWS ( throw2, throw1 -- )
  +
  SCORE +!
;

: SCORE-FRAME ( switch, throw1, throw2 -- switch' ) 
  OVER 2>R          \ keep 1st throw, save throws values 
  SWAP CLAIM-BONUS 
  2R@ CALC-BONUS  
  2R> ADD-THROWS   
;
