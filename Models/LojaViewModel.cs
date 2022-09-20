namespace Avaliacao3BimLP3.ViewModels;

public class LojaViewModel
{   
    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome { get; set; }   
    public string Frase{ get; set; }
    public bool Loja { get; set; }
    public string Gmail  { get; set; }
    

    public LojaViewModel(int id, string piso, string nome, string frase, bool loja, string gmail)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Frase = frase;
        Loja = loja;
        Gmail = gmail;
    }
}
