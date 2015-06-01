PRINT N'Stored Procedure [dbo].[{LISTALL_STORED_PROCEDURE}]'
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{LISTALL_STORED_PROCEDURE}]') AND TYPE IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[{LISTALL_STORED_PROCEDURE}]  
GO
CREATE PROCEDURE [dbo].[{LISTALL_STORED_PROCEDURE}]
AS
-- =============================================
-- Author         : {AUTHOR_NAME}
-- Creation Date  : {CREATION_DATE}
-- Main Entity    : {ENTITY_NAME}
-- Description    : List All Entities from Database
-- =============================================
-- Modified by    :
-- Modified Date  :
-- Description    :
-- =============================================
BEGIN
    SET NOCOUNT ON;

    SELECT/*-- BEGIN SECTION SELECT_COLUMNS */
        /*-- BEGIN SECTION DEFAULT AS VAR */
        {VAR.PROPERTYNAME}/*-- END SECTION DEFAULT */
        /*-- END SECTION SELECT_COLUMNS */
    FROM
        {ENTITY_NAME}
END
