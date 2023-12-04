Module modulo_geral
    Public sql, resp, aux As String
    Public db As New ADODB.Connection 'conexão banco
    Public rs As New ADODB.Recordset
    Public caminho = Application.StartupPath & "\Banco\banco_prj.mdb" 'localização do banco (local)
    Public cont, qtde, num, idVenda As Integer
    Public subtotal, total As Double
    Public parametro, usuario, fone, chave, senha, cod, prod As String

    Sub conectar_banco_access()
        Try
            db = CreateObject("ADODB.Connection") 'cria conexão
            db.Open("Provider = Microsoft.JET.OLEDB.4.0; Data Source = " & caminho) 'provider = access
        Catch ex As Exception
            MsgBox("Erro de conexão ao banco.", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=farmario;UID=root;PWD=usbw;port=3307;option=3;")
        Catch ex As Exception
            MsgBox("Erro de conexão ao banco.", MsgBoxStyle.Critical + vbOKOnly, "ERRO")
        End Try
    End Sub

    Sub limpar_form_clientes()
        Try
            With frm_cadastro_cliente
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .cmb_datanasc.Value = Today()
                .txt_tel.Clear()
                .txt_cep.Clear()
                .txt_endereco.Clear()
                .txt_num.Clear()
                .txt_complemento.Clear()
                .cbx_local.Checked = False
                .btn_cadastrar.Text = "Cadastrar"
                .cbx_local.Text = "Cadastrar Endereço"
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_login()
        Try
            With frm_login
                .txt_user.Clear()
                .txt_senha.Clear()
                .txt_user.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_form_produtos()
        Try
            With frm_cadastro_produto
                .txt_cod.Clear()
                .txt_produto.Clear()
                .txt_qtde.Clear()
                .txt_valor.Clear()
                .cmb_tipo.Text = ""
                .cbx_receita.CheckState = False
                .lbl_qtde_estoque.Visible = False
                .lbl_qtde.Visible = False
                .lbl_qtde.Text = vbEmpty
                .btn_cadastrar.Text = "CADASTRAR"

                .txt_cod.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Sub limpar_form_gerenciar()
        Try
            With frm_gerenciar
                .txt_nome.Clear()
                .txt_cpf.Clear()
                .txt_user.Clear()
                .txt_celular.Clear()
                .cmb_cargo.Text = ""
                .btn_cadastrar.Text = "Cadastrar"
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_form_cadastro_venda()
        Try
            With frm_cadastro_venda
                .txt_cod.Text = Nothing
                .txt_qtde.Text = Nothing
                .txt_pesquisar.Text = Nothing
                .txt_cpf.Text = Nothing
                .chk_cpf.Checked = False
                .rd_cartao.Checked = False
                .rd_dinheiro.Checked = False
                .txt_valor_pago.Text = Nothing
                .txt_valor_total.Text = Nothing
                .txt_a_pagar.Text = Nothing
                .lbl_troco.Visible = False
                .dgv_venda.Rows.Clear()
                .txt_cod.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

End Module
