﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Domain.Entities
{
    public class OrdemServico : EntityBase
    {
        public DateTime Data { get; set; }
        public DateTime? Data_Realizacao { get; set; }
        public DateTime? Data_Agendamento { get; set; }
        public string Observacao { get; set; }

        [ForeignKey("Animal")]
        public int Id_Animal { get; set; }
        public Animal Animal { get; set; }

        [ForeignKey("Cliente")]
        public int Id_Cliente { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("Petshop")]
        public int Id_Petshop { get; set; }
        public Petshop Petshop { get; set; }

        public ICollection<ItemOrdemServico> Servicos { get; set; }

    }
}
