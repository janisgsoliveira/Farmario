Public Class frm_cadastro_produto
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
            frm_admin.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_cadastro_produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frm_admin.Close()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            'Checa campo vazio
            If String.IsNullOrEmpty(txt_produto.Text) Or String.IsNullOrEmpty(txt_cod.Text) Or
            String.IsNullOrEmpty(txt_qtde.Text) Or String.IsNullOrEmpty(txt_valor.Text) Or
            String.IsNullOrEmpty(cmb_tipo.SelectedItem) Then
                MsgBox("Preencha todos os campos para cadastrar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

            Else 'Verifica se código já é cadastrado
                sql = "select * from tb_produtos where cod_prod = '" & txt_cod.Text & "'"
                rs = db.Execute(UCase(sql))

                If rs.EOF = True Then 'Cadastro de novo produto

                    resp = MsgBox("Deseja cadastrar o produto '" & txt_produto.Text & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "CADASTRAR")
                    If resp = vbYes Then
                        sql = "insert into tb_produtos values ('" & txt_cod.Text & "', " &
                              "'" & txt_produto.Text & "', '" & CInt(txt_qtde.Text) & "', '" & txt_valor.Text & "', " &
                              "'" & cmb_tipo.SelectedItem & "', '" & cbx_receita.CheckState & "')"

                        rs = db.Execute(UCase(sql))
                        MsgBox("Produto cadastrado no estoque com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CADASTRADO")
                        limpar_form_produtos()
                    End If

                Else 'Atualização de estoque
                    qtde = rs.Fields(2).Value
                    qtde = qtde + CInt(txt_qtde.Text)

                    resp = MsgBox("Deseja atualizar os dados de quantidade e valor de '" & txt_produto.Text & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATUALIZAR")
                    If resp = vbYes Then
                        sql = "update tb_produtos set qtde = '" & qtde & "', valor = '" & txt_valor.Text & "' where cod_prod = '" & txt_cod.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Produto no estoque atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATUALIZADO")
                        limpar_form_produtos()
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao efetuar o cadastro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub


    Private Sub txt_cod_TextChanged(sender As Object, e As EventArgs) Handles txt_cod.TextChanged
        Try
            'Autopreenchimento de formulário em caso de produto já cadastrado
            sql = "select * from tb_produtos where cod_prod = '" & txt_cod.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = False Then
                txt_produto.Text = rs.Fields(1).Value
                txt_valor.Text = rs.Fields(3).Value
                cmb_tipo.SelectedItem = rs.Fields(4).Value
                cbx_receita.CheckState = rs.Fields(5).Value

                lbl_qtde_estoque.Visible = True
                lbl_qtde.Visible = True
                lbl_qtde.Text = rs.Fields(2).Value
                btn_cadastrar.Text = "ATUALIZAR"
            Else
                lbl_qtde.Text = "---"
                btn_cadastrar.Text = "CADASTRAR"
            End If
        Catch ex As Exception
            MsgBox("Erro ao obter os dados do produto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try

    End Sub

    Private Sub txt_cod_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod.DoubleClick
        Try
            limpar_form_produtos()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class