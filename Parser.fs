// Implementation file for parser generated by fsyacc
module Parser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open FSharp.Text.Lexing
open FSharp.Text.Parsing.ParseHelpers
# 1 "Parser.fsy"


# 9 "Parser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | EOF
  | PLUS
  | MINUS
  | MULT
  | DIV
  | MOD
  | EQEQ
  | BANGEQ
  | LT
  | LE
  | GT
  | GE
  | ANDAND
  | OROR
  | LPAR
  | RPAR
  | COMMA
  | EQ
  | SEMICOLON
  | ELSE
  | FALSE
  | FUNC
  | IF
  | IN
  | LET
  | READ
  | THEN
  | TRUE
  | WRITE
  | NAME of (string)
  | INT of (int)
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_MULT
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_EQEQ
    | TOKEN_BANGEQ
    | TOKEN_LT
    | TOKEN_LE
    | TOKEN_GT
    | TOKEN_GE
    | TOKEN_ANDAND
    | TOKEN_OROR
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_COMMA
    | TOKEN_EQ
    | TOKEN_SEMICOLON
    | TOKEN_ELSE
    | TOKEN_FALSE
    | TOKEN_FUNC
    | TOKEN_IF
    | TOKEN_IN
    | TOKEN_LET
    | TOKEN_READ
    | TOKEN_THEN
    | TOKEN_TRUE
    | TOKEN_WRITE
    | TOKEN_NAME
    | TOKEN_INT
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_program
    | NONTERM_definition
    | NONTERM_definitions
    | NONTERM_expression
    | NONTERM_expression_list
    | NONTERM_expressions
    | NONTERM_name_list
    | NONTERM_names

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | PLUS  -> 1 
  | MINUS  -> 2 
  | MULT  -> 3 
  | DIV  -> 4 
  | MOD  -> 5 
  | EQEQ  -> 6 
  | BANGEQ  -> 7 
  | LT  -> 8 
  | LE  -> 9 
  | GT  -> 10 
  | GE  -> 11 
  | ANDAND  -> 12 
  | OROR  -> 13 
  | LPAR  -> 14 
  | RPAR  -> 15 
  | COMMA  -> 16 
  | EQ  -> 17 
  | SEMICOLON  -> 18 
  | ELSE  -> 19 
  | FALSE  -> 20 
  | FUNC  -> 21 
  | IF  -> 22 
  | IN  -> 23 
  | LET  -> 24 
  | READ  -> 25 
  | THEN  -> 26 
  | TRUE  -> 27 
  | WRITE  -> 28 
  | NAME _ -> 29 
  | INT _ -> 30 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_PLUS 
  | 2 -> TOKEN_MINUS 
  | 3 -> TOKEN_MULT 
  | 4 -> TOKEN_DIV 
  | 5 -> TOKEN_MOD 
  | 6 -> TOKEN_EQEQ 
  | 7 -> TOKEN_BANGEQ 
  | 8 -> TOKEN_LT 
  | 9 -> TOKEN_LE 
  | 10 -> TOKEN_GT 
  | 11 -> TOKEN_GE 
  | 12 -> TOKEN_ANDAND 
  | 13 -> TOKEN_OROR 
  | 14 -> TOKEN_LPAR 
  | 15 -> TOKEN_RPAR 
  | 16 -> TOKEN_COMMA 
  | 17 -> TOKEN_EQ 
  | 18 -> TOKEN_SEMICOLON 
  | 19 -> TOKEN_ELSE 
  | 20 -> TOKEN_FALSE 
  | 21 -> TOKEN_FUNC 
  | 22 -> TOKEN_IF 
  | 23 -> TOKEN_IN 
  | 24 -> TOKEN_LET 
  | 25 -> TOKEN_READ 
  | 26 -> TOKEN_THEN 
  | 27 -> TOKEN_TRUE 
  | 28 -> TOKEN_WRITE 
  | 29 -> TOKEN_NAME 
  | 30 -> TOKEN_INT 
  | 33 -> TOKEN_end_of_input
  | 31 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | 2 -> NONTERM_program 
    | 3 -> NONTERM_definition 
    | 4 -> NONTERM_definitions 
    | 5 -> NONTERM_definitions 
    | 6 -> NONTERM_expression 
    | 7 -> NONTERM_expression 
    | 8 -> NONTERM_expression 
    | 9 -> NONTERM_expression 
    | 10 -> NONTERM_expression 
    | 11 -> NONTERM_expression 
    | 12 -> NONTERM_expression_list 
    | 13 -> NONTERM_expression_list 
    | 14 -> NONTERM_expressions 
    | 15 -> NONTERM_expressions 
    | 16 -> NONTERM_name_list 
    | 17 -> NONTERM_name_list 
    | 18 -> NONTERM_names 
    | 19 -> NONTERM_names 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 33 
