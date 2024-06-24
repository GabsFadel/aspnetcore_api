using System.ComponentModel;

namespace Web_API_Study.Enums
{
    public enum StatusTarefa
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento= 2,
        [Description("Concluido")]
        Concluido = 3
    }
}
