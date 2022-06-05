// Signature file for parser generated by fsyacc
module CPar
type token = 
  | EOF
  | LPAR
  | RPAR
  | LBRACE
  | RBRACE
  | LBRACK
  | RBRACK
  | SEMI
  | COMMA
  | ASSIGN
  | AMP
  | PLUSASSIGN
  | MINUSASSIGN
  | TIMESASSIGN
  | DIVASSIGN
  | NOT
  | SEQOR
  | SEQAND
  | QUESTION
  | COLON
  | EQ
  | NE
  | GT
  | LT
  | GE
  | LE
  | POW
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | MOD
  | ONEPLUS
  | ONEMINUS
  | WHILE
  | FOR
  | IN
  | DO
  | DOUNTIL
  | DOWHILE
  | UNTIL
  | SWITCH
  | CASE
  | LEN
  | CHAR
  | ELSE
  | IF
  | INT
  | NULL
  | PRINT
  | PRINTLN
  | RETURN
  | VOID
  | RANGE
  | DEFAULT
  | CONTINUE
  | EXIT
  | PASS
  | CSTSTRING of (string)
  | NAME of (string)
  | CSTCHAR of (char)
  | CSTINT of (int)
  | CSTBOOL of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_SEMI
    | TOKEN_COMMA
    | TOKEN_ASSIGN
    | TOKEN_AMP
    | TOKEN_PLUSASSIGN
    | TOKEN_MINUSASSIGN
    | TOKEN_TIMESASSIGN
    | TOKEN_DIVASSIGN
    | TOKEN_NOT
    | TOKEN_SEQOR
    | TOKEN_SEQAND
    | TOKEN_QUESTION
    | TOKEN_COLON
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_GT
    | TOKEN_LT
    | TOKEN_GE
    | TOKEN_LE
    | TOKEN_POW
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_ONEPLUS
    | TOKEN_ONEMINUS
    | TOKEN_WHILE
    | TOKEN_FOR
    | TOKEN_IN
    | TOKEN_DO
    | TOKEN_DOUNTIL
    | TOKEN_DOWHILE
    | TOKEN_UNTIL
    | TOKEN_SWITCH
    | TOKEN_CASE
    | TOKEN_LEN
    | TOKEN_CHAR
    | TOKEN_ELSE
    | TOKEN_IF
    | TOKEN_INT
    | TOKEN_NULL
    | TOKEN_PRINT
    | TOKEN_PRINTLN
    | TOKEN_RETURN
    | TOKEN_VOID
    | TOKEN_RANGE
    | TOKEN_DEFAULT
    | TOKEN_CONTINUE
    | TOKEN_EXIT
    | TOKEN_PASS
    | TOKEN_CSTSTRING
    | TOKEN_NAME
    | TOKEN_CSTCHAR
    | TOKEN_CSTINT
    | TOKEN_CSTBOOL
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Topdecs
    | NONTERM_Topdec
    | NONTERM_Vardec
    | NONTERM_Vardesc
    | NONTERM_Fundec
    | NONTERM_Paramdecs
    | NONTERM_Paramdecs1
    | NONTERM_Block
    | NONTERM_StmtOrDecSeq
    | NONTERM_Stmt
    | NONTERM_StmtM
    | NONTERM_StmtU
    | NONTERM_Expr
    | NONTERM_ExprNotAccess
    | NONTERM_AtExprNotAccess
    | NONTERM_Access
    | NONTERM_Exprs
    | NONTERM_Exprs1
    | NONTERM_Const
    | NONTERM_Type
    | NONTERM_StmtS
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (Absyn.program) 
