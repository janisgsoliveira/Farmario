Imports System.Diagnostics.Eventing.Reader

Public Class frm_cadastro_cliente
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            'Checa campos vazios
            If String.IsNullOrEmpty(txt_nome.Text) Or String.IsNullOrEmpty(txt_cpf.Text) Or
           String.IsNullOrEmpty(txt_tel.Text) Then
                If cbx_local.Checked = True Then
                    If String.IsNullOrEmpty(txt_cep.Text) Or String.IsNullOrEmpty(txt_endereco.Text) Then
                        MsgBox("Preencha todos os campos para cadastrar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                Else
                    MsgBox("Preencha todos os campos para cadastrar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If

            Else 'Cadastro de novo cliente
                If cbx_local.Checked = False Then
                    num = vbEmpty
                Else
                    num = CInt(txt_num.Text)
                End If

                sql = "select * from tb_clientes where cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    resp = MsgBox("Tem certeza que deseja cadastrar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "AVISO")

                    If resp = vbYes Then
                        sql = "insert into tb_clientes values ('" & txt_cpf.Text & "', " &
                            "'" & txt_nome.Text & "' , '" & cmb_datanasc.Value.Date.ToString("yyyy-MM-dd") & "', " &
                            "'" & txt_tel.Text & "' , '" & txt_cep.Text & "' , '" & txt_endereco.Text & "', " &
                            "'" & num & "' , '" & txt_complemento.Text & "')"
                        rs = db.Execute(sql)
                        MsgBox("Dados cadastrados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CADASTRADO")
                        limpar_form_clientes()
                    End If

                Else 'Atualização de cliente
                    resp = MsgBox("CPF já cadastrado." & vbCrLf & "Deseja atualizar os dados deste CPF?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "AVISO")

                    If resp = vbYes Then
                        sql = "update tb_clientes set nome = '" & txt_nome.Text & "', data_nasc = '" & cmb_datanasc.Value.Date.ToString("yyyy-MM-dd") & "'," &
                                "telefone = '" & txt_tel.Text & "', cep = '" & txt_cep.Text & "' , endereco = '" & txt_endereco.Text & "', " &
                                "num = '" & num & "' , complemento = '" & txt_complemento.Text & "' where cpf = '" & txt_cpf.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATUALIZADO")
                        limpar_form_clientes()
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("Erro ao efetuar o cadastro de cliente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub frm_cadastro_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()
            frm_operac.Close()
            cmb_datanasc.Value = Today
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            'Autopreenchimento de formulário
            sql = "select * from tb_clientes where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(UCase(sql))

            If rs.EOF = False Then
                txt_nome.Text = rs.Fields(1).Value
                cmb_datanasc.Value = rs.Fields(2).Value
                txt_tel.Text = rs.Fields(3).Value
                txt_cep.Text = rs.Fields(4).Value
                txt_endereco.Text = rs.Fields(5).Value
                txt_num.Text = rs.Fields(6).Value
                txt_complemento.Text = rs.Fields(7).Value
                btn_cadastrar.Text = "Atualizar"
                cbx_local.Text = "Atualizar Endereço"
                btn_cadastrar.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao obter dados do cliente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        Try
            limpar_form_clientes()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
            frm_operac.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub cbx_local_CheckStateChanged(sender As Object, e As EventArgs) Handles cbx_local.CheckStateChanged
        Try
            'Habilitar cadastro de endereço (opcional do cliente)
            If cbx_local.Checked = True Then
                txt_cep.Enabled = True
                txt_endereco.Enabled = True
                txt_num.Enabled = True
                txt_complemento.Enabled = True
            Else
                txt_cep.Enabled = False
                txt_endereco.Enabled = False
                txt_num.Enabled = False
                txt_complemento.Enabled = False
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

End Class