CREATE TRIGGER HistoriaDeleteTrigger
ON Studenci
AFTER DELETE
AS
BEGIN
    INSERT INTO Historia (Imie, Nazwisko, IdGrupy, TypAkcji, Data)
    SELECT
        s.Imie,
        s.Nazwisko,
        s.IdGrupy,
        0 AS TypAkcji,
        GETDATE() AS Data
    FROM DELETED s
END