using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RentCore.Models.Entitites;


public class EfCoreTipiSpeseService : ITipiSpeseService
{

    private readonly RENTCARdbContext dbContext;

    public EfCoreTipiSpeseService(RENTCARdbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    
    public List<TipiSpeseViewModel> GetTipiSpese()
    {
        List<TipiSpeseViewModel> TipiSpeseList = dbContext.TipiSpeses.Select(TipiSpese =>
        new TipiSpeseViewModel
        {
            Id = (int)TipiSpese.IdTipoSpesa,
            Descrizione = TipiSpese.Descrizione
        })
        .ToList();

        return TipiSpeseList;
    }

    public void InsertTipoSpesa(string newDescrizione)
    {
        TipiSpese tipoSpesa = new TipiSpese();

        tipoSpesa.Descrizione = newDescrizione;

        dbContext.TipiSpeses.Add(tipoSpesa);
        dbContext.SaveChanges();
    }

    public void UpdateTipoSpesa(int IdTipoSpesa, string updateDescrizione)
    {
        TipiSpese tipoSpesa = new TipiSpese();

        tipoSpesa.IdTipoSpesa = IdTipoSpesa;
        tipoSpesa.Descrizione = updateDescrizione;

        dbContext.TipiSpeses.Update(tipoSpesa);
        dbContext.SaveChanges();
    }
}
