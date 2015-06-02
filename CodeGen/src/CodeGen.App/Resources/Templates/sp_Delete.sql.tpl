PRINT N'Stored Procedure [dbo].[{DELETE_STORED_PROCEDURE}]'
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{DELETE_STORED_PROCEDURE}]') AND TYPE IN (N'P', N'PC'))
DROP PROCEDURE [dbo].[{DELETE_STORED_PROCEDURE}]  
GO
CREATE PROCEDURE [dbo].[{DELETE_STORED_PROCEDURE}]
(
    @{PRIMARYKEY_PARAMETERNAME} {PRIMARYKEY_DATATYPE}
)
AS
-- =============================================
-- Author         : {AUTHOR_NAME}
-- Creation Date  : {CREATION_DATE}
-- Main Entity    : {ENTITY_NAME}
-- Description    : Delete Entity from Database
-- =============================================
-- Modified by    :
-- Modified Date  :
-- Description    :
-- =============================================
BEGIN

    SET NOCOUNT ON;

    DELETE
    FROM
        {ENTITY_NAME}
    WHERE
        {PRIMARYKEY_PROPERTYNAME} = @{PRIMARYKEY_PARAMETERNAME}

END
