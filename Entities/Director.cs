﻿namespace MovieTheater.Entities
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }

}