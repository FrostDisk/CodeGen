PRINT N'Stored Procedure [dbo].[{SAVE_STORED_PROCEDURE}]'
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{SAVE_STORED_PROCEDURE}]') AND TYPE IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[{SAVE_STORED_PROCEDURE}]  
GO
CREATE PROCEDURE [dbo].[{SAVE_STORED_PROCEDURE}]
(/*-- BEGIN SECTION PARAMETERS */
    /*-- BEGIN SECTION DEFAULT AS VAR */
   @{VAR.PARAMETERNAME} {VAR.DATATYPE}/*-- END SECTION DEFAULT */
    /*-- END SECTION PARAMETERS */
)
AS
-- =============================================
-- Author         : {AUTHOR_NAME}
-- Creation Date  : {CREATION_DATE}
-- Main Entity    : {ENTITY_NAME}
-- Description    : Save Entity into Database
-- =============================================
-- Modified by    :
-- Modified Date  :
-- Description    :
-- =============================================
BEGIN

    SET NOCOUNT ON;

    DECLARE @identity {PRIMARYKEY_DATATYPE}

    SET @identity = {PRIMARYKEY_DATATYPE}

    IF @identity > 0
    BEGIN
        UPDATE {ENTITY_NAME} SET /*-- BEGIN SECTION UPDATE_PARAMETERS */
            /*-- BEGIN SECTION DEFAULT AS VAR */
            {VAR.PROPERTYNAME} = @{VAR.PARAMETERNAME}/*-- END SECTION DEFAULT */
            /*-- END SECTION UPDATE_PARAMETERS */
        WHERE {PRIMARYKEY_PROPERTYNAME} = @identity
    END
    ELSE
    BEGIN
        INSERT INTO {ENTITY_NAME}
        (/*-- BEGIN SECTION INSERT_COLUMNS */
            /*-- BEGIN SECTION DEFAULT AS VAR */
            {VAR.COLUMNNAME}/*-- END SECTION DEFAULT */
            /*-- END SECTION INSERT_COLUMNS */
        )
        VALUES
        (/*-- BEGIN SECTION INSERT_PARAMETERS */
            /*-- BEGIN SECTION DEFAULT AS VAR */
            @{VAR.PARAMETERNAME}/*-- END SECTION DEFAULT */
            /*-- END SECTION INSERT_PARAMETERS */
        )

        SELECT @identity = SCOPE_IDENTITY()
    END

    SELECT @identity
END