package br.com.furb.projeto_software.dimo.dao;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by nicollas on 27/08/2017.
 */

public class CriaBanco extends SQLiteOpenHelper {
    public static final String DATABASE_NAME = "DIMO";
    public static final int VERSAO = 1;

    public CriaBanco(Context context) {
        super(context, DATABASE_NAME, null, VERSAO);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String sql = AlunoContract.CREATE_TABLE_SQL;
        db.execSQL(sql);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS" + AlunoContract.TABLE_NAME);
        onCreate(db);
    }
}
