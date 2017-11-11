package br.com.furb.projeto_software.dimo.dao;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;

import br.com.furb.projeto_software.dimo.model.Aluno;

/**
 * Created by nicollas on 27/08/2017.
 */

public class AlunoDAO {
    private SQLiteDatabase db;
    private CriaBanco banco;

    public AlunoDAO(Context context) {
        this.banco = new CriaBanco(context);
    }

    public String inserirDados(Aluno aluno) {
        ContentValues valores;
        long resultado;

        db = banco.getWritableDatabase();
        valores = new ContentValues();
        valores.put(AlunoContract.NOME, aluno.getNome());
        valores.put(AlunoContract.ENDERECO, aluno.getEndereco());
        valores.put(AlunoContract.TELEFONE, aluno.getTelefone());
        valores.put(AlunoContract.CPF, aluno.getCPF());
        valores.put(AlunoContract.RG, aluno.getRG());


        resultado = db.insert(AlunoContract.TABLE_NAME, null, valores);
        db.close();

        if (resultado == -1) {
            return "Erro ao inserir registro na tabela Alunos";
        } else {
            return "Registro inserido com sucesso na tabela Alunos";
        }
    }

    public Cursor buscarDados() {
        return buscarDados(null, null, null, null, null);
    }

    public Cursor buscarDados(String where) {
        return buscarDados(where, null, null, null, null);
    }

    public Cursor buscarDados(String where, String groupBy, String having,  String orderBy, String limit) {
        Cursor cursor;
        String[] campos = {AlunoContract.ID, AlunoContract.NOME, AlunoContract.ENDERECO, AlunoContract.TELEFONE, AlunoContract.CPF, AlunoContract.RG};
        db = banco.getReadableDatabase();
        cursor = db.query(AlunoContract.TABLE_NAME, campos, where, null, groupBy, having, orderBy, limit);

        if (cursor != null) {
            cursor.moveToFirst();
        }
        db.close();
        return cursor;
    }

    public void alterarDados(Aluno aluno){
        ContentValues valores;
        String where;

        db = banco.getWritableDatabase();

        where = AlunoContract.ID + "=" + aluno.getID();

        valores = new ContentValues();
        valores.put(AlunoContract.NOME, aluno.getNome());
        valores.put(AlunoContract.ENDERECO, aluno.getEndereco());
        valores.put(AlunoContract.TELEFONE, aluno.getTelefone());
        valores.put(AlunoContract.CPF, aluno.getCPF());
        valores.put(AlunoContract.RG, aluno.getRG());


        db.update(AlunoContract.TABLE_NAME,valores,where,null);
        db.close();
    }

    public int excluirDados(int id){
        db = banco.getWritableDatabase();
        int numero_rows_afetadas = db.delete(AlunoContract.TABLE_NAME,AlunoContract.ID + "=" + id, null);
        db.close();
        return numero_rows_afetadas;
    }
}
