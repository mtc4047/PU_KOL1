CREATE PROCEDURE GetFullGroupName (@groupId INT)
AS
BEGIN
    DECLARE @fullGroupName NVARCHAR(MAX);
    DECLARE @currentGroupId INT;
    DECLARE @nazwa NVARCHAR(MAX);

    SET @fullGroupName = '';
    SET @currentGroupId = @groupId;

    WHILE @currentGroupId IS NOT NULL
    BEGIN
        SELECT @nazwa = Nazwa 
        FROM Grupa
        WHERE Id = @currentGroupId;

        SET @fullGroupName = @nazwa + '/' + @fullGroupName;

        SELECT @currentGroupId = ParentId
        FROM Grupa
        WHERE Id = @currentGroupId;
    END;

    SET @fullGroupName = SUBSTRING(@fullGroupName, 2, LEN(@fullGroupName));

    SELECT @fullGroupName AS FullGroupName;
END;