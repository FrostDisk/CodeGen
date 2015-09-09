PRINT N'Stored Procedure [dbo].[{GETBYID_STORED_PROCEDURE}]'
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{GETBYID_STORED_PROCEDURE}]') AND TYPE IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[{GETBYID_STORED_PROCEDURE}]  
GO
CREATE PROCEDURE [dbo].[{GETBYID_STORED_PROCEDURE}]
(
    @{PRIMARYKEY_PARAMETERNAME} {PRIMARYKEY_DATATYPE}
)
AS
-- =============================================
-- Author         : {AUTHOR_NAME}
-- Creation Date  : {CREATION_DATE}
-- Main Entity    : {ENTITY_NAME}
-- Description    : Get Entity from Database
-- =============================================
-- Modified by    :
-- Modified Date  :
-- Description    :
-- =============================================
BEGIN

    SET NOCOUNT ON;

    SELECT/*-- BEGIN SECTION SELECT_COLUMNS */
        /*-- BEGIN SECTION DEFAULT AS VAR */
        {VAR.COLUMNNAME}/*-- END SECTION DEFAULT */
        /*-- END SECTION SELECT_COLUMNS */
    FROM
        {ENTITY_NAME}
    WHERE
        {PRIMARYKEY_PROPERTYNAME} = @{PRIMARYKEY_PARAMETERNAME}

END