let _fsyacc_tagOfErrorTerminal = 31

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | PLUS  -> "PLUS" 
  | MINUS  -> "MINUS" 
  | MULT  -> "MULT" 
  | DIV  -> "DIV" 
  | MOD  -> "MOD" 
  | EQEQ  -> "EQEQ" 
  | BANGEQ  -> "BANGEQ" 
  | LT  -> "LT" 
  | LE  -> "LE" 
  | GT  -> "GT" 
  | GE  -> "GE" 
  | ANDAND  -> "ANDAND" 
  | OROR  -> "OROR" 
  | LPAR  -> "LPAR" 
  | RPAR  -> "RPAR" 
  | COMMA  -> "COMMA" 
  | EQ  -> "EQ" 
  | SEMICOLON  -> "SEMICOLON" 
  | ELSE  -> "ELSE" 
  | FALSE  -> "FALSE" 
  | FUNC  -> "FUNC" 
  | IF  -> "IF" 
  | IN  -> "IN" 
  | LET  -> "LET" 
  | READ  -> "READ" 
  | THEN  -> "THEN" 
  | TRUE  -> "TRUE" 
  | WRITE  -> "WRITE" 
  | NAME _ -> "NAME" 
  | INT _ -> "INT" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | PLUS  -> (null : System.Object) 
  | MINUS  -> (null : System.Object) 
  | MULT  -> (null : System.Object) 
  | DIV  -> (null : System.Object) 
  | MOD  -> (null : System.Object) 
  | EQEQ  -> (null : System.Object) 
  | BANGEQ  -> (null : System.Object) 
  | LT  -> (null : System.Object) 
  | LE  -> (null : System.Object) 
  | GT  -> (null : System.Object) 
  | GE  -> (null : System.Object) 
  | ANDAND  -> (null : System.Object) 
  | OROR  -> (null : System.Object) 
  | LPAR  -> (null : System.Object) 
  | RPAR  -> (null : System.Object) 
  | COMMA  -> (null : System.Object) 
  | EQ  -> (null : System.Object) 
  | SEMICOLON  -> (null : System.Object) 
  | ELSE  -> (null : System.Object) 
  | FALSE  -> (null : System.Object) 
  | FUNC  -> (null : System.Object) 
  | IF  -> (null : System.Object) 
  | IN  -> (null : System.Object) 
  | LET  -> (null : System.Object) 
  | READ  -> (null : System.Object) 
  | THEN  -> (null : System.Object) 
  | TRUE  -> (null : System.Object) 
  | WRITE  -> (null : System.Object) 
  | NAME _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | INT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; 1us; 65535us; 0us; 2us; 2us; 65535us; 0us; 14us; 14us; 14us; 2us; 65535us; 0us; 4us; 14us; 15us; 7us; 65535us; 4us; 5us; 11us; 12us; 18us; 19us; 25us; 21us; 26us; 22us; 29us; 23us; 30us; 24us; 0us; 65535us; 0us; 65535us; 0us; 65535us; 0us; 65535us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; 3us; 5us; 8us; 11us; 19us; 20us; 21us; 22us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; 1us; 1us; 1us; 1us; 1us; 2us; 3us; 2us; 9us; 10us; 1us; 3us; 1us; 3us; 1us; 3us; 1us; 3us; 1us; 3us; 1us; 3us; 3us; 3us; 9us; 10us; 1us; 3us; 1us; 5us; 1us; 5us; 1us; 6us; 1us; 7us; 1us; 8us; 3us; 8us; 9us; 10us; 1us; 8us; 3us; 9us; 9us; 10us; 3us; 9us; 10us; 10us; 3us; 9us; 10us; 11us; 3us; 9us; 10us; 11us; 1us; 9us; 1us; 10us; 1us; 11us; 1us; 11us; 1us; 11us; 1us; 11us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; 4us; 6us; 8us; 10us; 14us; 16us; 18us; 20us; 22us; 24us; 26us; 30us; 32us; 34us; 36us; 38us; 40us; 42us; 46us; 48us; 52us; 56us; 60us; 64us; 66us; 68us; 70us; 72us; 74us; |]
