﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PlatformGamingCloud.Models;

public class Game
{
    [HiddenInput]
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataCompra = DateTime.Now;

    [Display(Name ="Gênero")]
    public Genero? Genero { get; set; }
    public double? Valor { get; set; }
}

public enum Genero
{
        Corrida, Ficção, Ação, Aventura, FPS, RPG
}