using System.Collections.Generic;
public interface ITipiSpeseService
{
    List<TipiSpeseViewModel> GetTipiSpese();

    void InsertTipoSpesa(string newDescrizione);
    
    void UpdateTipoSpesa(int IdTipoSpesa, string updateDescrizione);

}