let _fsyacc_action_rows = 31
let _fsyacc_actionTableElements = [|1us; 16388us; 21us; 6us; 0us; 49152us; 1us; 32768us; 0us; 3us; 0us; 16385us; 4us; 32768us; 14us; 18us; 24us; 27us; 29us; 17us; 30us; 16us; 2us; 16386us; 1us; 25us; 3us; 26us; 1us; 32768us; 29us; 7us; 1us; 32768us; 14us; 8us; 1us; 32768us; 29us; 9us; 1us; 32768us; 15us; 10us; 1us; 32768us; 17us; 11us; 4us; 32768us; 14us; 18us; 24us; 27us; 29us; 17us; 30us; 16us; 3us; 32768us; 1us; 25us; 3us; 26us; 18us; 13us; 0us; 16387us; 1us; 16388us; 21us; 6us; 0us; 16389us; 0us; 16390us; 0us; 16391us; 4us; 32768us; 14us; 18us; 24us; 27us; 29us; 17us; 30us; 16us; 3us; 32768us; 1us; 25us; 3us; 26us; 15us; 20us; 0us; 16392us; 1us; 16393us; 3us; 26us; 0us; 16394us; 3us; 32768us; 1us; 25us; 3us; 26us; 23us; 30us; 2us; 16395us; 1us; 25us; 3us; 26us; 4us; 32768us; 14us; 18us; 24us; 27us; 29us; 17us; 30us; 16us; 4us; 32768us; 14us; 18us; 24us; 27us; 29us; 17us; 30us; 16us; 1us; 32768us; 29us; 28us; 1us; 32768us; 17us; 29us; 4us; 32768us; 14us; 18us; 24us; 27us; 29us; 17us; 30us; 16us; 4us; 32768us; 14us; 18us; 24us; 27us; 29us; 17us; 30us; 16us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 2us; 3us; 5us; 6us; 11us; 14us; 16us; 18us; 20us; 22us; 24us; 29us; 33us; 34us; 36us; 37us; 38us; 39us; 44us; 48us; 49us; 51us; 52us; 56us; 59us; 64us; 69us; 71us; 73us; 78us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 2us; 2us; 8us; 0us; 2us; 1us; 1us; 3us; 3us; 3us; 6us; 1us; 3us; 0us; 1us; 1us; 3us; 0us; 1us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; 2us; 3us; 4us; 4us; 5us; 5us; 5us; 5us; 5us; 5us; 6us; 6us; 7us; 7us; 8us; 8us; 9us; 9us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; 65535us; 16385us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 16387us; 65535us; 16389us; 16390us; 16391us; 65535us; 65535us; 16392us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; 65535us; |]
let _fsyacc_reductions ()  =    [| 
# 272 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.prog in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : 'gentype__startstart));
# 281 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.prog in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 43 "Parser.fsy"
                                                             _1 
                   )
