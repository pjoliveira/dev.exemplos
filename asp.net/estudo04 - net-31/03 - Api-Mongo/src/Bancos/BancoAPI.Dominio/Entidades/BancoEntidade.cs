﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BancoAPI.Dominio.Entidades
{
    /// <summary>
    /// Classe de Dominio 
    /// </summary>
    public class BancoEntidade
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string EmpresaId { get; set; }

    }
}
