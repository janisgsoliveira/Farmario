Public Class frm_gerenciar
    Private Sub frm_gerenciar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frm_admin.Close()

        Try
            sql = "select * from tb_login"
            rs = db.Execute(UCase(sql))

            'Minera todos os dados de usuários já existentes e os exibe no DataGrid
            With dgv_usuario
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao obter dados de login.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            'Checa campos vazios
            If String.IsNullOrEmpty(txt_cpf.Text) Or String.IsNullOrEmpty(txt_nome.Text) Or String.IsNullOrEmpty(txt_user.Text) Or String.IsNullOrEmpty(txt_celular.Text) Or String.IsNullOrEmpty(cmb_cargo.Text) Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub

            Else
                sql = "select * from tb_login where cpf = '" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))

                'CPF já cadastrado
                If rs.EOF = False Then
                    resp = MsgBox("CPF já cadastrado! Deseja atualizar as informações deste CPF?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATUALIZAR")

                    'Atualização do CPF
                    If resp = MsgBoxResult.Yes Then

                        sql = "select * from tb_login where usuario = '" & txt_user.Text & "'"
                        rs = db.Execute(sql)

                        'Erro por usuário já existente
                        If rs.EOF = False Then
                            resp = MsgBox("Usuário já existente." & vbCrLf & "Deseja atualizar as outras informações para este CPF?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "AVISO")
                            If resp = vbYes Then
                                sql = "update tb_login set nome = '" & txt_nome.Text & "', cargo = '" & cmb_cargo.Text & "', celular = '" & txt_celular.Text & "' where cpf = '" & txt_cpf.Text & "'"
                                rs = db.Execute(sql)
                                MsgBox("CPF atualizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATUALIZADO")
                            Else
                                Exit Sub
                            End If

                        Else
                            sql = "update tb_login set nome = '" & txt_nome.Text & "', usuario = '" & txt_user.Text & "', cargo = '" & cmb_cargo.Text & "', celular = '" & txt_celular.Text & "' where cpf = '" & txt_cpf.Text & "'"
                            rs = db.Execute(sql)
                            MsgBox("CPF atualizado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATUALIZADO")
                            Exit Sub
                        End If

                    End If

                Else 'Cadastro de novo login
                    sql = "select * from tb_login where usuario = '" & txt_user.Text & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then 'Erro por usuário já existente
                        MsgBox("Usuário já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                        Exit Sub

                    Else
                        senha = "" & txt_user.Text & "123"

                        sql = "insert into tb_login values ('" & txt_nome.Text & "', '" & txt_user.Text & "', '" & senha & "', '" & cmb_cargo.SelectedItem & "', '" & txt_cpf.Text & "', '" & txt_celular.Text & "', true)"
                        rs = db.Execute(sql)

                        MsgBox("Dados cadastrados com sucesso!" & vbCrLf & "Sua senha padrão é: " & senha & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CADASTRADO")
                        limpar_form_gerenciar()
                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox("Erro ao efetuar o cadastro de login.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_cancelar_Click_1(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
            frm_admin.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_usuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuario.CellContentClick
        Try
            With dgv_usuario
                If .CurrentRow.Cells(6).Selected = True Then 'Editar cadastro
                    aux = .CurrentRow.Cells(1).Value

                    sql = "select * from tb_login where usuario = '" & aux & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_nome.Text = rs.Fields(0).Value
                        txt_user.Text = rs.Fields(1).Value
                        cmb_cargo.SelectedItem = rs.Fields(3).Value
                        txt_cpf.Text = rs.Fields(4).Value
                        txt_celular.Text = rs.Fields(5).Value
                        btn_cadastrar.Text = "Atualizar"
                    End If

                ElseIf .CurrentRow.Cells(7).Selected = True Then 'Apagar cadastro
                    aux = .CurrentRow.Cells(1).Value

                    sql = "select * from tb_login where usuario = '" & aux & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente apagar este login?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete from tb_login where usuario = '" & aux & "'"
                            rs = db.Execute(sql)
                            MsgBox("Conta apagada com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATUALIZADO")
                        End If

                    End If

                ElseIf .CurrentRow.Cells(5).Selected = True Then 'Mudar status da conta
                    aux = .CurrentRow.Cells(1).Value

                    sql = "select * from tb_login where usuario = '" & aux & "'"
                    rs = db.Execute(sql)

                    resp = MsgBox("Deseja mudar o status atual da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATUALIZAR")

                    If resp = MsgBoxResult.Yes Then

                        Dim marcado As Boolean

                        If rs.EOF = False Then
                            marcado = CBool(.CurrentRow.Cells(5).Value)
                            If marcado = True Then 'Bloquear
                                .CurrentRow.Cells(5).Selected = False
                                .CurrentRow.Cells(5).Value = False
                                MsgBox("Conta bloqueada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATUALIZADO")

                            ElseIf marcado = False Then  'Desbloquear
                                .CurrentRow.Cells(5).Selected = True
                                .CurrentRow.Cells(5).Value = True
                                MsgBox("Conta desbloqueada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATUALIZADO")

                            End If

                            sql = "update tb_login set status = " & .CurrentRow.Cells(5).Value & " where usuario = '" & aux & "'"
                            rs = db.Execute(sql)

                        End If

                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao alterar dados de login.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            'Autopreenchimento de formulário
            sql = "select * from tb_login where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                txt_user.Text = rs.Fields(1).Value
                txt_nome.Text = rs.Fields(0).Value
                cmb_cargo.SelectedItem = rs.Fields(3).Value
                txt_celular.Text = rs.Fields(5).Value
                btn_cadastrar.Text = "Atualizar"

            Else
                btn_cadastrar.Text = "Cadastrar"
            End If
        Catch ex As Exception
            MsgBox("Erro ao obter dados dos usuários.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        Try
            limpar_form_gerenciar()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Try
            Me.Close()
            frm_admin.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class