# 43 "Parser.fsy"
                 : Syntax.prog));
# 292 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.def list in
            let _2 = parseState.GetInput(2) :?> Syntax.exp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 46 "Parser.fsy"
                                                             Syntax.PROG (_1, _2) 
                   )
# 46 "Parser.fsy"
                 : Syntax.prog));
# 304 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> string in
            let _4 = parseState.GetInput(4) :?> string in
            let _7 = parseState.GetInput(7) :?> Syntax.exp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 49 "Parser.fsy"
                                                                            Syntax.FUNC (_2, (_4, _7)) 
                   )
# 49 "Parser.fsy"
                 : Syntax.def));
# 317 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 52 "Parser.fsy"
                                                             [] 
                   )
# 52 "Parser.fsy"
                 : Syntax.def list));
# 327 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.def in
            let _2 = parseState.GetInput(2) :?> Syntax.def list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 53 "Parser.fsy"
                                                             _1 :: _2 
                   )
# 53 "Parser.fsy"
                 : Syntax.def list));
# 339 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> int in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 56 "Parser.fsy"
                                                             Syntax.INT _1 
                   )
# 56 "Parser.fsy"
                 : Syntax.exp));
# 350 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 57 "Parser.fsy"
                                                             Syntax.VAR _1 
                   )
# 57 "Parser.fsy"
                 : Syntax.exp));
# 361 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> Syntax.exp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 58 "Parser.fsy"
                                                             _2 
                   )
# 58 "Parser.fsy"
                 : Syntax.exp));
# 372 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.exp in
            let _3 = parseState.GetInput(3) :?> Syntax.exp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 59 "Parser.fsy"
                                                             Syntax.ADD(_1, _3) 
                   )
# 59 "Parser.fsy"
                 : Syntax.exp));
# 384 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.exp in
            let _3 = parseState.GetInput(3) :?> Syntax.exp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 60 "Parser.fsy"
                                                             Syntax.MULT(_1, _3) 
                   )
# 60 "Parser.fsy"
                 : Syntax.exp));
# 396 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> string in
            let _4 = parseState.GetInput(4) :?> Syntax.exp in
            let _6 = parseState.GetInput(6) :?> Syntax.exp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 61 "Parser.fsy"
                                                                Syntax.LET(_2, _4, _6)
                   )
# 61 "Parser.fsy"
                 : Syntax.exp));
# 409 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.exp in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 64 "Parser.fsy"
                                                             [_1] 
                   )
# 64 "Parser.fsy"
                 : Syntax.exp list));
# 420 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.exp in
            let _3 = parseState.GetInput(3) :?> Syntax.exp list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 65 "Parser.fsy"
                                                             _1 :: _3 
                   )
# 65 "Parser.fsy"
                 : Syntax.exp list));
# 432 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 68 "Parser.fsy"
                                                             [] 
                   )
# 68 "Parser.fsy"
                 : Syntax.exp list));
# 442 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.exp list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 69 "Parser.fsy"
                                                             _1 
                   )
# 69 "Parser.fsy"
                 : Syntax.exp list));
# 453 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 72 "Parser.fsy"
                                                             [_1] 
                   )
# 72 "Parser.fsy"
                 : Syntax.name list));
# 464 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            let _3 = parseState.GetInput(3) :?> Syntax.name list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 73 "Parser.fsy"
                                                             _1 :: _3 
                   )
# 73 "Parser.fsy"
                 : Syntax.name list));
# 476 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 76 "Parser.fsy"
                                                             [] 
                   )
# 76 "Parser.fsy"
                 : Syntax.name list));
# 486 "Parser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Syntax.name list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 77 "Parser.fsy"
                                                             _1 
                   )
# 77 "Parser.fsy"
                 : Syntax.name list));
|]
# 498 "Parser.fs"
let tables : FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 34;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = tables.Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : Syntax.prog =
    engine lexer lexbuf 0 :?> _
