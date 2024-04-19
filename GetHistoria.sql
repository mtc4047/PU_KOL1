CREATE PROCEDURE GetHistoria
(
    @Strona int,
    @IloscNaStronie int
)
AS
BEGIN
    DECLARE @Skip int = (@Strona - 1) * @IloscNaStronie;

    SELECT
        h.Id,
        h.Imie,
        h.Nazwisko,
        h.TypAkcji,
        h.Data,
        g.Nazwa AS GrupaNazwa
    FROM Historia AS h
        LEFT JOIN Grupa AS g ON h.IdGrupy = g.Id
    ORDER BY h.Id
    OFFSET @Skip ROWS
    FETCH NEXT @IloscNaStronie ROWS ONLY;
END;