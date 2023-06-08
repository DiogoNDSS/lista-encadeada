public class NoAssunto{
    public String nome;
    public int periodo;
    public int cargaHoraria;
    public String professor;
    public NoAssunto noProx;

    public NoAssunto(String nome, int periodo, int cargaHoraria, String professor){
        this.nome = nome;
        this.periodo = periodo;
        this.cargaHoraria = cargaHoraria;
        this.professor = professor;
        this.noProx = null;
    }
    
}