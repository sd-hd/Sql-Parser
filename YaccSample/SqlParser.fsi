// Signature file for parser generated by fsyacc
module SqlParser
type token = 
  | EOF
  | NEXT
  | PRIOR
  | FIRST
  | LAST
  | ABSOLUTE
  | RELATIVE
  | READ_ONLY
  | SCROLL_LOCKS
  | OPTIMISTIC
  | TYPE_WARNING
  | OPEN
  | CLOSE
  | DEALLOCATE
  | FETCH
  | CURSOR
  | LOCAL
  | GLOBAL
  | FORWARD_ONLY
  | SCROLL
  | STATIC
  | KEYSET
  | DYNAMIC
  | FAST_FORWARD
  | EXEC
  | EXECUTE
  | RECOMPILE
  | OUTPUT
  | TRAN
  | TRANSACTION
  | ROLLBACK
  | COMMIT
  | MARK
  | SAVE
  | WORK
  | TABLOCK
  | TABLOCKX
  | UPDLOCK
  | XLOCK
  | FORCESEEK
  | NOEXPAND
  | FORCESCAN
  | READCOMMITTEDLOCK
  | READUNCOMMITTED
  | READPAST
  | REPEATABLEREAD
  | ROWLOCK
  | SERIALIZABLE
  | IGNORE_CONSTRAINTS
  | IGNORE_TRIGGERS
  | NOWAIT
  | PAGLOCK
  | READCOMMITTED
  | NOLOCK
  | INDEX
  | KEEPIDENTITY
  | KEEPDEFAULTS
  | FASTFIRSTROW
  | HOLDLOCK
  | RANK
  | NTILE
  | DENSE_RANK
  | ROW_NUMBER
  | PARTITION
  | OVER
  | DOUBLEQUOTE
  | QUOTE
  | NOCOUNT
  | QUOTED_IDENTIFIER
  | ANSI_NULLS
  | GO
  | FOR
  | AFTER
  | REPLICATION
  | OFF
  | INSTEAD
  | OF
  | CREATE
  | DROP
  | ALTER
  | TABLE
  | PROC
  | PROCEDURE
  | TRIGGER
  | VIEW
  | TYPE
  | FUNCTION
  | WITH
  | IF
  | ELSE
  | WHILE
  | BEGIN
  | END
  | TRY
  | CATCH
  | RAISERROR
  | PRINT
  | EXCEPT
  | UNION
  | INTERSECT
  | AS
  | DECLARE
  | ASC
  | DESC
  | DEFAULT
  | NULL
  | INSERT
  | INTO
  | UPDATE
  | DELETE
  | VALUES
  | SET
  | SELECT
  | TOP
  | PERCENT
  | DISTINCT
  | FROM
  | WHERE
  | GROUP
  | HAVING
  | ORDER
  | BY
  | JOIN
  | INNER
  | LEFT
  | RIGHT
  | CROSS
  | FULL
  | APPLY
  | OUTER
  | ON
  | EXISTS
  | ALL
  | ANY
  | BETWEEN
  | IN
  | LIKE
  | SOME
  | EQ
  | LT
  | LE
  | GT
  | GE
  | LTGT
  | NE
  | NLT
  | NGT
  | COMMA
  | LPAREN
  | RPAREN
  | AT
  | SEMI
  | PLUS_EQ
  | MINUS_EQ
  | STAR_EQ
  | DIV_EQ
  | MOD_EQ
  | AND_EQ
  | XOR_EQ
  | OR_EQ
  | BIT_NOT
  | BIT_AND
  | BIT_XOR
  | BIT_OR
  | NOT
  | PLUS
  | MINUS
  | DIV
  | STAR
  | MODULO
  | AND
  | OR
  | FLOAT of (float)
  | INT of (int)
  | STRING of (string)
  | ID of (string)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_NEXT
    | TOKEN_PRIOR
    | TOKEN_FIRST
    | TOKEN_LAST
    | TOKEN_ABSOLUTE
    | TOKEN_RELATIVE
    | TOKEN_READ_ONLY
    | TOKEN_SCROLL_LOCKS
    | TOKEN_OPTIMISTIC
    | TOKEN_TYPE_WARNING
    | TOKEN_OPEN
    | TOKEN_CLOSE
    | TOKEN_DEALLOCATE
    | TOKEN_FETCH
    | TOKEN_CURSOR
    | TOKEN_LOCAL
    | TOKEN_GLOBAL
    | TOKEN_FORWARD_ONLY
    | TOKEN_SCROLL
    | TOKEN_STATIC
    | TOKEN_KEYSET
    | TOKEN_DYNAMIC
    | TOKEN_FAST_FORWARD
    | TOKEN_EXEC
    | TOKEN_EXECUTE
    | TOKEN_RECOMPILE
    | TOKEN_OUTPUT
    | TOKEN_TRAN
    | TOKEN_TRANSACTION
    | TOKEN_ROLLBACK
    | TOKEN_COMMIT
    | TOKEN_MARK
    | TOKEN_SAVE
    | TOKEN_WORK
    | TOKEN_TABLOCK
    | TOKEN_TABLOCKX
    | TOKEN_UPDLOCK
    | TOKEN_XLOCK
    | TOKEN_FORCESEEK
    | TOKEN_NOEXPAND
    | TOKEN_FORCESCAN
    | TOKEN_READCOMMITTEDLOCK
    | TOKEN_READUNCOMMITTED
    | TOKEN_READPAST
    | TOKEN_REPEATABLEREAD
    | TOKEN_ROWLOCK
    | TOKEN_SERIALIZABLE
    | TOKEN_IGNORE_CONSTRAINTS
    | TOKEN_IGNORE_TRIGGERS
    | TOKEN_NOWAIT
    | TOKEN_PAGLOCK
    | TOKEN_READCOMMITTED
    | TOKEN_NOLOCK
    | TOKEN_INDEX
    | TOKEN_KEEPIDENTITY
    | TOKEN_KEEPDEFAULTS
    | TOKEN_FASTFIRSTROW
    | TOKEN_HOLDLOCK
    | TOKEN_RANK
    | TOKEN_NTILE
    | TOKEN_DENSE_RANK
    | TOKEN_ROW_NUMBER
    | TOKEN_PARTITION
    | TOKEN_OVER
    | TOKEN_DOUBLEQUOTE
    | TOKEN_QUOTE
    | TOKEN_NOCOUNT
    | TOKEN_QUOTED_IDENTIFIER
    | TOKEN_ANSI_NULLS
    | TOKEN_GO
    | TOKEN_FOR
    | TOKEN_AFTER
    | TOKEN_REPLICATION
    | TOKEN_OFF
    | TOKEN_INSTEAD
    | TOKEN_OF
    | TOKEN_CREATE
    | TOKEN_DROP
    | TOKEN_ALTER
    | TOKEN_TABLE
    | TOKEN_PROC
    | TOKEN_PROCEDURE
    | TOKEN_TRIGGER
    | TOKEN_VIEW
    | TOKEN_TYPE
    | TOKEN_FUNCTION
    | TOKEN_WITH
    | TOKEN_IF
    | TOKEN_ELSE
    | TOKEN_WHILE
    | TOKEN_BEGIN
    | TOKEN_END
    | TOKEN_TRY
    | TOKEN_CATCH
    | TOKEN_RAISERROR
    | TOKEN_PRINT
    | TOKEN_EXCEPT
    | TOKEN_UNION
    | TOKEN_INTERSECT
    | TOKEN_AS
    | TOKEN_DECLARE
    | TOKEN_ASC
    | TOKEN_DESC
    | TOKEN_DEFAULT
    | TOKEN_NULL
    | TOKEN_INSERT
    | TOKEN_INTO
    | TOKEN_UPDATE
    | TOKEN_DELETE
    | TOKEN_VALUES
    | TOKEN_SET
    | TOKEN_SELECT
    | TOKEN_TOP
    | TOKEN_PERCENT
    | TOKEN_DISTINCT
    | TOKEN_FROM
    | TOKEN_WHERE
    | TOKEN_GROUP
    | TOKEN_HAVING
    | TOKEN_ORDER
    | TOKEN_BY
    | TOKEN_JOIN
    | TOKEN_INNER
    | TOKEN_LEFT
    | TOKEN_RIGHT
    | TOKEN_CROSS
    | TOKEN_FULL
    | TOKEN_APPLY
    | TOKEN_OUTER
    | TOKEN_ON
    | TOKEN_EXISTS
    | TOKEN_ALL
    | TOKEN_ANY
    | TOKEN_BETWEEN
    | TOKEN_IN
    | TOKEN_LIKE
    | TOKEN_SOME
    | TOKEN_EQ
    | TOKEN_LT
    | TOKEN_LE
    | TOKEN_GT
    | TOKEN_GE
    | TOKEN_LTGT
    | TOKEN_NE
    | TOKEN_NLT
    | TOKEN_NGT
    | TOKEN_COMMA
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_AT
    | TOKEN_SEMI
    | TOKEN_PLUS_EQ
    | TOKEN_MINUS_EQ
    | TOKEN_STAR_EQ
    | TOKEN_DIV_EQ
    | TOKEN_MOD_EQ
    | TOKEN_AND_EQ
    | TOKEN_XOR_EQ
    | TOKEN_OR_EQ
    | TOKEN_BIT_NOT
    | TOKEN_BIT_AND
    | TOKEN_BIT_XOR
    | TOKEN_BIT_OR
    | TOKEN_NOT
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_DIV
    | TOKEN_STAR
    | TOKEN_MODULO
    | TOKEN_AND
    | TOKEN_OR
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_STRING
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_statementlist
    | NONTERM_statementBlock
    | NONTERM_openStmt
    | NONTERM_closeStmt
    | NONTERM_simpleStmtBlock
    | NONTERM_simpleStmt
    | NONTERM_dmlStmtCTE
    | NONTERM_dmlStmt
    | NONTERM_tranStmt
    | NONTERM_tranVar
    | NONTERM_beginTran
    | NONTERM_withMarkOpt
    | NONTERM_commitTran
    | NONTERM_commitWork
    | NONTERM_rollBackWork
    | NONTERM_rollBackTran
    | NONTERM_saveTran
    | NONTERM_varDecl
    | NONTERM_variable
    | NONTERM_variableList
    | NONTERM_cursorStmt
    | NONTERM_cursorName
    | NONTERM_cursorDecl
    | NONTERM_cursorVisibilityOpt
    | NONTERM_cursorMovementOpt
    | NONTERM_cursorResultOpt
    | NONTERM_cursorLocksOpt
    | NONTERM_cursorWarningOpt
    | NONTERM_openCursor
    | NONTERM_closeCursor
    | NONTERM_releaseCursor
    | NONTERM_fetch
    | NONTERM_fetchIntoOpt
    | NONTERM_fetchDirectionOpt
    | NONTERM_fetchDirection
    | NONTERM_executeStmt
    | NONTERM_executeProc
    | NONTERM_execModuleName
    | NONTERM_execParamListOpt
    | NONTERM_execParam
    | NONTERM_execParamValue
    | NONTERM_execRecompileOpt
    | NONTERM_executeSql
    | NONTERM_advancedString
    | NONTERM_execute
    | NONTERM_compareOperator
    | NONTERM_logicalOperator
    | NONTERM_simpleLogicalOperator
    | NONTERM_specialLogicalOperator
    | NONTERM_assignmentOperator
    | NONTERM_arithOperator
    | NONTERM_bitOperator
    | NONTERM_binaryOperator
    | NONTERM_unaryOperator
    | NONTERM_value
    | NONTERM_valueExpr
    | NONTERM_conditionValue
    | NONTERM_condition
    | NONTERM_conditionList
    | NONTERM_tableHintOpt
    | NONTERM_tableHint
    | NONTERM_tableHintList
    | NONTERM_tableHintItem
    | NONTERM_commonTableExpr
    | NONTERM_tableExprList
    | NONTERM_tableExpr
    | NONTERM_fromOpt
    | NONTERM_insert
    | NONTERM_insertHead
    | NONTERM_insertValues
    | NONTERM_insertValueList
    | NONTERM_update
    | NONTERM_updateExpr
    | NONTERM_updateList
    | NONTERM_delete
    | NONTERM_overClause
    | NONTERM_windowFunction
    | NONTERM_queryColumn
    | NONTERM_queryColumnList
    | NONTERM_query
    | NONTERM_topClauseOpt
    | NONTERM_topClause
    | NONTERM_topClauseAltOpt
    | NONTERM_topClauseAlt
    | NONTERM_queryOptions
    | NONTERM_queryModifiers
    | NONTERM_tableSource
    | NONTERM_tableSourceList
    | NONTERM_tableSourceElem
    | NONTERM_joinList
    | NONTERM_joinClause
    | NONTERM_joinOnClause
    | NONTERM_whereClause
    | NONTERM_groupByClause
    | NONTERM_havingClause
    | NONTERM_orderByClauseOpt
    | NONTERM_orderByClause
    | NONTERM_orderByList
    | NONTERM_orderBy
    | NONTERM_identifierList
    | NONTERM_aliasedIdentifier
    | NONTERM_setSessionVar
    | NONTERM_onOffOption
    | NONTERM_batch
    | NONTERM_batchBlock
    | NONTERM_ddlOperation
    | NONTERM_createTrigger
    | NONTERM_alterTrigger
    | NONTERM_dropTrigger
    | NONTERM_triggerType
    | NONTERM_triggerTypeDecl
    | NONTERM_triggerBody
    | NONTERM_createProcedure
    | NONTERM_alterProcedure
    | NONTERM_dropProcedure
    | NONTERM_createView
    | NONTERM_alterView
    | NONTERM_dropView
    | NONTERM_createTable
    | NONTERM_alterTable
    | NONTERM_dropTable
    | NONTERM_createType
    | NONTERM_alterType
    | NONTERM_dropType
    | NONTERM_createFunction
    | NONTERM_alterFunction
    | NONTERM_dropFunction
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (Sql.sqlStatement list) 
