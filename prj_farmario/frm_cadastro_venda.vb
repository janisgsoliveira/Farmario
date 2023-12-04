Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Printing

Public Class frm_cadastro_venda
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
            frm_operac.Show()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frm_cadastro_venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            frm_operac.Close()
            sql = "select * from tb_produtos order by cod_prod asc"
            rs = db.Execute(sql)

            'Preenche o dgv com os produtos em estoque
            With dgv_farm
                .Rows.Clear()
                While rs.EOF = False
                    .Rows.Add(Nothing, rs.Fields(0).Value, rs.Fields(1).Value, "R$" & rs.Fields(3).Value)
                    rs.MoveNext()
                End While
            End With

            total = 0
        Catch ex As Exception
            MsgBox("Erro ao obter as informações de produtos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_cod_TextChanged(sender As Object, e As EventArgs) Handles txt_cod.TextChanged
        Try
            sql = "select * from tb_produtos where cod_prod = '" & txt_cod.Text & "'"
            rs = db.Execute(sql)

            'Preenche os campos com os dados do produto para adicionar ao carrinho
            If Not rs.EOF Then
                txt_produto.Text = rs.Fields(1).Value
                txt_valor_unit.Text = rs.Fields(3).Value
                lbl_estoque.Text = rs.Fields(2).Value
                Try
                    txt_valor_final.Text = CDbl(txt_valor_unit.Text) * CInt(txt_qtde.Text) 'Cálculo do valor total
                Catch
                End Try

            Else
                txt_produto.Text = Nothing
                lbl_estoque.Text = "---"
                txt_valor_unit.Text = Nothing
                txt_valor_final.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox("Erro ao obter as informações do produto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_qtde_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_qtde.KeyUp
        Try
            If String.IsNullOrEmpty(txt_valor_unit.Text) = False Then
                txt_valor_final.Text = CDbl(txt_valor_unit.Text) * CInt(txt_qtde.Text) 'Cálculo do valor total
            Else
                txt_valor_final.Text = Nothing
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        Try
            'Verificação dos campos
            If String.IsNullOrEmpty(txt_cod.Text) Or String.IsNullOrEmpty(txt_qtde.Text) Then
                MsgBox("Preencha os campos de Código do Produto e Quantidade", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            ElseIf CInt(txt_qtde.Text) < 1 Then
                MsgBox("Quantidade inválida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            End If

            sql = "select * from tb_produtos where cod_prod = '" & txt_cod.Text & "' order by cod_prod asc"
            rs = db.Execute(sql)

            'Cálculo do subtotal de cada produto e adição no carrinho
            If Not rs.EOF Then
                subtotal = CDbl(rs.Fields(3).Value) * CInt(txt_qtde.Text)
                With dgv_venda
                    .Rows.Add(Nothing, rs.Fields(0).Value, rs.Fields(1).Value, txt_qtde.Text, "R$" & rs.Fields(3).Value, "R$" & subtotal)
                End With
                total = 0
                For Each linha As DataGridViewRow In dgv_venda.Rows
                    total = total + CDbl(linha.Cells(5).Value)
                Next
                txt_valor_total.Text = total

                txt_cod.Clear()
                txt_qtde.Clear()
            Else
                MsgBox("Código inválido! Tente novamente.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Código Inválido")
            End If
        Catch ex As Exception
            MsgBox("Erro ao adicionar item ao carrinho.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try

    End Sub

    Private Sub txt_pesquisar_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisar.TextChanged
        Try
            'Exibe todos os produtos 
            sql = "select * from tb_produtos where produto like '" & txt_pesquisar.Text & "%' order by cod_prod asc"
            rs = db.Execute(UCase(sql))

            With dgv_farm
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(Nothing, rs.Fields(0).Value, rs.Fields(1).Value, "R$" & rs.Fields(3).Value)
                    rs.MoveNext()
                Loop
            End With

        Catch ex As Exception
            MsgBox("Erro ao obter os dados de produtos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_farm_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_farm.CellContentClick
        Try
            With dgv_farm
                If .CurrentRow.Cells(0).Selected = True Then
                    txt_cod.Text = .CurrentRow.Cells(1).Value
                    txt_produto.Text = .CurrentRow.Cells(2).Value
                    txt_valor_unit.Text = CDbl(.CurrentRow.Cells(3).Value)

                    Try 'tentar fazer o calculo do valor final, com o Try para caso esteja vazio o txt_qtde não dar erro
                        txt_valor_final.Text = (CDbl(txt_valor_unit.Text) * CInt(txt_qtde.Text)).ToString("N2")
                    Catch
                        txt_valor_final.Text = Nothing
                    End Try
                    txt_qtde.Focus()
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub dgv_venda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_venda.CellContentClick
        Try
            'Excluir item do carrinho
            With dgv_venda
                If .CurrentRow.Cells(0).Selected Then
                    .Rows.Remove(.CurrentRow)
                End If
                total = 0
                For Each linha As DataGridViewRow In dgv_venda.Rows
                    total = total + CDbl(linha.Cells(5).Value)
                Next
                txt_valor_total.Text = total
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub rd_dinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles rd_dinheiro.CheckedChanged
        Try
            'Pagamento em dinheiro
            If rd_dinheiro.Checked Then
                txt_valor_pago.Text = Nothing
                txt_valor_pago.Enabled = True
                lbl_troco.Visible = True
                txt_valor_pago.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub rd_cartao_CheckedChanged(sender As Object, e As EventArgs) Handles rd_cartao.CheckedChanged
        Try
            'Pagamento em cartão
            If rd_cartao.Checked Then
                txt_valor_pago.Enabled = False
                txt_valor_pago.Text = txt_a_pagar.Text
                lbl_troco.Visible = False
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub chk_cpf_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cpf.CheckedChanged
        Try
            'Informar ou não o cpf
            If chk_cpf.Checked Then
                txt_cpf.Text = Nothing
                txt_cpf.Enabled = False
                txt_desconto.Text = "-"
            Else
                txt_cpf.Enabled = True
                txt_cpf.Focus()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_valor_total_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_total.TextChanged
        Try
            If Not txt_valor_total.Text = Nothing Then
                If lbl_desconto.Text <> "-" Then
                    txt_desconto.Text = (CDbl(lbl_desconto.Text) * 0.01 * CDbl(txt_valor_total.Text)).ToString("N2")
                    txt_a_pagar.Text = (CDbl(txt_valor_total.Text) - CDbl(txt_desconto.Text)).ToString("N2")
                Else
                    txt_a_pagar.Text = CDbl(txt_valor_total.Text)
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub txt_valor_pago_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_pago.TextChanged
        Try
            If CDbl(txt_valor_pago.Text) > CDbl(txt_a_pagar.Text) Then
                lbl_troco.Text = (CDbl(txt_valor_pago.Text) - CDbl(txt_a_pagar.Text)).ToString("N2")
            Else
                lbl_troco.Text = "---"
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_valor_pago_LostFocus(sender As Object, e As EventArgs) Handles txt_valor_pago.LostFocus
        Try
            If CDbl(txt_valor_pago.Text) < CDbl(txt_valor_total.Text) Then
                MsgBox("Pagamento insuficiente.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ALERTA")
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub txt_qtde_LostFocus(sender As Object, e As EventArgs) Handles txt_qtde.LostFocus
        Try
            If CInt(lbl_estoque.Text) < CInt(txt_qtde.Text) Then
                MsgBox("Quantidade indisponível no estoque!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub txt_cod_DoubleClick(sender As Object, e As EventArgs) Handles txt_cod.DoubleClick
        txt_cod.Text = Nothing
    End Sub

    Private Sub lbl_desconto_TextChanged(sender As Object, e As EventArgs) Handles lbl_desconto.TextChanged
        Try
            If lbl_desconto.Text <> "-" Then
                txt_desconto.Text = (CDbl(lbl_desconto.Text) * 0.01 * CDbl(txt_valor_total.Text)).ToString("N2")
                txt_a_pagar.Text = (CDbl(txt_valor_total.Text) - CDbl(txt_desconto.Text)).ToString("N2")

            Else
                txt_desconto.Text = Nothing
                txt_a_pagar.Text = txt_valor_total.Text
            End If

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Try
            If dgv_venda.DisplayedRowCount(False) = 0 Then
                MsgBox("Nenhum produto adicionado ao carrinho.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub


            ElseIf rd_cartao.Checked = False And rd_dinheiro.Checked = False Then
                MsgBox("Selecione uma forma de pagamento.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            ElseIf CDbl(txt_valor_pago.Text) < CDbl(txt_a_pagar.Text) Then
                MsgBox("Valor pago insuficiente.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else

                With dgv_venda
                    'registrar dados do cpf e id da venda na tabela tb_vendas
                    sql = "insert into tb_vendas (cpf, data_compra) values ('" & txt_cpf.Text & "', '" & DateTime.Now.Date.ToString("yyyy-mm-dd") & "')"
                    rs = db.Execute(sql)

                    'pegar id da venda que acabou de cadastrar
                    sql = "select * from tb_vendas order by id_venda desc"
                    rs = db.Execute(sql)
                    idVenda = CInt(rs.Fields(0).Value)

                    'loop pelos itens no carrinho
                    For Each linha As DataGridViewRow In dgv_venda.Rows
                        'buscar dados da qtde do produto no estoque
                        sql = "select * from tb_produtos where cod_prod = '" & linha.Cells(1).Value & "'"
                        rs = db.Execute(sql)

                        'atualizar qtde no estoque pós venda
                        qtde = CInt(rs.Fields(2).Value)
                        qtde = qtde - CInt(linha.Cells(3).Value)
                        sql = "update tb_produtos set qtde = '" & qtde & "' where cod_prod = '" & linha.Cells(1).Value & "'"
                        rs = db.Execute(sql)

                        'registrar venda na tabela tb_vendas_produto
                        sql = "insert into tb_vendas_produto (cod_prod, id_venda, qtde, valor) values ('" & linha.Cells(1).Value & "', '" & idVenda & "', '" & linha.Cells(3).Value & "', '" & CDbl(linha.Cells(5).Value) & "')"
                        rs = db.Execute(sql)
                    Next
                End With


                PrintPreviewDialog1.ShowDialog()
                PrintDocument1.Print()

                MsgBox("Venda realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
                limpar_form_cadastro_venda()

            End If
        Catch ex As Exception
            MsgBox("Erro ao finalizar o pedido.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try

    End Sub

    Private Sub txt_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        Try
            sql = "Select * from tb_clientes where cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                lbl_cliente.Text = rs.Fields(1).Value
                lbl_desconto.Text = 5

            Else
                lbl_cliente.Text = "---"
                lbl_desconto.Text = "---"
            End If
        Catch ex As Exception
            MsgBox("Erro ao obter os dados do CPF informado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            'Define as configurações de impressão
            Dim margemEsquerda As Integer = e.MarginBounds.Left
            Dim margemSuperior As Integer = e.MarginBounds.Top
            Dim linhaAtual As Integer = 0
            Dim cor As New SolidBrush(Color.Black)
            Dim fonte As New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point)
            Dim espaco As Integer 'Define diferença de espaço na impressão

            'Título
            'Função de Impressão
            e.Graphics.DrawString("---------------------------------------------------------------------------FARMARIO---------------------------------------------------------------------------", fonte, cor, margemEsquerda, margemSuperior)
            e.Graphics.DrawString("NOTA FISCAL ------------------------------------------------------------" & txt_cpf.Text & "-------------------------------------------------------------- ID: " & idVenda & "", fonte, cor, margemEsquerda, margemSuperior + fonte.GetHeight(e.Graphics) * 2)
            linhaAtual += 6

            'Loop para imprimir cada linha do dgv
            For Each linha As DataGridViewRow In dgv_venda.Rows
                'Calcula a posição y de impressão para cada célula
                Dim y As Single = margemSuperior + linhaAtual * fonte.GetHeight(e.Graphics)

                'Loop de imprimir cada célula na linha
                For coluna As Integer = 1 To linha.Cells.Count - 1
                    If coluna = 2 Then
                        espaco = 100
                    ElseIf coluna = 3 Then 'célula da qtde
                        espaco = 200
                    Else
                        espaco = 150
                    End If

                    'Calcula a posição x de impressão para cada célula
                    Dim x As Single = margemEsquerda + (coluna - 1) * espaco

                    'Imprime
                    e.Graphics.DrawString(linha.Cells(coluna).Value.ToString(), fonte, cor, x, y)


                    'Atualiza x para a próxima linha
                    x += 120
                Next

                'Pula para a próxima linha
                linhaAtual += 1
            Next

            'Dados da compra
            e.Graphics.DrawString("Valor total: R$" & txt_valor_total.Text & " -------------------------- Descontos: R$" & txt_desconto.Text & " -------------------------- Total pago: R$ " & txt_valor_pago.Text & " -------------------------- Troco: R$ " & lbl_troco.Text & "", fonte, cor, margemEsquerda, margemSuperior + linhaAtual * fonte.GetHeight(e.Graphics) * 6)

        Catch ex As Exception
            MsgBox("Erro ao imprimir a nota fiscal.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            Exit Sub
        End Try
    End Sub

End Class