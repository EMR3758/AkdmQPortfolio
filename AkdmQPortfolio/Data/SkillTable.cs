using System;
using System.Collections.Generic;

namespace AkdmQPortfolio.Data
{
    public partial class SkillTable
    {
        public int SkillId { get; set; }
        public string? Title { get; set; }
        public byte? Levels { get; set; }
    }
}


//Bizim ilk başta skill diye bir nesne üretiyoruz --> SkillTable
//Emirhan 20
//Skill = skillId,Title(Emirhan),Levels(20)