package br.com.furb.projeto_software.dimo.model;

/**
 * Created by nicollas on 27/08/2017.
 */

public class Aluno {
    private int ID;
    private String nome;
    private String endereco;
    private String telefone;
    private String CPF;
    private String RG;

    public Aluno(String nome, String endereco, String telefone, String CPF, String RG) {
        setNome(nome);
        setEndereco(endereco);
        setTelefone(telefone);
        setCPF(CPF);
        setRG(RG);
    }

    public int getID() {
        return ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public String getCPF() {
        return CPF;
    }

    public void setCPF(String CPF) {
        this.CPF = CPF;
    }

    public String getRG() {
        return RG;
    }

    public void setRG(String RG) {
        this.RG = RG;
    }

    @Override
    public String toString() {
        return "\"Aluno\"{" +
                "\"ID\":" + ID +
                ", \"nome\":\"" + nome + '\"' +
                ", \"endereco\":\"" + endereco + '\"' +
                ", \"telefone\":\"" + telefone + '\"' +
                ", \"CPF\":\"" + CPF + '\"' +
                ", \"RG\":\"" + RG + '\"' +
                '}';
    }
}
