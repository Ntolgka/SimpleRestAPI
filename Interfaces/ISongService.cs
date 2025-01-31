﻿using Week1_Assesment.Models;

namespace Week1_Assesment.Interfaces;

public interface ISongService
{
    Task<List<Song>> GetAll();
    Task<Song> GetById(int id);
    Task<List<Song>> Create(Song song);
    Task<Song> Update(Song song);
    Task<Song> Delete(int id);
    Task<Song> Patch(int id, Song updatedFields);
    Task<List<Song>> ListByAlbum(string album);

}