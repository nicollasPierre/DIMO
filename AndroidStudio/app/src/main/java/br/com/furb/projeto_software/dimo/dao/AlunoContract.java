package br.com.furb.projeto_software.dimo.dao;

import android.provider.BaseColumns;

import java.util.ArrayList;

/**
 * Created by nicollas on 27/08/2017.
 */

public final class AlunoContract {
    public static final String TABLE_NAME = "Aluno";
    public static final String ID = "cd_aluno";
    public static final String NOME = "nm_aluno";
    public static final String ENDERECO = "ds_endereco";
    public static final String TELEFONE = "nr_telefone";
    public static final String CPF = "nr_cpf";
    public static final String RG = "nr_rg";
    public static final String CREATE_TABLE_SQL = "CREATE TABLE "+AlunoContract.TABLE_NAME+"("
            + AlunoContract.ID + "integer primary key autoincrement,"
            + AlunoContract.NOME + " text,"
            + AlunoContract.ENDERECO + " text,"
            + AlunoContract.TELEFONE + " text,"
            + AlunoContract.CPF + " text,"
            + AlunoContract.RG + " text"
            +")";
    public static final String UPGRADE_TABLE_SQL = "DROP TABLE IF EXISTS " + TABLE_NAME;
    public static final String DELETE_TABLE_SQL = "DROP TABLE " + TABLE_NAME;
}
