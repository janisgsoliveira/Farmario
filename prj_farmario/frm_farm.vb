Imports System.ComponentModel.Design

Public Class frm_farm
    Private Sub txt_pesquisar_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisar.TextChanged
        Try
            'Define os parâmetros de pesquisa
            If cmb_pesquisar.SelectedItem = "Código" Then
                parametro = "cod_prod"
            ElseIf cmb_pesquisar.SelectedItem = "Nome do Produto" Then
                parametro = "produto"
            End If

            If parametro <> "" Then
                sql = "select * from tb_produtos where " & parametro & " like '" & txt_pesquisar.Text & "%' "
                rs = db.Execute(UCase(sql))
            End If

            'Exibe os produtos 
            With dgv_farm
                'cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                    'cont = cont + 1
                Loop
            End With

        Catch ex As Exception
            MsgBox("Erro ao obter os dados de produtos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Exit Sub
        End Try
    End Sub

    Private Sub btn_deslogar_Click_1(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        Try
            limpar_login()
            Me.Close()
            frm_login.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_farm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "select * from tb_produtos"
            rs = db.Execute(UCase(sql))

            'Exibe os produtos 
            With dgv_farm
                'cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                    'cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao obter dados dos produtos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub


End Class

