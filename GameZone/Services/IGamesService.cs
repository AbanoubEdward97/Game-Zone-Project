﻿namespace GameZone.Services
{
    public interface IGamesService
    {
        IEnumerable<Game> GetAll();
        Game? GetGameById(int id);
        Task Create(CreateGameFormViewModel model);
        Task<Game?> Edit(EditGameFormViewModel model);
        bool Delete(int id);
    }
}
