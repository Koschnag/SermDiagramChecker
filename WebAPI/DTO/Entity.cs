﻿using Attribute = WebAPI.DTO.Attribute;

namespace WebAPI.DTO
{
    public class Entity
    {
        public int id { get; set; }
        public EntityType type { get; set; }
        public string entityName { get; set; }
        public int top { get; set; }
        public int left { get; set; }
        public int width { get; set; }
        public Attribute[] attributes { get; set; }
    }
}