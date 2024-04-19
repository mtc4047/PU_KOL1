CREATE PROCEDURE AddStudent
(
    @Imie nvarchar(100),
    @Nazwisko nvarchar(100),
    @IdGrupy int
)
AS
BEGIN
    INSERT INTO Student (Imie, Nazwisko, IdGrupy)
    VALUES (@Imie, @Nazwisko, @IdGrupy);
END;