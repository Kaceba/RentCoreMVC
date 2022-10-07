using System;
using System.Collections.Generic;

public class TipiSpeseService : ITipiSpeseService
{
    public List<TipiSpeseViewModel> GetTipiSpese()
    {
        var TipiSpeseList = new List<TipiSpeseViewModel>();

        for(int i = 1; i < 11; i++)
        {
            var TipoSpesa = new TipiSpeseViewModel
            {
                Id = i,
                Descrizione = $"Descrizione {i}"
            };
            TipiSpeseList.Add(TipoSpesa);
        }

        return TipiSpeseList;
    }
}