CREATE TRIGGER HistoriaUpdateTrigger
ON Studenci
AFTER UPDATE
AS
BEGIN
    INSERT INTO Historia (Imie, Nazwisko, IdGrupy, TypAkcji, Data)
    SELECT
        s.Imie,
        s.Nazwisko,
        s.IdGrupy,
        1 AS TypAkcji,
        GETDATE() AS Data
    FROM DELETED s
END